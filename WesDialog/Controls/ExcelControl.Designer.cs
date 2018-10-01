namespace WesDialog.Controls
{
    partial class ExcelControl
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
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.spreadsheetCounterLabel = new System.Windows.Forms.Label();
            this.previousSpreadsheetBtn = new System.Windows.Forms.Button();
            this.nextSpreadsheetBtn = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.polishTextBox = new System.Windows.Forms.TextBox();
            this.spreadsheetLabel = new System.Windows.Forms.Label();
            this.spreadsheetInfoLabel = new System.Windows.Forms.Label();
            this.nextTranslationBtn = new System.Windows.Forms.Button();
            this.previousTranslationBtn = new System.Windows.Forms.Button();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.commentInfoLabel = new System.Windows.Forms.Label();
            this.tagInfoBox = new System.Windows.Forms.TextBox();
            this.tagInfoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog";
            // 
            // spreadsheetCounterLabel
            // 
            this.spreadsheetCounterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spreadsheetCounterLabel.AutoSize = true;
            this.spreadsheetCounterLabel.Location = new System.Drawing.Point(525, 7);
            this.spreadsheetCounterLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 7);
            this.spreadsheetCounterLabel.Name = "spreadsheetCounterLabel";
            this.spreadsheetCounterLabel.Size = new System.Drawing.Size(24, 13);
            this.spreadsheetCounterLabel.TabIndex = 31;
            this.spreadsheetCounterLabel.Text = "0/0";
            // 
            // previousSpreadsheetBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.previousSpreadsheetBtn, 2);
            this.previousSpreadsheetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previousSpreadsheetBtn.Location = new System.Drawing.Point(293, 3);
            this.previousSpreadsheetBtn.Name = "previousSpreadsheetBtn";
            this.previousSpreadsheetBtn.Size = new System.Drawing.Size(110, 21);
            this.previousSpreadsheetBtn.TabIndex = 30;
            this.previousSpreadsheetBtn.Text = "Previous";
            this.previousSpreadsheetBtn.UseVisualStyleBackColor = true;
            this.previousSpreadsheetBtn.Click += new System.EventHandler(this.previousSpreadsheetBtn_Click);
            // 
            // nextSpreadsheetBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nextSpreadsheetBtn, 2);
            this.nextSpreadsheetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextSpreadsheetBtn.Location = new System.Drawing.Point(409, 3);
            this.nextSpreadsheetBtn.Name = "nextSpreadsheetBtn";
            this.nextSpreadsheetBtn.Size = new System.Drawing.Size(110, 21);
            this.nextSpreadsheetBtn.TabIndex = 29;
            this.nextSpreadsheetBtn.Text = "Next";
            this.nextSpreadsheetBtn.UseVisualStyleBackColor = true;
            this.nextSpreadsheetBtn.Click += new System.EventHandler(this.nextSpreadsheetBtn_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(235, 383);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 9);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(22, 13);
            this.addressLabel.TabIndex = 28;
            this.addressLabel.Text = "_:_";
            // 
            // loadFileBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.loadFileBtn, 2);
            this.loadFileBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadFileBtn.Location = new System.Drawing.Point(583, 3);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(119, 21);
            this.loadFileBtn.TabIndex = 23;
            this.loadFileBtn.Text = "Load";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333335F));
            this.tableLayoutPanel1.Controls.Add(this.commentBox, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.englishTextBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.polishTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.previousSpreadsheetBtn, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.spreadsheetCounterLabel, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextSpreadsheetBtn, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadFileBtn, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.nextTranslationBtn, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.previousTranslationBtn, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.addressLabel, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.fileInfoLabel, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileLabel, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.tagInfoBox, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.tagInfoLabel, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.commentInfoLabel, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.838454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.400396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.400396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.400396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.00991F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.400396F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.8107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.739346F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 405);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // englishTextBox
            // 
            this.englishTextBox.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.englishTextBox, 9);
            this.englishTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishTextBox.Location = new System.Drawing.Point(3, 202);
            this.englishTextBox.Multiline = true;
            this.englishTextBox.Name = "englishTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.englishTextBox, 2);
            this.englishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.englishTextBox.Size = new System.Drawing.Size(516, 168);
            this.englishTextBox.TabIndex = 33;
            // 
            // polishTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.polishTextBox, 9);
            this.polishTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polishTextBox.Location = new System.Drawing.Point(3, 30);
            this.polishTextBox.Multiline = true;
            this.polishTextBox.Name = "polishTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.polishTextBox, 4);
            this.polishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.polishTextBox.Size = new System.Drawing.Size(516, 166);
            this.polishTextBox.TabIndex = 32;
            // 
            // spreadsheetLabel
            // 
            this.spreadsheetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spreadsheetLabel.AutoSize = true;
            this.spreadsheetLabel.Location = new System.Drawing.Point(79, 11);
            this.spreadsheetLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.spreadsheetLabel.Name = "spreadsheetLabel";
            this.spreadsheetLabel.Size = new System.Drawing.Size(13, 13);
            this.spreadsheetLabel.TabIndex = 22;
            this.spreadsheetLabel.Text = "_";
            // 
            // spreadsheetInfoLabel
            // 
            this.spreadsheetInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spreadsheetInfoLabel.AutoSize = true;
            this.spreadsheetInfoLabel.Location = new System.Drawing.Point(3, 11);
            this.spreadsheetInfoLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.spreadsheetInfoLabel.Name = "spreadsheetInfoLabel";
            this.spreadsheetInfoLabel.Size = new System.Drawing.Size(70, 13);
            this.spreadsheetInfoLabel.TabIndex = 21;
            this.spreadsheetInfoLabel.Text = "Spreadsheet:";
            // 
            // nextTranslationBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nextTranslationBtn, 2);
            this.nextTranslationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextTranslationBtn.Location = new System.Drawing.Point(119, 379);
            this.nextTranslationBtn.Name = "nextTranslationBtn";
            this.nextTranslationBtn.Size = new System.Drawing.Size(110, 23);
            this.nextTranslationBtn.TabIndex = 26;
            this.nextTranslationBtn.Text = "Next";
            this.nextTranslationBtn.UseVisualStyleBackColor = true;
            this.nextTranslationBtn.Click += new System.EventHandler(this.nextTranslationBtn_Click);
            // 
            // previousTranslationBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.previousTranslationBtn, 2);
            this.previousTranslationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previousTranslationBtn.Location = new System.Drawing.Point(3, 379);
            this.previousTranslationBtn.Name = "previousTranslationBtn";
            this.previousTranslationBtn.Size = new System.Drawing.Size(110, 23);
            this.previousTranslationBtn.TabIndex = 37;
            this.previousTranslationBtn.Text = "Previous";
            this.previousTranslationBtn.UseVisualStyleBackColor = true;
            this.previousTranslationBtn.Click += new System.EventHandler(this.previousTranslationBtn_Click);
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.fileInfoLabel, 3);
            this.fileInfoLabel.Location = new System.Drawing.Point(525, 28);
            this.fileInfoLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(26, 13);
            this.fileInfoLabel.TabIndex = 41;
            this.fileInfoLabel.Text = "File:";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.fileLabel, 3);
            this.fileLabel.Location = new System.Drawing.Point(526, 47);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(4, 3, 3, 0);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(13, 13);
            this.fileLabel.TabIndex = 42;
            this.fileLabel.Text = "_";
            // 
            // commentInfoLabel
            // 
            this.commentInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.commentInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.commentInfoLabel, 2);
            this.commentInfoLabel.Location = new System.Drawing.Point(525, 203);
            this.commentInfoLabel.Name = "commentInfoLabel";
            this.commentInfoLabel.Size = new System.Drawing.Size(54, 13);
            this.commentInfoLabel.TabIndex = 39;
            this.commentInfoLabel.Text = "Comment:";
            // 
            // tagInfoBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tagInfoBox, 3);
            this.tagInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagInfoBox.Location = new System.Drawing.Point(525, 81);
            this.tagInfoBox.Multiline = true;
            this.tagInfoBox.Name = "tagInfoBox";
            this.tagInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagInfoBox.Size = new System.Drawing.Size(177, 115);
            this.tagInfoBox.TabIndex = 44;
            // 
            // tagInfoLabel
            // 
            this.tagInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tagInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tagInfoLabel, 2);
            this.tagInfoLabel.Location = new System.Drawing.Point(525, 65);
            this.tagInfoLabel.Name = "tagInfoLabel";
            this.tagInfoLabel.Size = new System.Drawing.Size(50, 13);
            this.tagInfoLabel.TabIndex = 43;
            this.tagInfoLabel.Text = "Tag Info:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.55172F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.44827F));
            this.tableLayoutPanel2.Controls.Add(this.spreadsheetInfoLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.spreadsheetLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(290, 27);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // commentBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.commentBox, 3);
            this.commentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentBox.Location = new System.Drawing.Point(525, 219);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentBox.Size = new System.Drawing.Size(177, 151);
            this.commentBox.TabIndex = 46;
            // 
            // ExcelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExcelControl";
            this.Size = new System.Drawing.Size(705, 405);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Label spreadsheetCounterLabel;
        private System.Windows.Forms.Button previousSpreadsheetBtn;
        private System.Windows.Forms.Button nextSpreadsheetBtn;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TextBox polishTextBox;
        private System.Windows.Forms.Label spreadsheetLabel;
        private System.Windows.Forms.Label spreadsheetInfoLabel;
        private System.Windows.Forms.Button nextTranslationBtn;
        private System.Windows.Forms.Button previousTranslationBtn;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label commentInfoLabel;
        private System.Windows.Forms.TextBox tagInfoBox;
        private System.Windows.Forms.Label tagInfoLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox commentBox;
    }
}
