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

using System;
using System.IO;
using PassportPDF.Tools.Framework.Configuration;

namespace pdfOCRCloud.Utilities
{
    internal static class CommandLineParsingUtilities
    {
        public static void ParseCommandLineArgs(string[] args, ApplicationConfiguration applicationConfiguration, OCRActionConfiguration ocrActionConfiguration)
        {
            int argsCount = args.Length;

            for (int i = 0; i < argsCount; i++)
            {
                switch (args[i].Trim().ToUpper())

                {
                    case "/SKIPPAGESWITHTEXT":
                        ocrActionConfiguration.SkipPagesWithText = true;
                        break;

                    case "/MIN": //start application with minimized window state
                        applicationConfiguration.MinimizedWindow = true;
                        break;

                    case "/P": //input folder is the next parameter
                        if (argsCount > i + 1)
                        {
                            applicationConfiguration.InputPath = args[i + 1].Trim();
                        }
                        break;

                    case "/F": //input files is the next parameter
                        if (argsCount > i + 1)
                        {
                            applicationConfiguration.InputPath = args[i + 1].Trim();
                        }
                        break;

                    case "/D": //destination folder is the next parameter
                        if (argsCount > i + 1)
                        {
                            string folder = args[i + 1].Trim();
                            if (Directory.Exists(folder))
                            {
                                applicationConfiguration.OutputPath = folder;
                            }
                        }
                        break;

                    case "/L": //language is the next parameter
                        if (argsCount > i + 1)
                        {
                            ocrActionConfiguration.OCRLanguage = args[i + 1].Trim();
                        }
                        break;

                    case "/T": //number of threads is the next parameter
                        if (argsCount > i + 1)
                        {
                            int threads;
                            if (int.TryParse(args[i + 1], out threads))
                            {
                                if (threads > 0 && threads <= Environment.ProcessorCount)
                                {
                                    applicationConfiguration.ThreadCount = threads;
                                }
                            }
                        }
                        break;

                    case "/NS": //don't process subfolders
                        applicationConfiguration.ProcessSubFolders = false;
                        break;


                    case "/LOGS": //log file is the next parameter
                        if (argsCount > i + 1)
                        {
                            applicationConfiguration.LogsPath = args[i + 1].Trim();
                            applicationConfiguration.ExportLogs = true;
                        }
                        break;
                }
            }
        }
    }
}
