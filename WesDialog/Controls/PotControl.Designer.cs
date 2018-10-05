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
            this.msgStrTextBox = new System.Windows.Forms.TextBox();
            this.msgIdTextBox = new System.Windows.Forms.TextBox();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.nextSnippetBtn = new System.Windows.Forms.Button();
            this.previousSnippetBtn = new System.Windows.Forms.Button();
            this.snippetAmountLabel = new System.Windows.Forms.Label();
            this.fileInfoLabel = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.commentInfoLabel = new System.Windows.Forms.Label();
            this.tagInfoLabel = new System.Windows.Forms.Label();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tagInfoTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.originalSnippetLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgStrTextBox
            // 
            this.msgStrTextBox.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.msgStrTextBox, 9);
            this.msgStrTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgStrTextBox.Location = new System.Drawing.Point(3, 207);
            this.msgStrTextBox.Multiline = true;
            this.msgStrTextBox.Name = "msgStrTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.msgStrTextBox, 2);
            this.msgStrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgStrTextBox.Size = new System.Drawing.Size(525, 168);
            this.msgStrTextBox.TabIndex = 33;
            // 
            // msgIdTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.msgIdTextBox, 9);
            this.msgIdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgIdTextBox.Location = new System.Drawing.Point(3, 33);
            this.msgIdTextBox.Multiline = true;
            this.msgIdTextBox.Name = "msgIdTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.msgIdTextBox, 2);
            this.msgIdTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgIdTextBox.Size = new System.Drawing.Size(525, 168);
            this.msgIdTextBox.TabIndex = 32;
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
            // 
            // snippetAmountLabel
            // 
            this.snippetAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.snippetAmountLabel.AutoSize = true;
            this.snippetAmountLabel.Location = new System.Drawing.Point(239, 388);
            this.snippetAmountLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 9);
            this.snippetAmountLabel.Name = "snippetAmountLabel";
            this.snippetAmountLabel.Size = new System.Drawing.Size(24, 13);
            this.snippetAmountLabel.TabIndex = 28;
            this.snippetAmountLabel.Text = "_/_";
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
            // referenceTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.referenceTextBox, 3);
            this.referenceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referenceTextBox.Location = new System.Drawing.Point(534, 225);
            this.referenceTextBox.Multiline = true;
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.referenceTextBox.Size = new System.Drawing.Size(174, 150);
            this.referenceTextBox.TabIndex = 40;
            // 
            // commentInfoLabel
            // 
            this.commentInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.commentInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.commentInfoLabel, 2);
            this.commentInfoLabel.Location = new System.Drawing.Point(534, 209);
            this.commentInfoLabel.Name = "commentInfoLabel";
            this.commentInfoLabel.Size = new System.Drawing.Size(65, 13);
            this.commentInfoLabel.TabIndex = 39;
            this.commentInfoLabel.Text = "References:";
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
            this.tableLayoutPanel1.Controls.Add(this.tagInfoTextBox, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.msgStrTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.msgIdTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nextSnippetBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.previousSnippetBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.snippetAmountLabel, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.referenceTextBox, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.loadFileBtn, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.saveFileBtn, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.tagInfoLabel, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.commentInfoLabel, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.restoreBtn, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.originalSnippetLabel, 5, 5);
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
            // tagInfoTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tagInfoTextBox, 3);
            this.tagInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tagInfoTextBox.Location = new System.Drawing.Point(534, 51);
            this.tagInfoTextBox.Multiline = true;
            this.tagInfoTextBox.Name = "tagInfoTextBox";
            this.tagInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagInfoTextBox.Size = new System.Drawing.Size(174, 150);
            this.tagInfoTextBox.TabIndex = 47;
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
            // originalSnippetLabel
            // 
            this.originalSnippetLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.originalSnippetLabel, 5);
            this.originalSnippetLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.originalSnippetLabel.Location = new System.Drawing.Point(298, 388);
            this.originalSnippetLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 9);
            this.originalSnippetLabel.Name = "originalSnippetLabel";
            this.originalSnippetLabel.Size = new System.Drawing.Size(289, 13);
            this.originalSnippetLabel.TabIndex = 49;
            this.originalSnippetLabel.Text = "_";
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

        private System.Windows.Forms.TextBox msgStrTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox msgIdTextBox;
        private System.Windows.Forms.Button nextSnippetBtn;
        private System.Windows.Forms.Button previousSnippetBtn;
        private System.Windows.Forms.Label snippetAmountLabel;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label fileInfoLabel;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Label tagInfoLabel;
        private System.Windows.Forms.Label commentInfoLabel;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.TextBox tagInfoTextBox;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Label originalSnippetLabel;
    }
}
