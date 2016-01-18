using System;
using Aspose.Cloud;

namespace CSharp.Paragraph
{
    class GetSpecificRunOfParagraph
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "Paragraph";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Get a specific Run of a Paragraph from a Word Document
            WordsRunResponse wordsRunResponse = Common.WordsService.WordsParagraph.GetParagraphByIndexAndRun(inputfile, 0, 0, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsRunResponse.Run.Text + " run text.");
        }
    }
}
