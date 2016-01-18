using System;
using Aspose.Cloud;

namespace CSharp.Paragraph
{
    class GetParagraphs
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "Paragraph";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Get a List of Paragraphs from a Word Document
            WordsParagraphsResponse wordsParagraphsResponse = Common.WordsService.WordsParagraph.GetParagraphs(inputfile, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsParagraphsResponse.Paragraphs.ParagraphLinkList.Count + " paragraphs.");
        }
    }
}
