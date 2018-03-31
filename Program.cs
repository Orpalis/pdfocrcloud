using System;
using System.Windows.Forms;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Views;
using pdfOCRCloud.Views;
using pdfOCRCloud.Controller;

namespace pdfOCRCloud
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool autoRun;

            if (args.Length > 0)
            {
                autoRun = true;
            }
            else
            {
                autoRun = false;
            }

            IPassportPDFAppController controller = new PDFOCRController(autoRun, args);
            frmMain mainView = new frmMain();
            ((IPassportPDFAppMainView)mainView).SetController(controller);
            controller.SetView(mainView);

            Application.EnableVisualStyles();
            Application.Run(mainView);
        }
    }
}
