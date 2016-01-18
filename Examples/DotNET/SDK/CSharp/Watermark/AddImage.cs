using System;
using Aspose.Cloud;

namespace CSharp.Watermark
{
    class AddImage
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";            
            string imagefile = "Aspose Logo.png";

            string outfile = Common.GetOutputFilePath(inputfile, true);
            
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, string.Empty);

            // Add Watermark Image to a Word Document
            Common.WordsService.WordsDocumentWatermark.InsertDocumentWatermarkImage(inputfile, outfile, 45.0, imagefile, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nWatermark image added successfully.\nFile saved at " + dataDir);
        }
    }
}
