using System;
using Aspose.Cloud;

namespace CSharp.Mail_Merge
{
    class ExecuteWithRegions
    {
        public static void Run()
        {
            string subdirectory = "MailMerge";
            string inputfile = "WithRegions.doc";
            string xmlfile = "WithRegions.xml";
            string imagefile = "Aspose Logo.png";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            // Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, subdirectory);

            // Upload xml file from local directory to Cloud Storage
            Common.UploadFile(xmlfile, subdirectory);

            // Execute Mail Merge with Regions
            WordsDocumentResponse wordsDocumentResponse = Common.WordsService.WordsMailMerge.ExecuteDocumentMailMergeOperation(inputfile, true, xmlfile, string.Empty, Common.GetOutputFilePath(inputfile, true), Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirectory);

            Console.WriteLine("\nMail merge with regions executed successfully.\nFile saved at " + dataDir);
        }
    }
}
