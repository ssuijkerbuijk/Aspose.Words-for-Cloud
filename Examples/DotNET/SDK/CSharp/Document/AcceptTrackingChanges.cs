using System;
using Aspose.Cloud;

namespace CSharp.Document
{
    class AcceptTrackingChanges
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);
            
            // Accept All Tracking Changes in the Document
            WordRevisionResponse wordRevisionResponse = Common.WordsService.WordsRevisions.AcceptAllRevisionsInDocument(inputfile, Common.GetOutputFilePath(inputfile,true), Common.FOLDER);

            Console.WriteLine("\nAll tracking changes accepted in " + inputfile);
        }
    }
}
