using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WesDialog.Data;

namespace WesDialog.Controls
{
    public partial class WMLControl : UserControl
    {
        private List<Snippet> _snippets = new List<Snippet>();
        private int _currentSnippetIndex;
        private const string SnippetPattern = @"(?<=_ *"")(.*?)(?="")";
        private readonly Regex _snippetRegex;

        public string ReplacementText
        {
            get => _replacementText;
            set => SetReplacementText(value);
        }

        private string _replacementText;

        public WMLControl()
        {
            InitializeComponent();
            _snippetRegex = new Regex(SnippetPattern);
        }

        private void LoadFile()
        {
            var dialogResult = loadFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            var stream = loadFileDialog.OpenFile();
            filenameLabel.Text = loadFileDialog.SafeFileName;
            LoadSnippets(stream);
        }

        private void LoadSnippets(Stream stream)
        {
            _snippets = ParseWmlIntoSnippets(stream);
            saveFileBtn.Enabled = true;
            _currentSnippetIndex = 0;
            if (_snippets.Count <= 0) return;
            LoadCurrentSnippet();
            UpdateSnippetCounter();
            statusLabel.Text = @"_";
        }

        private List<Snippet> ParseWmlIntoSnippets(Stream wmlFileStream)
        {
            using (wmlFileStream)
            {
                var reader = new StreamReader(wmlFileStream, Encoding.UTF8);
                var snippetsList = new List<Snippet>();

                long lineIndex = 0;
                while (!reader.EndOfStream)
                {
                    var text = reader.ReadLine();
                    var snippet = ExtractSnippet(text, lineIndex);
                    if (snippet != null)
                    {
                        snippetsList.Add(snippet);
                    }

                    lineIndex++;
                }
                return snippetsList;
            }
        }

        private Snippet ExtractSnippet(string text, long lineIndex)
        {
            var match = _snippetRegex.Match(text);

            if (!match.Success)
            {
                return null;
            }

            var snippet = new Snippet
            {
                Text = match.Value,
                LineIndex = lineIndex,
                StartsAtCharacter = match.Index,
                IsReplacement = false,
                ReplacementText = null
            };
            return snippet;
        }

        private void LoadCurrentSnippet()
        {
            var snippetToLoad = _snippets[_currentSnippetIndex];
            textBox.Text = snippetToLoad.IsReplacement ? snippetToLoad.ReplacementText : snippetToLoad.Text;
            replacedCheckBox.Checked = snippetToLoad.IsReplacement;
        }

        public void PreviousSnippet()
        {
            if (_currentSnippetIndex <= 0)
            {
                return;
            }

            _currentSnippetIndex--;
            LoadCurrentSnippet();
            UpdateSnippetCounter();
        }

        public void NextSnippet()
        {
            var maxSnippetIndex = _snippets.Count - 1;
            if (_currentSnippetIndex >= maxSnippetIndex)
            {
                return;
            }

            _currentSnippetIndex++;
            LoadCurrentSnippet();
            UpdateSnippetCounter();
        }

        private void UpdateSnippetCounter()
        {
            snippetCounterLabel.Text = $@"{_currentSnippetIndex + 1}/{_snippets.Count}";
        }

        private void SetReplacementText(string replacement)
        {
            _replacementText = replacement;
            replacementLabel.Text = replacement;
        }

        public void RestoreSnippet()
        {
            if (_snippets.Count == 0)
            {
                return;
            }

            var currentSnippet = _snippets[_currentSnippetIndex];
            currentSnippet.IsReplacement = false;
            currentSnippet.ReplacementText = null;
            LoadCurrentSnippet();
        }

        public void ReplaceSnippet()
        {
            if (_snippets.Count == 0 || ReplacementText == null)
            {
                return;
            }

            var currentSnippet = _snippets[_currentSnippetIndex];
            currentSnippet.IsReplacement = true;
            currentSnippet.ReplacementText = ReplacementText;
            LoadCurrentSnippet();
        }

        private void SaveFile()
        {
            var stream = File.OpenRead(loadFileDialog.FileName);
            var text = InsertSnippetsIntoWml(stream);
            File.WriteAllText(loadFileDialog.FileName, text);

            statusLabel.Text = @"SAVED";

            LoadSnippets(loadFileDialog.OpenFile());
        }

        private string InsertSnippetsIntoWml(Stream wmlFileStream)
        {
            using (wmlFileStream)
            {
                var reader = new StreamReader(wmlFileStream, Encoding.UTF8);
                var builder = new StringBuilder();
                long lineIndex = 0;
                var snippetIndex = 0;
                while (!reader.EndOfStream)
                {
                    var text = reader.ReadLine();
                    if (lineIndex == _snippets[snippetIndex].LineIndex)
                    {
                        if (_snippets[snippetIndex].IsReplacement && text != null)
                        {
                            text = _snippetRegex.Replace(text, _snippets[snippetIndex].ReplacementText);
                            snippetIndex++;
                        }
                    }
                    builder.AppendLine(text);
                    lineIndex++;
                }

                return builder.ToString();
            }
        }

        private string ReplaceWmlLine(string line, Snippet snippet)
        {
            return !snippet.IsReplacement ? line : _snippetRegex.Replace(line, snippet.ReplacementText);
        }

        // Button bindings no logic here pls

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void previousSnippetBtn_Click(object sender, EventArgs e)
        {
            PreviousSnippet();
        }

        private void nextSnippetBtn_Click(object sender, EventArgs e)
        {
            NextSnippet();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            RestoreSnippet();
        }

        private void replaceSnippetBtn_Click(object sender, EventArgs e)
        {
            ReplaceSnippet();
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
    }
}