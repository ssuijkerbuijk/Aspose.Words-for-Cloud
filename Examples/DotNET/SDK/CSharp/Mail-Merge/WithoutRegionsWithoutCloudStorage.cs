using System;
using Aspose.Cloud;

namespace CSharp.Mail_Merge
{
    class WithoutRegionsWithoutCloudStorage
    {
        public static void Run()
        {
            string subdirectory = "MailMerge";
            string inputfile = "WithoutRegionsWithoutStorage.doc";
            string xmlfile = "WithoutRegionsWithoutStorage.xml";
            
            // The path to the documents directory.
            string dataDir = Common.GetDataDir() + subdirectory + "\\";
           
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            string strXML = string.Empty;
            using (System.IO.StreamReader sr = new System.IO.StreamReader(dataDir + xmlfile))
            {
                strXML = sr.ReadToEnd();
            }

            Common.WordsService.ExecuteDocumentMailMergeOnline(strXML, false, string.Empty, inputfile, Common.GetOutputFilePath(inputfile, true), Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            dataDir = Common.DownloadFile(inputfile, subdirectory);

            Console.WriteLine("\nMail merge without regions and without cloud storage executed successfully.\nFile saved at " + dataDir);
        }
    }
}
