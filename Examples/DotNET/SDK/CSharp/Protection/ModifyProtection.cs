using System;
using Aspose.Cloud;

namespace CSharp.Protection
{
    class ModifyProtection
    {
        public static void Run()
        {
            string inputfile = "doc-sample-unprotect.doc";
            string subdirection = "Protection";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Modify Protection of the Word Document
            WordsProtectionRequest wordsProtectionRequest2 = new WordsProtectionRequest("aspose", "aspose2", ProtectionType.ReadOnly);
            Common.WordsService.WordsDocumentProtection.ChangeDocumentProtection(inputfile, Common.GetOutputFilePath(inputfile, true), wordsProtectionRequest2, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirection);

            Console.WriteLine("\nDocument protection updated successfully.\nFile saved at " + dataDir);
        }
    }
}
