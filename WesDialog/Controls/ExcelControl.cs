using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace WesDialog.Controls
{
    public partial class ExcelControl : UserControl
    {
        private ExcelWorksheets _worksheets;
        private int _currentWorksheetIndex;
        private int _currentRowIndex;

        private const int InfoColumn = 1;
        private const string InfoColumnAddress = "A";
        private const int PolishColumn = 2;
        private const string PolishColumnAddress = "B";
        private const int EnglishColumn = 3;
        private const string EnglishColumnAddress = "C";
        private const int CommentColumn = 4;
        private const string CommentColumnAddress = "D";

        private const char CarriageReturnCharacter = '\r';
        private const char NewLineCharacter = '\n';
        private const char SpaceCharacter = ' ';
        private const string QuotationString = "\"";
        private const string DoubleApostroheString = "\u0027\u0027";

        public string PolishText => PrepareValueForCopy(polishTextBox.Text);
        public string EnglishText => PrepareValueForCopy(englishTextBox.Text);

        public ExcelControl()
        {
            InitializeComponent();
        }

        private void LoadFile()
        {
            if (loadFileDialog.ShowDialog() != DialogResult.OK) return;

            fileLabel.Text = loadFileDialog.SafeFileName;
            _currentWorksheetIndex = 1;
            ExcelPackage package = new ExcelPackage(new FileInfo(loadFileDialog.FileName));
            _worksheets = package.Workbook.Worksheets;
            LoadCurrentWorksheet();
        }

        private void LoadCurrentWorksheet()
        {
            _currentRowIndex = 1;
            spreadsheetLabel.Text = _worksheets[_currentWorksheetIndex].Name;
            UpdateSpreadsheetCounter();
            UpdateTextBoxes();
        }

        private void UpdateSpreadsheetCounter()
        {
            spreadsheetCounterLabel.Text = _currentWorksheetIndex + @"/" + _worksheets.Count;
        }

        private void UpdateTextBoxes()
        {
            tagInfoBox.Text = PrepareValueForTextBox(
                _worksheets[_currentWorksheetIndex].GetValue<string>(_currentRowIndex, InfoColumn));

            polishTextBox.Text = PrepareValueForTextBox(
                _worksheets[_currentWorksheetIndex].GetValue<string>(_currentRowIndex, PolishColumn));

            englishTextBox.Text = PrepareValueForTextBox(
                _worksheets[_currentWorksheetIndex].GetValue<string>(_currentRowIndex, EnglishColumn));

            commentBox.Text = PrepareValueForTextBox(
                _worksheets[_currentWorksheetIndex].GetValue<string>(_currentRowIndex, CommentColumn));

            addressLabel.Text = PolishColumnAddress + _currentRowIndex + ':' + EnglishColumnAddress + _currentRowIndex;
        }

        private string PrepareValueForTextBox(string value)
        {
            if (value == null) return string.Empty;

            if (value.Contains(CarriageReturnCharacter) && !value.Contains(NewLineCharacter))
            {
                return value.Replace(CarriageReturnCharacter.ToString(),
                    CarriageReturnCharacter.ToString() + NewLineCharacter);
            }

            if (!value.Contains(CarriageReturnCharacter) && value.Contains(NewLineCharacter))
            {
                return value.Replace(NewLineCharacter.ToString(),
                    CarriageReturnCharacter.ToString() + NewLineCharacter);
            }

            return value;
        }

        private string PrepareValueForCopy(string value)
        {
            value = value.Replace(QuotationString, DoubleApostroheString);
            value = value.Replace(CarriageReturnCharacter.ToString(), string.Empty);

            var splitted = value.Split(NewLineCharacter);
            var formattedValue = string.Empty;
            foreach (var s in splitted)
            {
                if (string.Empty.Equals(s)) continue;
                formattedValue += s.Trim();
                formattedValue += SpaceCharacter;
            }

            return formattedValue.Trim();
        }

        private void PreviousSpreadsheet()
        {
            if (_currentWorksheetIndex <= 1)
            {
                return;
            }

            _currentWorksheetIndex--;

            LoadCurrentWorksheet();
        }

        private void NextSpreadSheet()
        {
            if (_currentWorksheetIndex >= _worksheets.Count)
            {
                return;
            }

            _currentWorksheetIndex++;
            LoadCurrentWorksheet();
        }

        public void NextRow()
        {
            _currentRowIndex++;
            UpdateTextBoxes();
        }

        public void PreviousRow()
        {
            if (_currentRowIndex <= 1)
            {
                return;
            }

            _currentRowIndex--;
            UpdateTextBoxes();
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void nextSpreadsheetBtn_Click(object sender, EventArgs e)
        {
            NextSpreadSheet();
        }

        private void previousSpreadsheetBtn_Click(object sender, EventArgs e)
        {
            PreviousSpreadsheet();
        }

        private void nextTranslationBtn_Click(object sender, EventArgs e)
        {
            NextRow();
        }

        private void previousTranslationBtn_Click(object sender, EventArgs e)
        {
            PreviousRow();
        }
    }
}