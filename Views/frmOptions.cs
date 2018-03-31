/**********************************************************************
 * Project:                  pdfOCR.Cloud
 * Authors:                 - Evan Carrère.
 *                          - Loïc Carrère.
 *
 * (C) Copyright 2018, ORPALIS.
 ** Licensed under the Apache License, Version 2.0 (the "License");
 ** you may not use this file except in compliance with the License.
 ** You may obtain a copy of the License at
 ** http://www.apache.org/licenses/LICENSE-2.0
 ** Unless required by applicable law or agreed to in writing, software
 ** distributed under the License is distributed on an "AS IS" BASIS,
 ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 ** See the License for the specific language governing permissions and
 ** limitations under the License.
 *
 **********************************************************************/

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
