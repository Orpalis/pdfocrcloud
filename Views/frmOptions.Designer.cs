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
            this.chkSkipPagesWithText = new System.Windows.Forms.CheckBox();
            this.cboOcrLanguage = new System.Windows.Forms.ComboBox();
            this.lbOcrLanguage = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabOCR.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOCR);
            // 
            // tabOCR
            // 
            this.tabOCR.Controls.Add(this.lbOcrLanguage);
            this.tabOCR.Controls.Add(this.cboOcrLanguage);
            this.tabOCR.Controls.Add(this.chkSkipPagesWithText);
            this.tabOCR.Location = new System.Drawing.Point(4, 22);
            this.tabOCR.Name = "tabOCR";
            this.tabOCR.Size = new System.Drawing.Size(471, 202);
            this.tabOCR.TabIndex = 2;
            this.tabOCR.Text = "OCR";
            this.tabOCR.UseVisualStyleBackColor = true;
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
            // cboOcrLanguage
            //
            this.cboOcrLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcrLanguage.FormattingEnabled = true;
            this.cboOcrLanguage.Location = new System.Drawing.Point(105, 12);
            this.cboOcrLanguage.Name = "cboOcrLanguage";
            this.cboOcrLanguage.Size = new System.Drawing.Size(112, 21);
            this.cboOcrLanguage.TabIndex = 12;
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
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ORPALIS PDF OCR - Options";
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabOCR.ResumeLayout(false);
            this.tabOCR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabOCR;
        private System.Windows.Forms.CheckBox chkSkipPagesWithText;
        private System.Windows.Forms.ComboBox cboOcrLanguage;
        private System.Windows.Forms.Label lbOcrLanguage;
    }
}