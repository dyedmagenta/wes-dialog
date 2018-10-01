namespace WesDialog.Controls
{
    partial class WMLControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusLabel = new System.Windows.Forms.Label();
            this.snippetCounterLabel = new System.Windows.Forms.Label();
            this.replacedCheckBox = new System.Windows.Forms.CheckBox();
            this.replacementLabel = new System.Windows.Forms.Label();
            this.replacementLabelInfo = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.replaceSnippetBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.nextSnippetBtn = new System.Windows.Forms.Button();
            this.previousSnippetBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.filenameInfoLabel = new System.Windows.Forms.Label();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 36);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(3);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(13, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "_";
            // 
            // snippetCounterLabel
            // 
            this.snippetCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.snippetCounterLabel.AutoSize = true;
            this.snippetCounterLabel.Location = new System.Drawing.Point(237, 385);
            this.snippetCounterLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.snippetCounterLabel.Name = "snippetCounterLabel";
            this.snippetCounterLabel.Size = new System.Drawing.Size(24, 13);
            this.snippetCounterLabel.TabIndex = 13;
            this.snippetCounterLabel.Text = "0/0";
            // 
            // replacedCheckBox
            // 
            this.replacedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.replacedCheckBox.AutoSize = true;
            this.replacedCheckBox.Enabled = false;
            this.replacedCheckBox.Location = new System.Drawing.Point(295, 383);
            this.replacedCheckBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.replacedCheckBox.Name = "replacedCheckBox";
            this.replacedCheckBox.Size = new System.Drawing.Size(83, 17);
            this.replacedCheckBox.TabIndex = 12;
            this.replacedCheckBox.Text = "Is Replaced";
            this.replacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // replacementLabel
            // 
            this.replacementLabel.AutoSize = true;
            this.replacementLabel.Location = new System.Drawing.Point(103, 39);
            this.replacementLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.replacementLabel.Name = "replacementLabel";
            this.replacementLabel.Size = new System.Drawing.Size(13, 13);
            this.replacementLabel.TabIndex = 11;
            this.replacementLabel.Text = "_";
            // 
            // replacementLabelInfo
            // 
            this.replacementLabelInfo.AutoSize = true;
            this.replacementLabelInfo.Location = new System.Drawing.Point(3, 39);
            this.replacementLabelInfo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.replacementLabelInfo.Name = "replacementLabelInfo";
            this.replacementLabelInfo.Size = new System.Drawing.Size(93, 13);
            this.replacementLabelInfo.TabIndex = 10;
            this.replacementLabelInfo.Text = "Replacement text:";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.restoreBtn.Location = new System.Drawing.Point(470, 379);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(111, 23);
            this.restoreBtn.TabIndex = 9;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveFileBtn.Enabled = false;
            this.saveFileBtn.Location = new System.Drawing.Point(3, 3);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(115, 23);
            this.saveFileBtn.TabIndex = 8;
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // replaceSnippetBtn
            // 
            this.replaceSnippetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.replaceSnippetBtn.Location = new System.Drawing.Point(587, 379);
            this.replaceSnippetBtn.Name = "replaceSnippetBtn";
            this.replaceSnippetBtn.Size = new System.Drawing.Size(115, 23);
            this.replaceSnippetBtn.TabIndex = 7;
            this.replaceSnippetBtn.Text = "Replace";
            this.replaceSnippetBtn.UseVisualStyleBackColor = true;
            this.replaceSnippetBtn.Click += new System.EventHandler(this.replaceSnippetBtn_Click);
            // 
            // textBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox, 5);
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(3, 70);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.tableLayoutPanel1.SetRowSpan(this.textBox, 4);
            this.textBox.Size = new System.Drawing.Size(578, 262);
            this.textBox.TabIndex = 6;
            // 
            // nextSnippetBtn
            // 
            this.nextSnippetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextSnippetBtn.Location = new System.Drawing.Point(120, 379);
            this.nextSnippetBtn.Name = "nextSnippetBtn";
            this.nextSnippetBtn.Size = new System.Drawing.Size(111, 23);
            this.nextSnippetBtn.TabIndex = 5;
            this.nextSnippetBtn.Text = "Next";
            this.nextSnippetBtn.UseVisualStyleBackColor = true;
            this.nextSnippetBtn.Click += new System.EventHandler(this.nextSnippetBtn_Click);
            // 
            // previousSnippetBtn
            // 
            this.previousSnippetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previousSnippetBtn.Location = new System.Drawing.Point(3, 379);
            this.previousSnippetBtn.Name = "previousSnippetBtn";
            this.previousSnippetBtn.Size = new System.Drawing.Size(111, 23);
            this.previousSnippetBtn.TabIndex = 4;
            this.previousSnippetBtn.Text = "Previous";
            this.previousSnippetBtn.UseVisualStyleBackColor = true;
            this.previousSnippetBtn.Click += new System.EventHandler(this.previousSnippetBtn_Click);
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadFileBtn.Location = new System.Drawing.Point(470, 3);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(111, 23);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Load";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(103, 6);
            this.filenameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(13, 13);
            this.filenameLabel.TabIndex = 1;
            this.filenameLabel.Text = "_";
            // 
            // filenameInfoLabel
            // 
            this.filenameInfoLabel.AutoSize = true;
            this.filenameInfoLabel.Location = new System.Drawing.Point(3, 6);
            this.filenameInfoLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.filenameInfoLabel.Name = "filenameInfoLabel";
            this.filenameInfoLabel.Size = new System.Drawing.Size(52, 13);
            this.filenameInfoLabel.TabIndex = 0;
            this.filenameInfoLabel.Text = "Filename:";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.226951F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82269F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.replacedCheckBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.loadFileBtn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextSnippetBtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.previousSnippetBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.replaceSnippetBtn, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.restoreBtn, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.snippetCounterLabel, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 405);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.61572F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.38428F));
            this.tableLayoutPanel2.Controls.Add(this.filenameInfoLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.replacementLabelInfo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.filenameLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.replacementLabel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.statusLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.saveFileBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(584, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(121, 67);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // WMLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WMLControl";
            this.Size = new System.Drawing.Size(705, 405);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button nextSnippetBtn;
        private System.Windows.Forms.Button previousSnippetBtn;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.Label filenameInfoLabel;
        private System.Windows.Forms.Button replaceSnippetBtn;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label replacementLabel;
        private System.Windows.Forms.Label replacementLabelInfo;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.CheckBox replacedCheckBox;
        private System.Windows.Forms.Label snippetCounterLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
