namespace WesDialog.Controls
{
    partial class PotControl
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
            this.restoreBtn = new System.Windows.Forms.Button();
            this.tagInfoLabel = new System.Windows.Forms.Label();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.entryCountLabel = new System.Windows.Forms.Label();
            this.previousSnippetBtn = new System.Windows.Forms.Button();
            this.nextSnippetBtn = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.translationTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.isReplacedCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog";
            // 
            // restoreBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.restoreBtn, 2);
            this.restoreBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.restoreBtn.Location = new System.Drawing.Point(593, 384);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(115, 23);
            this.restoreBtn.TabIndex = 48;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = true;
            // 
            // tagInfoLabel
            // 
            this.tagInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tagInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tagInfoLabel, 2);
            this.tagInfoLabel.Location = new System.Drawing.Point(534, 35);
            this.tagInfoLabel.Name = "tagInfoLabel";
            this.tagInfoLabel.Size = new System.Drawing.Size(59, 13);
            this.tagInfoLabel.TabIndex = 43;
            this.tagInfoLabel.Text = "Comments:";
            // 
            // saveFileBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.saveFileBtn, 2);
            this.saveFileBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveFileBtn.Location = new System.Drawing.Point(593, 4);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(115, 23);
            this.saveFileBtn.TabIndex = 46;
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // loadFileBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.loadFileBtn, 2);
            this.loadFileBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadFileBtn.Location = new System.Drawing.Point(475, 4);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(112, 23);
            this.loadFileBtn.TabIndex = 23;
            this.loadFileBtn.Text = "Load";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 8);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 439F));
            this.tableLayoutPanel2.Controls.Add(this.fileInfoLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fileLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 30);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // fileInfoLabel
            // 
            this.fileInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileInfoLabel.AutoSize = true;
            this.fileInfoLabel.Location = new System.Drawing.Point(3, 14);
            this.fileInfoLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.fileInfoLabel.Name = "fileInfoLabel";
            this.fileInfoLabel.Size = new System.Drawing.Size(26, 13);
            this.fileInfoLabel.TabIndex = 41;
            this.fileInfoLabel.Text = "File:";
            // 
            // fileLabel
            // 
            this.fileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(36, 14);
            this.fileLabel.Margin = new System.Windows.Forms.Padding(3);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(13, 13);
            this.fileLabel.TabIndex = 42;
            this.fileLabel.Text = "_";
            // 
            // entryCountLabel
            // 
            this.entryCountLabel.AutoSize = true;
            this.entryCountLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.entryCountLabel.Location = new System.Drawing.Point(239, 388);
            this.entryCountLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 9);
            this.entryCountLabel.Name = "entryCountLabel";
            this.entryCountLabel.Size = new System.Drawing.Size(53, 13);
            this.entryCountLabel.TabIndex = 28;
            this.entryCountLabel.Text = "_/_";
            this.entryCountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // previousSnippetBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.previousSnippetBtn, 2);
            this.previousSnippetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previousSnippetBtn.Location = new System.Drawing.Point(3, 384);
            this.previousSnippetBtn.Name = "previousSnippetBtn";
            this.previousSnippetBtn.Size = new System.Drawing.Size(112, 23);
            this.previousSnippetBtn.TabIndex = 37;
            this.previousSnippetBtn.Text = "Previous";
            this.previousSnippetBtn.UseVisualStyleBackColor = true;
            this.previousSnippetBtn.Click += new System.EventHandler(this.previousSnippetBtn_Click);
            // 
            // nextSnippetBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nextSnippetBtn, 2);
            this.nextSnippetBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextSnippetBtn.Location = new System.Drawing.Point(121, 384);
            this.nextSnippetBtn.Name = "nextSnippetBtn";
            this.nextSnippetBtn.Size = new System.Drawing.Size(112, 23);
            this.nextSnippetBtn.TabIndex = 26;
            this.nextSnippetBtn.Text = "Next";
            this.nextSnippetBtn.UseVisualStyleBackColor = true;
            this.nextSnippetBtn.Click += new System.EventHandler(this.nextSnippetBtn_Click);
            // 
            // idTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.idTextBox, 9);
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idTextBox.Location = new System.Drawing.Point(3, 33);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.idTextBox, 2);
            this.idTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.idTextBox.Size = new System.Drawing.Size(525, 169);
            this.idTextBox.TabIndex = 32;
            // 
            // translationTextBox
            // 
            this.translationTextBox.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.translationTextBox, 9);
            this.translationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translationTextBox.Location = new System.Drawing.Point(3, 208);
            this.translationTextBox.Multiline = true;
            this.translationTextBox.Name = "translationTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.translationTextBox, 2);
            this.translationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translationTextBox.Size = new System.Drawing.Size(525, 168);
            this.translationTextBox.TabIndex = 33;
            // 
            // commentsTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.commentsTextBox, 3);
            this.commentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentsTextBox.Location = new System.Drawing.Point(534, 51);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.commentsTextBox, 3);
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(174, 325);
            this.commentsTextBox.TabIndex = 47;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Controls.Add(this.commentsTextBox, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.translationTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.idTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextSnippetBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.previousSnippetBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.entryCountLabel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadFileBtn, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveFileBtn, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagInfoLabel, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.restoreBtn, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.isReplacedCheckBox, 5, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.39024F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.04878F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 410);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // isReplacedCheckBox
            // 
            this.isReplacedCheckBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.isReplacedCheckBox, 3);
            this.isReplacedCheckBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.isReplacedCheckBox.Enabled = false;
            this.isReplacedCheckBox.Location = new System.Drawing.Point(298, 390);
            this.isReplacedCheckBox.Name = "isReplacedCheckBox";
            this.isReplacedCheckBox.Size = new System.Drawing.Size(171, 17);
            this.isReplacedCheckBox.TabIndex = 49;
            this.isReplacedCheckBox.Text = "Is Replaced";
            this.isReplacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // PotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PotControl";
            this.Size = new System.Drawing.Size(711, 410);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox translationTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button nextSnippetBtn;
        private System.Windows.Forms.Button previousSnippetBtn;
        private System.Windows.Forms.Label entryCountLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Label tagInfoLabel;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.CheckBox isReplacedCheckBox;
    }
}
