using System;
using Aspose.Cloud;

namespace CSharp.Hyperlink
{
    class GetAllHyperlinks
    {
        public static void Run()
        {
            string inputfile = "doc-sample-hyperlink.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get all Hyperlinks from a Word
            WordsHyperlinksResponse wordsHyperlinksResponse = Common.WordsService.WordsHyperlinks.ReadDocumentHyperlinksCommonInfo(inputfile, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsHyperlinksResponse.Hyperlinks.HyperlinkList.Count + " hyperlinks");
        }
    }
}
