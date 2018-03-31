using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace pdfOCRCloud.Utilities
{
    internal static class AssemblyUtilities
    {
        private const string ASSEMBLY_ROOT = "pdfOCRCloud";

        public static Stream GetManifestResourceStream(string resourceName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(ASSEMBLY_ROOT + "." + resourceName);
        }


        public static Version GetVersion()
        {
            return new Version(GetVersionString());
        }


        public static string GetVersionString()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return GetMajorVersion() + "." + fileVersionInfo.FileMinorPart.ToString() + "." + fileVersionInfo.FilePrivatePart.ToString();
        }


        public static string GetMajorVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileMajorPart.ToString();
        }
    }
}
