using System;
using Aspose.Cloud;

namespace CSharp.Hyperlink
{
    class GetParticularHyperlink
    {
        public static void Run()
        {
            string inputfile = "doc-sample-hyperlink.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get a Particular Hyperlink from a Word
            WordsHyperlinkResponse wordsHyperlinkResponse = Common.WordsService.WordsHyperlinks.ReadDocumentHyperlinkByItsIndex(inputfile, 0, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsHyperlinkResponse.Hyperlink.DisplayText + " hyperlink");
        }
    }
}
