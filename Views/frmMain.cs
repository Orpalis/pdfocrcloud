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

using PassportPDF.Tools.WinForm.Views;

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
