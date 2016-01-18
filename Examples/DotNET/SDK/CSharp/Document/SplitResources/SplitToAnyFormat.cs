using System;
using Aspose.Cloud;

namespace CSharp.Document.SplitResources
{
    class SplitToAnyFormat
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Split specific pages to any Supported Format
            WordsSplitResultResponse wordsSplitResultResponse = Common.WordsService.SplitDocument(inputfile, SplitDocumentFormat.Png, 1, 2, Common.FOLDER);

            Console.WriteLine("\nInput file splitted successfully to Png Format.");
        }
    }
}
