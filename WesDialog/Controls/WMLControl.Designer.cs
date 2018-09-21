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
            this.wmlBox = new System.Windows.Forms.GroupBox();
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.wmlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmlBox
            // 
            this.wmlBox.Controls.Add(this.statusLabel);
            this.wmlBox.Controls.Add(this.snippetCounterLabel);
            this.wmlBox.Controls.Add(this.replacedCheckBox);
            this.wmlBox.Controls.Add(this.replacementLabel);
            this.wmlBox.Controls.Add(this.replacementLabelInfo);
            this.wmlBox.Controls.Add(this.restoreBtn);
            this.wmlBox.Controls.Add(this.saveFileBtn);
            this.wmlBox.Controls.Add(this.replaceSnippetBtn);
            this.wmlBox.Controls.Add(this.textBox);
            this.wmlBox.Controls.Add(this.nextSnippetBtn);
            this.wmlBox.Controls.Add(this.previousSnippetBtn);
            this.wmlBox.Controls.Add(this.loadFileBtn);
            this.wmlBox.Controls.Add(this.filenameLabel);
            this.wmlBox.Controls.Add(this.filenameInfoLabel);
            this.wmlBox.Location = new System.Drawing.Point(3, 3);
            this.wmlBox.Name = "wmlBox";
            this.wmlBox.Size = new System.Drawing.Size(500, 385);
            this.wmlBox.TabIndex = 2;
            this.wmlBox.TabStop = false;
            this.wmlBox.Text = "WML";
            // 
            // snippetCounterLabel
            // 
            this.snippetCounterLabel.AutoSize = true;
            this.snippetCounterLabel.Location = new System.Drawing.Point(168, 361);
            this.snippetCounterLabel.Name = "snippetCounterLabel";
            this.snippetCounterLabel.Size = new System.Drawing.Size(24, 13);
            this.snippetCounterLabel.TabIndex = 13;
            this.snippetCounterLabel.Text = "0/0";
            // 
            // replacedCheckBox
            // 
            this.replacedCheckBox.AutoSize = true;
            this.replacedCheckBox.Enabled = false;
            this.replacedCheckBox.Location = new System.Drawing.Point(249, 360);
            this.replacedCheckBox.Name = "replacedCheckBox";
            this.replacedCheckBox.Size = new System.Drawing.Size(83, 17);
            this.replacedCheckBox.TabIndex = 12;
            this.replacedCheckBox.Text = "Is Replaced";
            this.replacedCheckBox.UseVisualStyleBackColor = true;
            // 
            // replacementLabel
            // 
            this.replacementLabel.AutoSize = true;
            this.replacementLabel.Location = new System.Drawing.Point(106, 41);
            this.replacementLabel.Name = "replacementLabel";
            this.replacementLabel.Size = new System.Drawing.Size(13, 13);
            this.replacementLabel.TabIndex = 11;
            this.replacementLabel.Text = "_";
            // 
            // replacementLabelInfo
            // 
            this.replacementLabelInfo.AutoSize = true;
            this.replacementLabelInfo.Location = new System.Drawing.Point(7, 41);
            this.replacementLabelInfo.Name = "replacementLabelInfo";
            this.replacementLabelInfo.Size = new System.Drawing.Size(93, 13);
            this.replacementLabelInfo.TabIndex = 10;
            this.replacementLabelInfo.Text = "Replacement text:";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(338, 356);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(75, 23);
            this.restoreBtn.TabIndex = 9;
            this.restoreBtn.Text = "Restore";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Enabled = false;
            this.saveFileBtn.Location = new System.Drawing.Point(419, 15);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(75, 23);
            this.saveFileBtn.TabIndex = 8;
            this.saveFileBtn.Text = "Save";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // replaceSnippetBtn
            // 
            this.replaceSnippetBtn.Location = new System.Drawing.Point(419, 356);
            this.replaceSnippetBtn.Name = "replaceSnippetBtn";
            this.replaceSnippetBtn.Size = new System.Drawing.Size(75, 23);
            this.replaceSnippetBtn.TabIndex = 7;
            this.replaceSnippetBtn.Text = "Replace";
            this.replaceSnippetBtn.UseVisualStyleBackColor = true;
            this.replaceSnippetBtn.Click += new System.EventHandler(this.replaceSnippetBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 57);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(488, 293);
            this.textBox.TabIndex = 6;
            // 
            // nextSnippetBtn
            // 
            this.nextSnippetBtn.Location = new System.Drawing.Point(87, 356);
            this.nextSnippetBtn.Name = "nextSnippetBtn";
            this.nextSnippetBtn.Size = new System.Drawing.Size(75, 23);
            this.nextSnippetBtn.TabIndex = 5;
            this.nextSnippetBtn.Text = "Next";
            this.nextSnippetBtn.UseVisualStyleBackColor = true;
            this.nextSnippetBtn.Click += new System.EventHandler(this.nextSnippetBtn_Click);
            // 
            // previousSnippetBtn
            // 
            this.previousSnippetBtn.Location = new System.Drawing.Point(6, 356);
            this.previousSnippetBtn.Name = "previousSnippetBtn";
            this.previousSnippetBtn.Size = new System.Drawing.Size(75, 23);
            this.previousSnippetBtn.TabIndex = 4;
            this.previousSnippetBtn.Text = "Previous";
            this.previousSnippetBtn.UseVisualStyleBackColor = true;
            this.previousSnippetBtn.Click += new System.EventHandler(this.previousSnippetBtn_Click);
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(338, 15);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Load";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(65, 20);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(13, 13);
            this.filenameLabel.TabIndex = 1;
            this.filenameLabel.Text = "_";
            // 
            // filenameInfoLabel
            // 
            this.filenameInfoLabel.AutoSize = true;
            this.filenameInfoLabel.Location = new System.Drawing.Point(7, 20);
            this.filenameInfoLabel.Name = "filenameInfoLabel";
            this.filenameInfoLabel.Size = new System.Drawing.Size(52, 13);
            this.filenameInfoLabel.TabIndex = 0;
            this.filenameInfoLabel.Text = "Filename:";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(416, 41);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(13, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "_";
            // 
            // WMLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wmlBox);
            this.Name = "WMLControl";
            this.Size = new System.Drawing.Size(506, 388);
            this.wmlBox.ResumeLayout(false);
            this.wmlBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox wmlBox;
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
    }
}
