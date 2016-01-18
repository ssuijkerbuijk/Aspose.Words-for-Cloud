using System;
using Aspose.Cloud;

namespace CSharp.Document
{
    class RejectTrackingChanges
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Reject All Tracking Changes in the Document
            WordRevisionResponse wordRevisionResponse2 = Common.WordsService.WordsRevisions.RejectAllRevisionsInDocument(inputfile, Common.GetOutputFilePath(inputfile, true), Common.FOLDER);

            Console.WriteLine("\nAll tracking changes rejected in " + inputfile);
        }
    }
}
