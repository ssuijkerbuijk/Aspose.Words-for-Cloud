using System;
using Aspose.Cloud;

namespace CSharp.Mail_Merge
{
    class ExecuteWithoutRegions
    {
        public static void Run()
        {           
            string subdirectory = "MailMerge";
            string inputfile = "WithoutRegions.doc";
            string xmlfile = "WithoutRegions.xml";
            string imagefile = "Aspose Logo.png";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            // Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, subdirectory);

            // Upload xml file from local directory to Cloud Storage
            Common.UploadFile(xmlfile, subdirectory);

            // Execute Mail Merge without Regions
            WordsDocumentResponse wordsDocumentResponse = Common.WordsService.WordsMailMerge.ExecuteDocumentMailMergeOperation(inputfile, false, xmlfile, string.Empty, Common.GetOutputFilePath(inputfile, true), Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirectory);

            Console.WriteLine("\nMail merge without regions executed successfully.\nFile saved at " + dataDir);
        }
    }
}
