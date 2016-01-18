using System;
using Aspose.Cloud;

namespace CSharp.Watermark
{
    class RemoveWatermark
    {
        public static void Run()
        {
            string inputfile = "doc-sample-watermark.doc"; 

            string outfile = Common.GetOutputFilePath(inputfile, true);
            
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Remove Watermark from a Word Document
            Common.WordsService.WordsDocumentWatermark.DeleteWatermark(inputfile, outfile, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nWatermark text added successfully.\nFile saved at " + dataDir);
        }
    }
}
