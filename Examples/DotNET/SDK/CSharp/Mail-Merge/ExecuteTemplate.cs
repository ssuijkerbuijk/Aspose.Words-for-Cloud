using System;
using Aspose.Cloud;

namespace CSharp.Mail_Merge
{
    class ExecuteTemplate
    {
        public static void Run()
        {
            string subdirectory = "MailMerge";
            string inputfile = "Invoice Template.doc";
            string xmlfile = "Orders.xml";
            string imagefile = "Aspose Logo.png";

            // The path to the documents directory.
            string dataDir = Common.GetDataDir();
            dataDir = dataDir + subdirectory + "\\";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            // Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, subdirectory);

            // Execute Mail Merge Template
            string strXML = string.Empty;
            using (System.IO.StreamReader sr = new System.IO.StreamReader(dataDir + xmlfile))
            {
                strXML = sr.ReadToEnd();
            }
            Common.WordsService.PopulateDocumentTemplateWithData(inputfile, WordCleanupOptions.ContainingFields, Common.GetOutputFilePath(inputfile,true), Common.FOLDER, strXML);

            // Download output file from cloud storage and save on local directory
            dataDir = Common.DownloadFile(inputfile, subdirectory);

            Console.WriteLine("\nMail merge template executed successfully.\nFile saved at " + dataDir);
        }
    }
}
