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
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.polishTextBox = new System.Windows.Forms.TextBox();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.nextTranslationBtn = new System.Windows.Forms.Button();
            this.previousTranslationBtn = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.commentInfoLabel = new System.Windows.Forms.Label();
            this.tagInfoLabel = new System.Windows.Forms.Label();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.tagInfoBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // englishTextBox
            // 
            this.englishTextBox.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.englishTextBox, 9);
            this.englishTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.englishTextBox.Location = new System.Drawing.Point(3, 207);
            this.englishTextBox.Multiline = true;
            this.englishTextBox.Name = "englishTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.englishTextBox, 2);
            this.englishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.englishTextBox.Size = new System.Drawing.Size(525, 168);
            this.englishTextBox.TabIndex = 33;
            // 
            // polishTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.polishTextBox, 9);
            this.polishTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polishTextBox.Location = new System.Drawing.Point(3, 33);
            this.polishTextBox.Multiline = true;
            this.polishTextBox.Name = "polishTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.polishTextBox, 2);
            this.polishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.polishTextBox.Size = new System.Drawing.Size(525, 168);
            this.polishTextBox.TabIndex = 32;
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
            // 
            // nextTranslationBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.nextTranslationBtn, 2);
            this.nextTranslationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nextTranslationBtn.Location = new System.Drawing.Point(121, 384);
            this.nextTranslationBtn.Name = "nextTranslationBtn";
            this.nextTranslationBtn.Size = new System.Drawing.Size(112, 23);
            this.nextTranslationBtn.TabIndex = 26;
            this.nextTranslationBtn.Text = "Next";
            this.nextTranslationBtn.UseVisualStyleBackColor = true;
            // 
            // previousTranslationBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.previousTranslationBtn, 2);
            this.previousTranslationBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.previousTranslationBtn.Location = new System.Drawing.Point(3, 384);
            this.previousTranslationBtn.Name = "previousTranslationBtn";
            this.previousTranslationBtn.Size = new System.Drawing.Size(112, 23);
            this.previousTranslationBtn.TabIndex = 37;
            this.previousTranslationBtn.Text = "Previous";
            this.previousTranslationBtn.UseVisualStyleBackColor = true;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(239, 388);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 9);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(22, 13);
            this.addressLabel.TabIndex = 28;
            this.addressLabel.Text = "_:_";
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
            // commentBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.commentBox, 3);
            this.commentBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentBox.Location = new System.Drawing.Point(534, 225);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentBox.Size = new System.Drawing.Size(174, 150);
            this.commentBox.TabIndex = 40;
            // 
            // commentInfoLabel
            // 
            this.commentInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.commentInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.commentInfoLabel, 2);
            this.commentInfoLabel.Location = new System.Drawing.Point(534, 209);
            this.commentInfoLabel.Name = "commentInfoLabel";
            this.commentInfoLabel.Size = new System.Drawing.Size(54, 13);
            this.commentInfoLabel.TabIndex = 39;
            this.commentInfoLabel.Text = "Comment:";
            // 
            // tagInfoLabel
            // 
            this.tagInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tagInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tagInfoLabel, 2);
            this.tagInfoLabel.Location = new System.Drawing.Point(534, 35);
            this.tagInfoLabel.Name = "tagInfoLabel";
            this.tagInfoLabel.Size = new System.Drawing.Size(50, 13);
            this.tagInfoLabel.TabIndex = 43;
            this.tagInfoLabel.Text = "Tag Info:";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog";
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
            this.tableLayoutPanel1.Controls.Add(this.tagInfoBox, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.englishTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.polishTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextTranslationBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.previousTranslationBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.addressLabel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.commentBox, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadFileBtn, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveFileBtn, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagInfoLabel, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.commentInfoLabel, 9, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(711, 410);
            this.tableLayoutPanel1.TabIndex = 33;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 30);
            this.tableLayoutPanel2.TabIndex = 45;
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
            // 
            // tagInfoBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tagInfoBox, 3);
            this.tagInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagInfoBox.Location = new System.Drawing.Point(534, 51);
            this.tagInfoBox.Multiline = true;
            this.tagInfoBox.Name = "tagInfoBox";
            this.tagInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagInfoBox.Size = new System.Drawing.Size(174, 150);
            this.tagInfoBox.TabIndex = 47;
            // 
            // PotControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PotControl";
            this.Size = new System.Drawing.Size(711, 410);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox polishTextBox;
        private System.Windows.Forms.Button nextTranslationBtn;
        private System.Windows.Forms.Button previousTranslationBtn;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Label tagInfoLabel;
        private System.Windows.Forms.Label commentInfoLabel;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.TextBox tagInfoBox;
    }
}
