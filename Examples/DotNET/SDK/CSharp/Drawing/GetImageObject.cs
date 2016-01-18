using System;
using Aspose.Cloud;

namespace CSharp.Drawing
{
    class GetImageObject
    {
        public static void Run()
        {
            string subdirectory = "Drawing";

            // The path to the documents directory.
            string dataDir = Common.GetDataDir() + subdirectory + "\\";

            string inputfile = "imagefile.doc";
            string outputfile = "imagefile_out_.png";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            dataDir = dataDir + outputfile;

            // Get the Image Drawing Object from Document
            Common.WordsService.WordsDrawingObjects.ReadDrawingObjectImageData(inputfile, 1, string.Empty, dataDir);

            Console.WriteLine("\nImage object fetched successfully.\nFile saved at " + dataDir);
        }
    }
}
