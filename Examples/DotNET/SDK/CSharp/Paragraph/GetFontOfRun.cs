using System;
using Aspose.Cloud;

namespace CSharp.Paragraph
{
    class GetFontOfRun
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "Paragraph";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Get Font Information of a Run from a Word Document
            WordsFontResponse WordsFontResponse = Common.WordsService.WordsParagraph.GetDocumentFontByParagraphAndRun(inputfile, 0, 0, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + WordsFontResponse.Font.Name + " font.");
        }
    }
}
