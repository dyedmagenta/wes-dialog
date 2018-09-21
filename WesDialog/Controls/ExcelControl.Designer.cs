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
            this.excelBox = new System.Windows.Forms.GroupBox();
            this.spreadsheetCounterLabel = new System.Windows.Forms.Label();
            this.previousSpreadsheetBtn = new System.Windows.Forms.Button();
            this.nextSpreadsheetBtn = new System.Windows.Forms.Button();
            this.addressLabel = new System.Windows.Forms.Label();
            this.previousTranslationBtn = new System.Windows.Forms.Button();
            this.nextTranslationBtn = new System.Windows.Forms.Button();
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.polishTextBox = new System.Windows.Forms.TextBox();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.spreadsheetLabel = new System.Windows.Forms.Label();
            this.spreadsheetInfoLabel = new System.Windows.Forms.Label();
            this.loadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.excelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // excelBox
            // 
            this.excelBox.Controls.Add(this.spreadsheetCounterLabel);
            this.excelBox.Controls.Add(this.previousSpreadsheetBtn);
            this.excelBox.Controls.Add(this.nextSpreadsheetBtn);
            this.excelBox.Controls.Add(this.addressLabel);
            this.excelBox.Controls.Add(this.previousTranslationBtn);
            this.excelBox.Controls.Add(this.nextTranslationBtn);
            this.excelBox.Controls.Add(this.englishTextBox);
            this.excelBox.Controls.Add(this.polishTextBox);
            this.excelBox.Controls.Add(this.loadFileBtn);
            this.excelBox.Controls.Add(this.spreadsheetLabel);
            this.excelBox.Controls.Add(this.spreadsheetInfoLabel);
            this.excelBox.Location = new System.Drawing.Point(3, 3);
            this.excelBox.Name = "excelBox";
            this.excelBox.Size = new System.Drawing.Size(500, 386);
            this.excelBox.TabIndex = 3;
            this.excelBox.TabStop = false;
            this.excelBox.Text = "Excel";
            // 
            // spreadsheetCounterLabel
            // 
            this.spreadsheetCounterLabel.AutoSize = true;
            this.spreadsheetCounterLabel.Location = new System.Drawing.Point(389, 20);
            this.spreadsheetCounterLabel.Name = "spreadsheetCounterLabel";
            this.spreadsheetCounterLabel.Size = new System.Drawing.Size(24, 13);
            this.spreadsheetCounterLabel.TabIndex = 20;
            this.spreadsheetCounterLabel.Text = "0/0";
            // 
            // previousSpreadsheetBtn
            // 
            this.previousSpreadsheetBtn.Location = new System.Drawing.Point(232, 15);
            this.previousSpreadsheetBtn.Name = "previousSpreadsheetBtn";
            this.previousSpreadsheetBtn.Size = new System.Drawing.Size(75, 23);
            this.previousSpreadsheetBtn.TabIndex = 19;
            this.previousSpreadsheetBtn.Text = "Previous";
            this.previousSpreadsheetBtn.UseVisualStyleBackColor = true;
            this.previousSpreadsheetBtn.Click += new System.EventHandler(this.previousSpreadsheetBtn_Click);
            // 
            // nextSpreadsheetBtn
            // 
            this.nextSpreadsheetBtn.Location = new System.Drawing.Point(313, 15);
            this.nextSpreadsheetBtn.Name = "nextSpreadsheetBtn";
            this.nextSpreadsheetBtn.Size = new System.Drawing.Size(75, 23);
            this.nextSpreadsheetBtn.TabIndex = 18;
            this.nextSpreadsheetBtn.Text = "Next";
            this.nextSpreadsheetBtn.UseVisualStyleBackColor = true;
            this.nextSpreadsheetBtn.Click += new System.EventHandler(this.nextSpreadsheetBtn_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(168, 362);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(22, 13);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "_:_";
            // 
            // previousTranslationBtn
            // 
            this.previousTranslationBtn.Location = new System.Drawing.Point(6, 357);
            this.previousTranslationBtn.Name = "previousTranslationBtn";
            this.previousTranslationBtn.Size = new System.Drawing.Size(75, 23);
            this.previousTranslationBtn.TabIndex = 7;
            this.previousTranslationBtn.Text = "Previous";
            this.previousTranslationBtn.UseVisualStyleBackColor = true;
            this.previousTranslationBtn.Click += new System.EventHandler(this.previousTranslationBtn_Click);
            // 
            // nextTranslationBtn
            // 
            this.nextTranslationBtn.Location = new System.Drawing.Point(87, 357);
            this.nextTranslationBtn.Name = "nextTranslationBtn";
            this.nextTranslationBtn.Size = new System.Drawing.Size(75, 23);
            this.nextTranslationBtn.TabIndex = 6;
            this.nextTranslationBtn.Text = "Next";
            this.nextTranslationBtn.UseVisualStyleBackColor = true;
            this.nextTranslationBtn.Click += new System.EventHandler(this.nextTranslationBtn_Click);
            // 
            // englishTextBox
            // 
            this.englishTextBox.AcceptsReturn = true;
            this.englishTextBox.Location = new System.Drawing.Point(6, 195);
            this.englishTextBox.Multiline = true;
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.englishTextBox.Size = new System.Drawing.Size(488, 154);
            this.englishTextBox.TabIndex = 5;
            // 
            // polishTextBox
            // 
            this.polishTextBox.Location = new System.Drawing.Point(6, 44);
            this.polishTextBox.Multiline = true;
            this.polishTextBox.Name = "polishTextBox";
            this.polishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.polishTextBox.Size = new System.Drawing.Size(488, 145);
            this.polishTextBox.TabIndex = 4;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.Location = new System.Drawing.Point(419, 15);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFileBtn.TabIndex = 3;
            this.loadFileBtn.Text = "Load";
            this.loadFileBtn.UseVisualStyleBackColor = true;
            this.loadFileBtn.Click += new System.EventHandler(this.loadFileBtn_Click);
            // 
            // spreadsheetLabel
            // 
            this.spreadsheetLabel.AutoSize = true;
            this.spreadsheetLabel.Location = new System.Drawing.Point(83, 20);
            this.spreadsheetLabel.Name = "spreadsheetLabel";
            this.spreadsheetLabel.Size = new System.Drawing.Size(13, 13);
            this.spreadsheetLabel.TabIndex = 1;
            this.spreadsheetLabel.Text = "_";
            // 
            // spreadsheetInfoLabel
            // 
            this.spreadsheetInfoLabel.AutoSize = true;
            this.spreadsheetInfoLabel.Location = new System.Drawing.Point(7, 20);
            this.spreadsheetInfoLabel.Name = "spreadsheetInfoLabel";
            this.spreadsheetInfoLabel.Size = new System.Drawing.Size(70, 13);
            this.spreadsheetInfoLabel.TabIndex = 0;
            this.spreadsheetInfoLabel.Text = "Spreadsheet:";
            // 
            // loadFileDialog
            // 
            this.loadFileDialog.FileName = "openFileDialog";
            // 
            // ExcelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excelBox);
            this.Name = "ExcelControl";
            this.Size = new System.Drawing.Size(507, 394);
            this.excelBox.ResumeLayout(false);
            this.excelBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox excelBox;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Label spreadsheetLabel;
        private System.Windows.Forms.Label spreadsheetInfoLabel;
        private System.Windows.Forms.Button nextTranslationBtn;
        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TextBox polishTextBox;
        private System.Windows.Forms.Button previousTranslationBtn;
        private System.Windows.Forms.OpenFileDialog loadFileDialog;
        private System.Windows.Forms.Label spreadsheetCounterLabel;
        private System.Windows.Forms.Button previousSpreadsheetBtn;
        private System.Windows.Forms.Button nextSpreadsheetBtn;
        private System.Windows.Forms.Label addressLabel;
    }
}
