using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WesDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _isEnglish = true;

        private void CopyPolish()
        {
//            var text = excelControl1.PolishText;
//            if (text == null || string.Empty.Equals(text)) return;
//            Clipboard.SetText(text);
//            wmlControl1.ReplacementText = text;
        }

        private void CopyEnglish()
        {
//            var text = excelControl1.EnglishText;
//            if (text == null || string.Empty.Equals(text)) return;
//            Clipboard.SetText(text);
//            wmlControl1.ReplacementText = text;
        }

        private void englishSnippetRadio_CheckedChanged(object sender, EventArgs e)
        {
            _isEnglish = true;
        }

        private void polishSnippetRadio_CheckedChanged(object sender, EventArgs e)
        {
            _isEnglish = false;
        }

        private void ApproveSnippet()
        {
            if (_isEnglish)
            {
                CopyEnglish();
            }
            else
            {
                CopyPolish();
            }
//
//            wmlControl1.ReplaceSnippet();
//            wmlControl1.NextSnippet();
//            excelControl1.NextRow();
        }

        private void approveSnippetBtn_Click(object sender, EventArgs e)
        {
            ApproveSnippet();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'p':
                    ApproveSnippet();
                    break;
                case 'k':
//                    excelControl1.PreviousRow();
                    break;
                case 'l':
//                    excelControl1.NextRow();
                    break;
                case 'a':
//                    wmlControl1.PreviousSnippet();
                    break;
                case 's':
//                    wmlControl1.NextSnippet();
                    break;
                case 'r':
//                    wmlControl1.RestoreSnippet();
                    break;
                case 't':
//                    wmlControl1.ReplaceSnippet();
                    break;
                case 'y':
                    CopyPolish();
                    break;
                case 'u':
                    CopyEnglish();
                    break;
            }
        }
    }
}