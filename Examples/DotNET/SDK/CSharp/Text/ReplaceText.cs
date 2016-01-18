using System;
using Aspose.Cloud;

namespace CSharp.Text
{
    class ReplaceText
    {
        public static void Run()
        {           
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Replace Text in a Word Document
            WordsReplaceText replaceText = new WordsReplaceText("Aspose", "Aspose Pty Ltd", true, false);
           Common.WordsService.WordsTextItems.ReplaceDocumentText(inputfile, Common.GetOutputFilePath(inputfile, true), replaceText, Common.FOLDER);

           Console.WriteLine("\nText replaced successfully");
        }
    }
}
