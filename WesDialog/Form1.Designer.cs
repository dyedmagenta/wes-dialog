namespace WesDialog
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.approveSnippetBtn = new System.Windows.Forms.Button();
            this.polishSnippetRadio = new System.Windows.Forms.RadioButton();
            this.englishSnippetRadio = new System.Windows.Forms.RadioButton();
            this.excelControl1 = new WesDialog.Controls.ExcelControl();
            this.wmlControl1 = new WesDialog.Controls.WMLControl();
            this.SuspendLayout();
            // 
            // approveSnippetBtn
            // 
            this.approveSnippetBtn.Location = new System.Drawing.Point(524, 177);
            this.approveSnippetBtn.Name = "approveSnippetBtn";
            this.approveSnippetBtn.Size = new System.Drawing.Size(82, 23);
            this.approveSnippetBtn.TabIndex = 4;
            this.approveSnippetBtn.Text = "Approve";
            this.approveSnippetBtn.UseVisualStyleBackColor = true;
            this.approveSnippetBtn.Click += new System.EventHandler(this.approveSnippetBtn_Click);
            // 
            // polishSnippetRadio
            // 
            this.polishSnippetRadio.AutoSize = true;
            this.polishSnippetRadio.Location = new System.Drawing.Point(524, 229);
            this.polishSnippetRadio.Name = "polishSnippetRadio";
            this.polishSnippetRadio.Size = new System.Drawing.Size(53, 17);
            this.polishSnippetRadio.TabIndex = 5;
            this.polishSnippetRadio.Text = "Polish";
            this.polishSnippetRadio.UseVisualStyleBackColor = true;
            this.polishSnippetRadio.CheckedChanged += new System.EventHandler(this.polishSnippetRadio_CheckedChanged);
            // 
            // englishSnippetRadio
            // 
            this.englishSnippetRadio.AutoSize = true;
            this.englishSnippetRadio.Checked = true;
            this.englishSnippetRadio.Location = new System.Drawing.Point(524, 206);
            this.englishSnippetRadio.Name = "englishSnippetRadio";
            this.englishSnippetRadio.Size = new System.Drawing.Size(59, 17);
            this.englishSnippetRadio.TabIndex = 6;
            this.englishSnippetRadio.TabStop = true;
            this.englishSnippetRadio.Text = "English";
            this.englishSnippetRadio.UseVisualStyleBackColor = true;
            this.englishSnippetRadio.CheckedChanged += new System.EventHandler(this.englishSnippetRadio_CheckedChanged);
            // 
            // excelControl1
            // 
            this.excelControl1.Location = new System.Drawing.Point(612, 12);
            this.excelControl1.Name = "excelControl1";
            this.excelControl1.Size = new System.Drawing.Size(507, 394);
            this.excelControl1.TabIndex = 1;
            // 
            // wmlControl1
            // 
            this.wmlControl1.Location = new System.Drawing.Point(12, 12);
            this.wmlControl1.Name = "wmlControl1";
            this.wmlControl1.ReplacementText = null;
            this.wmlControl1.Size = new System.Drawing.Size(506, 388);
            this.wmlControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 406);
            this.Controls.Add(this.englishSnippetRadio);
            this.Controls.Add(this.polishSnippetRadio);
            this.Controls.Add(this.approveSnippetBtn);
            this.Controls.Add(this.excelControl1);
            this.Controls.Add(this.wmlControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.WMLControl wmlControl1;
        private Controls.ExcelControl excelControl1;
        private System.Windows.Forms.Button approveSnippetBtn;
        private System.Windows.Forms.RadioButton polishSnippetRadio;
        private System.Windows.Forms.RadioButton englishSnippetRadio;
    }
}

