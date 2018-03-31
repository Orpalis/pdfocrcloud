using System;
using Orpalis.Globals.Localization;
using PassportPDF.Tools.Framework.Configuration;
using pdfOCRCloud.Utilities;

namespace pdfOCRCloud
{
    internal static class PdfOCRGlobals
    {
        public const string PRODUCT_NAME = "PassportPDF PDF OCR Cloud";
        public const string APP_EXECUTABLE_NAME = "pdfOCRCloud.exe";
        public const string PASSPORT_PDF_APP_ID = "BA72793B-8097-4F5C-BCF9-F6A3D88A54CA";

        public static string[] AvailableOCRLanguages;
        public static bool AutoRun = false;
        public static OCRActionConfiguration OCRActionConfiguration = new OCRActionConfiguration();

        public static readonly OrpalisLocalizer LabelsLocalizer = new OrpalisLocalizer(AssemblyUtilities.GetManifestResourceStream("res.labels.json"));


        public static string GetLegalProductName(bool includeVersion)
        {
            string productName = PRODUCT_NAME;
            if (includeVersion)
            {
                productName += " " + AssemblyUtilities.GetVersionString();
            }

            return productName;
        }


        public static string GetApplicationConfigurationFilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\settings.data";
        }


        public static string GetOCRActionConfigurationFilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\OCRActionConfiguration.data";
        }
    }
}