using System;
using Aspose.Cloud;

namespace CSharp.Protection
{
    class ProtectDocument
    {
        public static void Run()
        {
            string inputfile = "doc-sample-protect.doc";
            string subdirection = "Protection";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Protect a Word Document
            WordsProtectionRequest wordsProtectionRequest = new WordsProtectionRequest("aspose", "aspose", ProtectionType.ReadOnly);
            Common.WordsService.WordsDocumentProtection.ProtectDocument(inputfile, Common.GetOutputFilePath(inputfile, true), wordsProtectionRequest, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirection);

            Console.WriteLine("\nRead only protection added.\nFile saved at " + dataDir);
        }
    }
}
