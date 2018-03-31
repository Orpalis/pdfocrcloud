using System;
using System.Reflection;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Views;
using pdfOCRCloud.Utilities;

namespace pdfOCRCloud.Views
{
    public partial class frmMain : frmMainBase, IPdfOcrMainView
    {
        public frmMain() : base()
        {
            InitializeComponent();
        }


        protected override void LoadLabels()
        {
            base.LoadLabels();
        }
    }
}
