using Syncfusion.Licensing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace StudySyncfusion
{
    public static class AssemblyResolver
    {
        static AssemblyResolver()
        {

        }
        public static class LicenseKeyLocator
        {
            public static void FindandRegisterLicenseKey()
            {
                SyncfusionLicenseProvider.RegisterLicense(FindLicenseKey());
            }

            /// <summary>
            /// Helper method to find a syncfusion license key.
            /// </summary>
            /// <returns>License Key</returns>
            private static string FindLicenseKey()
            {
                int levelsToCheck = 12;
                string filePath = @"SyncfusionLicense.txt";

                string rootPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location.Replace(@"file:///", ""));

                if (string.IsNullOrEmpty(rootPath) || string.IsNullOrEmpty(filePath))
                {
                    return string.Empty;
                }

                for (int n = 0; n < levelsToCheck; n++)
                {
                    string fileDataPath = System.IO.Path.Combine(rootPath, filePath);
                    if (System.IO.File.Exists(fileDataPath))
                        return File.ReadAllText(fileDataPath, Encoding.UTF8);
                    DirectoryInfo rootDirectory = Directory.GetParent(rootPath);
                    if (rootDirectory == null)
                        break;
                    rootPath = rootDirectory.FullName;
                }
                return string.Empty;
            }
        }

    }
}
