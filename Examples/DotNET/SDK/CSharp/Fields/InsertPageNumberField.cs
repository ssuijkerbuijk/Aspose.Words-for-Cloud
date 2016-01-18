using System;
using Aspose.Cloud;

namespace CSharp.Fields
{
    class InsertPageNumberField
    {
        public static void Run()
        {            
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);
                       
            // Insert Page Number Field into the Document
            PageNumberSettings pageNumberSettings = new PageNumberSettings("{PAGE} of {NUMPAGES}", "right", true, true);
            Common.WordsService.InsertDocumentPageNumbers(inputfile, Common.GetOutputFilePath(inputfile, true), Common.FOLDER, pageNumberSettings);

            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nPage number inserted successfully.\nFile saved at " + dataDir);
        }
    }
}
