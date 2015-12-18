using System;
using System.IO;
using Aspose.Cloud;

namespace CSharp
{
    class Common
    {
        public static string APP_SID = "33b5bad5-beb7-4cb9-88fc-dce6b6aff909";
        public static string APP_KEY = "b3f2961c598bc3c888de602786c17272";
        public static string FOLDER = "";
        public static string STORAGE = "";

        public static string GetDataDir()
        {
            var parent = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string startDirectory = null;
            if (parent != null)
            {
                var directoryInfo = parent.Parent;
                if (directoryInfo != null)
                {
                    startDirectory = directoryInfo.FullName;
                }
            }
            else
            {
                startDirectory = parent.FullName;
            }
            return Path.Combine(startDirectory, "Data\\");
        }
        public static void UploadFile(string fileName, string subdirectory)
        {
            // The path to the documents directory.
            string dataDir = Common.GetDataDir();

            if (subdirectory != string.Empty)
            {
                dataDir = dataDir + subdirectory + "\\";
            }
            StorageService.File.UploadFile(dataDir + fileName, fileName, storage: Common.STORAGE);
        }
        public static string DownloadFile(string fileName, string subdirectory)
        {
            // The path to the documents directory.
            string dataDir = Common.GetDataDir();
            
            if (subdirectory != string.Empty)
            {
                dataDir = dataDir + subdirectory + "\\";
            }

            // Download output file from cloud storage and save on local directory
            dataDir = dataDir + GetOutputFilePath(fileName, true);
            StorageService.File.DownloadFile(GetOutputFilePath(fileName, true), dataDir, 0, storage: Common.STORAGE);

            return dataDir;
        }
        public static string GetOutputFilePath(String inputFilePath, bool withExtension)
        {
            string extension = Path.GetExtension(inputFilePath);
            string filename = Path.GetFileNameWithoutExtension(inputFilePath);
            if (withExtension)
            {
                return filename + "_out_" + extension;
            }
            else
            {
                return filename + "_out_";
            }
        }
        public static WordsService WordsService
        {
            get
            {
                CheckCredentials();
                WordsService w = new WordsService(APP_SID, APP_KEY);
                return w;
            }
        }

        public static StorageService StorageService
        {
            get
            {
                CheckCredentials();
                StorageService s = new StorageService(APP_SID, APP_KEY);
                return s;
            }
        }

        private static void CheckCredentials()
        {
            if (String.IsNullOrEmpty(APP_SID) || String.IsNullOrEmpty(APP_KEY))
            {
                Console.WriteLine("APP_SID and APP_KEY must have valid values. Check " + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + " for details.");                
                Environment.Exit(1);
            }
        }       
    }
}
