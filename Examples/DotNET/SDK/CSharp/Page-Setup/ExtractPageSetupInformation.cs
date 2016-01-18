using System;
using Aspose.Cloud;

namespace CSharp.Page_Setup
{
    class ExtractPageSetupInformation
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "PageSetup";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Extract Page Setup Information from a Word Document
            PageSetupResponse pageSetupResponse = Common.WordsService.WordsSections.GetPageSetupOfSection(inputfile, 0, Common.FOLDER);

            Console.WriteLine("\nPage setup informations from " + inputfile + " file extracted successfully.");
        }
    }
}
