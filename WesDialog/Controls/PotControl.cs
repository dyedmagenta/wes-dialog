using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WesDialog.Data;
using System.Text.RegularExpressions;
using Karambolo.PO;

namespace WesDialog.Controls
{
    public partial class PotControl : UserControl
    {
        private const string COUNT_SEPARATOR = "/";   
        private POParser _parser;
        private POCatalog _catalog;
        private POSingularEntry _currentEntry;
        private int _currentEntryIndex = 0;
        private string[] _replacedEntries;
        
        public PotControl()
        {
            InitializeComponent();
            _parser = new POParser(new POParserSettings
            {
                PreserveHeadersOrder = true,
                ReadHeaderOnly = false,
                SkipComments = false,
                SkipInfoHeaders = false
            });
        }

        private void LoadPotFile()
        {
            var dialogResult = loadFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            var stream = loadFileDialog.OpenFile();
            fileLabel.Text = loadFileDialog.SafeFileName;
            LoadCatalog(stream);
        }

        private void LoadCatalog(Stream textStream)
        {
            var result = _parser.Parse(textStream);
            if(result.Success)
            {
                _catalog = result.Catalog;
                _replacedEntries = new string[_catalog.Count];
            }
            else
            {
                //Err
            }
        }

        private void DisplayCatalogEntry()
        {
            if(_currentEntryIndex >= _catalog.Count || _currentEntryIndex < 0)
            {
                //err
                return;
            }
            _currentEntry = (POSingularEntry)_catalog[_currentEntryIndex];
            idTextBox.Text = _currentEntry.Key.Id;
            translationTextBox.Text = _currentEntry.Translation;
            entryCountLabel.Text = (_currentEntryIndex + 1) + COUNT_SEPARATOR + _catalog.Count;
            var commentsTextBuilder = new StringBuilder();
            foreach (var comment in _currentEntry.Comments)
            {
                if(comment.Kind == POCommentKind.Extracted)
                {
                    commentsTextBuilder.AppendLine(((POExtractedComment)comment).Text);
                } else if(comment.Kind == POCommentKind.Reference)
                {
                    commentsTextBuilder.AppendLine(GetReferenceCommentText((POReferenceComment) comment));
                }
            }
            commentsTextBox.Text = commentsTextBuilder.ToString();
        }

        private string GetReferenceCommentText(POReferenceComment comment)
        {
            var reference = comment.References[0];
            var splitted = reference.FilePath.Split('\\');
            return splitted[splitted.Length-1] + ":" + reference.Line;
        }

        public void DisplayNextEntry()
        {
            if (_currentEntryIndex >= _catalog.Count - 1)
            {
                //err
                return;
            }
            _currentEntryIndex++;
            DisplayCatalogEntry();
        }

        public void DisplayPreviousEntry()
        {
            if (_currentEntryIndex == 0)
            {
                //err
                return;
            }
            _currentEntryIndex--;
            DisplayCatalogEntry();
        }

        public void Replace(string replacement)
        {
            _replacedEntries[_currentEntryIndex] = _currentEntry.Translation;
            _currentEntry.Translation = replacement;
        }

        public void Restore()
        {
            if (_replacedEntries[_currentEntryIndex] == null)
            {
                return;
            }
            _currentEntry.Translation = _replacedEntries[_currentEntryIndex];
            _replacedEntries[_currentEntryIndex] = null;
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            LoadPotFile();
            DisplayCatalogEntry();
        }

        private void nextSnippetBtn_Click(object sender, EventArgs e)
        {
            DisplayNextEntry();
        }

        private void previousSnippetBtn_Click(object sender, EventArgs e)
        {
            DisplayPreviousEntry();
        }
    }
}
