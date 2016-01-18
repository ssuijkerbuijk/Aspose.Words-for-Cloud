using System;
using Aspose.Cloud;

namespace CSharp.Drawing
{
    class GetAllObjects
    {
        public static void Run()
        {
            string subdirectory = "Drawing";

            // The path to the documents directory.
            string dataDir = Common.GetDataDir() + subdirectory + "\\";

            string inputfile = "testfile.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            // Get All Drawing Objects
            WordsDrawingObjectsResponse wordsDrawingObjectsResponse = Common.WordsService.WordsDrawingObjects.ReadDocumentDrawingObjectsCommonInfo(inputfile, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsDrawingObjectsResponse.DrawingObjects.List.Count + " drawing objects.");
        }
    }
}
