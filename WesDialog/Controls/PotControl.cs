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

namespace WesDialog.Controls
{
    public partial class PotControl : UserControl
    {
        public PotControl()
        {
            InitializeComponent();
        }

        private void LoadPotFile()
        {
            var dialogResult = loadFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            var stream = loadFileDialog.OpenFile();
            fileLabel.Text = loadFileDialog.SafeFileName;
            LoadSnippet(stream);
        }

        private void LoadSnippet(Stream stream)
        {

        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            LoadPotFile();
        }
    }
}
