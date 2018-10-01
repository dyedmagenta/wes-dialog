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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.excelControl1 = new WesDialog.Controls.ExcelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wmlPage = new System.Windows.Forms.TabPage();
            this.wmlControl1 = new WesDialog.Controls.WMLControl();
            this.potPage = new System.Windows.Forms.TabPage();
            this.potControl1 = new WesDialog.Controls.PotControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.approveSnippetBtn = new System.Windows.Forms.Button();
            this.englishSnippetRadio = new System.Windows.Forms.RadioButton();
            this.polishSnippetRadio = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.wmlPage.SuspendLayout();
            this.potPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.excelControl1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.653916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.34608F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1474, 549);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // excelControl1
            // 
            this.excelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelControl1.Location = new System.Drawing.Point(740, 56);
            this.excelControl1.Name = "excelControl1";
            this.excelControl1.Size = new System.Drawing.Size(731, 490);
            this.excelControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.wmlPage);
            this.tabControl1.Controls.Add(this.potPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 490);
            this.tabControl1.TabIndex = 1;
            // 
            // wmlPage
            // 
            this.wmlPage.Controls.Add(this.wmlControl1);
            this.wmlPage.Location = new System.Drawing.Point(4, 25);
            this.wmlPage.Name = "wmlPage";
            this.wmlPage.Padding = new System.Windows.Forms.Padding(3);
            this.wmlPage.Size = new System.Drawing.Size(723, 461);
            this.wmlPage.TabIndex = 0;
            this.wmlPage.Text = "WML";
            this.wmlPage.UseVisualStyleBackColor = true;
            // 
            // wmlControl1
            // 
            this.wmlControl1.BackColor = System.Drawing.Color.Transparent;
            this.wmlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmlControl1.Location = new System.Drawing.Point(3, 3);
            this.wmlControl1.Name = "wmlControl1";
            this.wmlControl1.ReplacementText = null;
            this.wmlControl1.Size = new System.Drawing.Size(717, 455);
            this.wmlControl1.TabIndex = 0;
            // 
            // potPage
            // 
            this.potPage.Controls.Add(this.potControl1);
            this.potPage.Location = new System.Drawing.Point(4, 25);
            this.potPage.Name = "potPage";
            this.potPage.Padding = new System.Windows.Forms.Padding(3);
            this.potPage.Size = new System.Drawing.Size(723, 461);
            this.potPage.TabIndex = 1;
            this.potPage.Text = "Translation";
            this.potPage.UseVisualStyleBackColor = true;
            // 
            // potControl1
            // 
            this.potControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.potControl1.Location = new System.Drawing.Point(3, 3);
            this.potControl1.Name = "potControl1";
            this.potControl1.Size = new System.Drawing.Size(717, 455);
            this.potControl1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.approveSnippetBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.englishSnippetRadio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.polishSnippetRadio, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(180, 47);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // approveSnippetBtn
            // 
            this.approveSnippetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.approveSnippetBtn.Location = new System.Drawing.Point(3, 3);
            this.approveSnippetBtn.Name = "approveSnippetBtn";
            this.tableLayoutPanel2.SetRowSpan(this.approveSnippetBtn, 2);
            this.approveSnippetBtn.Size = new System.Drawing.Size(84, 41);
            this.approveSnippetBtn.TabIndex = 0;
            this.approveSnippetBtn.Text = "Approve";
            this.approveSnippetBtn.UseVisualStyleBackColor = true;
            this.approveSnippetBtn.Click += new System.EventHandler(this.approveSnippetBtn_Click);
            // 
            // englishSnippetRadio
            // 
            this.englishSnippetRadio.AutoSize = true;
            this.englishSnippetRadio.Checked = true;
            this.englishSnippetRadio.Location = new System.Drawing.Point(93, 3);
            this.englishSnippetRadio.Name = "englishSnippetRadio";
            this.englishSnippetRadio.Size = new System.Drawing.Size(59, 17);
            this.englishSnippetRadio.TabIndex = 1;
            this.englishSnippetRadio.TabStop = true;
            this.englishSnippetRadio.Text = "English";
            this.englishSnippetRadio.UseVisualStyleBackColor = true;
            this.englishSnippetRadio.CheckedChanged += new System.EventHandler(this.englishSnippetRadio_CheckedChanged);
            // 
            // polishSnippetRadio
            // 
            this.polishSnippetRadio.AutoSize = true;
            this.polishSnippetRadio.Location = new System.Drawing.Point(93, 26);
            this.polishSnippetRadio.Name = "polishSnippetRadio";
            this.polishSnippetRadio.Size = new System.Drawing.Size(53, 17);
            this.polishSnippetRadio.TabIndex = 2;
            this.polishSnippetRadio.Text = "Polish";
            this.polishSnippetRadio.UseVisualStyleBackColor = true;
            this.polishSnippetRadio.CheckedChanged += new System.EventHandler(this.polishSnippetRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1474, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "WesDialog";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.wmlPage.ResumeLayout(false);
            this.potPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.ExcelControl excelControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage wmlPage;
        private Controls.WMLControl wmlControl1;
        private System.Windows.Forms.TabPage potPage;
        private Controls.PotControl potControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button approveSnippetBtn;
        private System.Windows.Forms.RadioButton englishSnippetRadio;
        private System.Windows.Forms.RadioButton polishSnippetRadio;
    }
}

