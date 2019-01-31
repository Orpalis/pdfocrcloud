namespace pdfOCRCloud.Views
{
    partial class frmOptions : PassportPDF.Tools.WinForm.Views.frmOptionsBase
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
            this.tabOCR = new System.Windows.Forms.TabPage();
            this.lbOcrLanguage = new System.Windows.Forms.Label();
            this.cboOcrLanguage = new System.Windows.Forms.ComboBox();
            this.chkSkipPagesWithText = new System.Windows.Forms.CheckBox();
            this.panelOCR = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabOCR.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOCR);
            this.tabControl1.Controls.SetChildIndex(this.tabOCR, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabGeneral, 0);
            // 
            // tabOCR
            // 
            this.tabOCR.Controls.Add(this.lbOcrLanguage);
            this.tabOCR.Controls.Add(this.cboOcrLanguage);
            this.tabOCR.Controls.Add(this.chkSkipPagesWithText);
            this.tabOCR.Controls.Add(this.panelOCR);
            this.tabOCR.Location = new System.Drawing.Point(4, 22);
            this.tabOCR.Name = "tabOCR";
            this.tabOCR.Padding = new System.Windows.Forms.Padding(3);
            this.tabOCR.Size = new System.Drawing.Size(485, 217);
            this.tabOCR.TabIndex = 2;
            this.tabOCR.Text = "OCR";
            this.tabOCR.UseVisualStyleBackColor = true;
            // 
            // lbOcrLanguage
            // 
            this.lbOcrLanguage.AutoSize = true;
            this.lbOcrLanguage.Location = new System.Drawing.Point(15, 15);
            this.lbOcrLanguage.Name = "lbOcrLanguage";
            this.lbOcrLanguage.Size = new System.Drawing.Size(84, 13);
            this.lbOcrLanguage.TabIndex = 13;
            this.lbOcrLanguage.Text = "OCR Language:";
            // 
            // cboOcrLanguage
            // 
            this.cboOcrLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcrLanguage.FormattingEnabled = true;
            this.cboOcrLanguage.Location = new System.Drawing.Point(102, 9);
            this.cboOcrLanguage.Name = "cboOcrLanguage";
            this.cboOcrLanguage.Size = new System.Drawing.Size(112, 21);
            this.cboOcrLanguage.TabIndex = 12;
            // 
            // chkSkipPagesWithText
            // 
            this.chkSkipPagesWithText.AutoSize = true;
            this.chkSkipPagesWithText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkSkipPagesWithText.Location = new System.Drawing.Point(15, 41);
            this.chkSkipPagesWithText.Margin = new System.Windows.Forms.Padding(2);
            this.chkSkipPagesWithText.Name = "chkSkipPagesWithText";
            this.chkSkipPagesWithText.Size = new System.Drawing.Size(134, 17);
            this.chkSkipPagesWithText.TabIndex = 10;
            this.chkSkipPagesWithText.Text = "Skip pages having text";
            this.chkSkipPagesWithText.UseVisualStyleBackColor = true;
            // 
            // panelOCR
            // 
            this.panelOCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOCR.Location = new System.Drawing.Point(3, 3);
            this.panelOCR.Name = "panelOCR";
            this.panelOCR.Size = new System.Drawing.Size(479, 211);
            this.panelOCR.TabIndex = 14;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(497, 344);
            this.Name = "frmOptions";
            this.Text = "PassportPDF PDF OCR Cloud - Options";
            this.tabControl1.ResumeLayout(false);
            this.tabOCR.ResumeLayout(false);
            this.tabOCR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabOCR;
        private System.Windows.Forms.CheckBox chkSkipPagesWithText;
        private System.Windows.Forms.ComboBox cboOcrLanguage;
        private System.Windows.Forms.Label lbOcrLanguage;
        private System.Windows.Forms.Panel panelOCR;
    }
}