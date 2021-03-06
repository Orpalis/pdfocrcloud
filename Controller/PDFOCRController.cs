﻿/**********************************************************************
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

using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Models;
using PassportPDF.Tools.Framework.Utilities;
using PassportPDF.Tools.Framework.Business;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Views;
using PassportPDF.Tools.WinForm.Models;
using PassportPDF.Tools.WinForm.Utilities;
using pdfOCRCloud.Utilities;
using pdfOCRCloud.Views;

namespace pdfOCRCloud.Controller
{
    internal sealed class PDFOCRController : PassportPDFAppControllerBase
    {
        public PDFOCRController(bool autoRun, string[] args) : base(
            new PassportPDFDesktopAppInformation(
                PdfOCRGlobals.PRODUCT_NAME, PdfOCRGlobals.PASSPORT_PDF_APP_ID, PdfOCRGlobals.SOURCE_CODE_LINK,
                AssemblyUtilities.GetVersion(), Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                Properties.Resources.logo_pdfocrcloud, PdfOCRGlobals.INPUT_FILE_TYPE, PdfOCRGlobals.GetApplicationConfigurationFilePath(), autoRun, args))
        {
        }


        protected override bool InitializeAppConfiguration()
        {
            if (!base.InitializeAppConfiguration())
            {
                return false;
            }

            if (!frmFetchingInfoFromServer.TryFetchAvailableOCRLanguagesFromPassportPDF(out PdfOCRGlobals.AvailableOCRLanguages, _view.WindowInstance))
            {
                return false;
            }

            if (!_appInfo.AutoRun)
            {
                try
                {
                    PdfOCRGlobals.OCRActionConfiguration = (PDFOCRActionConfiguration)ConfigurationManager.InitializeConfigurationInstanceEx(PdfOCRGlobals.GetOCRActionConfigurationFilePath(), typeof(PDFOCRActionConfiguration));
                }
                catch (Exception)
                {
                    MessageBox.Show(FrameworkGlobals.MessagesLocalizer.GetString("readOCRConfigurationFailure", FrameworkGlobals.ApplicationConfiguration.Language), FrameworkGlobals.MessagesLocalizer.GetString("readConfigurationFailureTitle", FrameworkGlobals.ApplicationConfiguration.Language), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PdfOCRGlobals.OCRActionConfiguration = ConfigurationManager.ResetDefaultPDFOCRActionConfiguration();
                }
            }
            else
            {
                PdfOCRGlobals.OCRActionConfiguration = ConfigurationManager.ResetDefaultPDFOCRActionConfiguration();
                CommandLineParsingUtilities.ParseCommandLineArgs(_appInfo.CommandLineArguments, FrameworkGlobals.ApplicationConfiguration, ocrActionConfiguration: PdfOCRGlobals.OCRActionConfiguration);

                if (FrameworkGlobals.ApplicationConfiguration.MinimizedWindow)
                {
                    _view.Minimize();
                }
            }

            return true;
        }


        protected override OperationsWorkflow GetOperationWorkflow()
        {
            return OperationsWorkflowUtilities.CreatePDFOCRWorkflow(PdfOCRGlobals.OCRActionConfiguration);
        }


        protected override void OnOptionsFormOpeningRequested()
        {
            using (frmOptions frmOptions = new frmOptions())
            {
                frmOptions.LoadLabels();
                frmOptions.LoadConfiguration();
                frmOptions.ShowDialog(_view.WindowInstance);
            }
        }


        protected override void OnFileOperationsCompletion(FileOperationsResult fileOperationsResult)
        {
            base.OnFileOperationsCompletion(fileOperationsResult);

            string operationsCompletionMessage = LogMessagesUtils.TimeStampLogMessage(LogMessagesUtils.GetGenericFileOperationsCompletionText(fileOperationsResult));
            _view.NotifyOperationCompletion(operationsCompletionMessage);

            if (FrameworkGlobals.ApplicationConfiguration.ExportLogs && !string.IsNullOrEmpty(FrameworkGlobals.ApplicationConfiguration.LogsPath))
            {
                FrameworkGlobals.LogsManager.LogMessage(operationsCompletionMessage);
            }
        }


        protected override void OnOperationsCompletion()
        {
            base.OnOperationsCompletion();

            string workCompletionMessage = LogMessagesUtils.GetGenericWorkCompletionMessage(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount,
                    _operationsStats.UnsuccessfullyProcessedFileCount, ParsingUtils.GetElapsedTimeString(_stopwatch.Elapsed.Hours, _stopwatch.Elapsed.Minutes, _stopwatch.Elapsed.Seconds, _stopwatch.Elapsed.Milliseconds / 10));

            _view.NotifyOperationsResult(workCompletionMessage);

            if (!_appInfo.AutoRun)
            {
                _view.ShowInformationMessage(workCompletionMessage, FrameworkGlobals.MessagesLocalizer.GetString("processTerminated", FrameworkGlobals.ApplicationConfiguration.Language));
                _view.UnlockView();
            }
            else
            {
                Console.Write(workCompletionMessage);
                _view.ExitApplication();
            }
        }


        protected override void HandleApplicationClosing()
        {
            base.HandleApplicationClosing();

            if (!_appInfo.AutoRun &&
                (!ConfigurationManager.SaveConfiguration(PdfOCRGlobals.GetApplicationConfigurationFilePath(), FrameworkGlobals.ApplicationConfiguration) ||
                !ConfigurationManager.SaveConfiguration(PdfOCRGlobals.GetOCRActionConfigurationFilePath(), PdfOCRGlobals.OCRActionConfiguration)))
            {
                MessageBox.Show(FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailure", FrameworkGlobals.ApplicationConfiguration.Language), FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailureTitle", FrameworkGlobals.ApplicationConfiguration.Language), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
