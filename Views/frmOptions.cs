using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.Framework;

namespace pdfOCRCloud.Views
{
    public partial class frmOptions : PassportPDF.Tools.WinForm.Views.frmOptionsBase
    {
        public frmOptions() : base(Properties.Resources.banner_pdfocrcloud)
        {
            InitializeComponent();
            PopulateAvailableLanguagesAndSelectLanguage();
        }


        public override void LoadLabels()
        {
            base.LoadLabels();

            chkSkipPagesWithText.Text = PdfOCRGlobals.LabelsLocalizer.GetString("label_chkSkipPagesWithText", FrameworkGlobals.ApplicationLanguage);
            lbOcrLanguage.Text = PdfOCRGlobals.LabelsLocalizer.GetString("label_lbOcrLanguage", FrameworkGlobals.ApplicationLanguage);
        }


        public override void LoadConfiguration()
        {
            base.LoadConfiguration();

            SetSelectedOCRLanguage();
            chkSkipPagesWithText.Checked = PdfOCRGlobals.OCRActionConfiguration.SkipPagesWithText;
        }


        private void SetSelectedOCRLanguage()
        {
            for (int index = 0; index < PdfOCRGlobals.AvailableOCRLanguages.Length; index++)
            {
                if ((string)cboOcrLanguage.Items[index] == PdfOCRGlobals.OCRActionConfiguration.OCRLanguage)
                {
                    cboOcrLanguage.SelectedIndex = index;
                }
            }
        }


        private void PopulateAvailableLanguagesAndSelectLanguage()
        {
            for (int index = 0; index < PdfOCRGlobals.AvailableOCRLanguages.Length; index++)
            {
                string language = PdfOCRGlobals.AvailableOCRLanguages[index];

                cboOcrLanguage.Items.Add(language);

                if (language == PdfOCRGlobals.OCRActionConfiguration.OCRLanguage)
                {
                    cboOcrLanguage.SelectedIndex = index;
                }
            }
        }


        protected override void ApplyConfigurationChanges()
        {
            base.ApplyConfigurationChanges();
            PdfOCRGlobals.OCRActionConfiguration.OCRLanguage = PdfOCRGlobals.AvailableOCRLanguages[cboOcrLanguage.SelectedIndex];
            PdfOCRGlobals.OCRActionConfiguration.SkipPagesWithText = chkSkipPagesWithText.Checked;

            Dispose();
        }


        protected override void ResetDefaultConfiguration()
        {
            base.ResetDefaultConfiguration();

            PdfOCRGlobals.OCRActionConfiguration = ConfigurationManager.ResetDefaultOCRActionConfiguration();
            chkSkipPagesWithText.Checked = PdfOCRGlobals.OCRActionConfiguration.SkipPagesWithText;
            SetSelectedOCRLanguage();
            LoadConfiguration();
        }
    }
}
