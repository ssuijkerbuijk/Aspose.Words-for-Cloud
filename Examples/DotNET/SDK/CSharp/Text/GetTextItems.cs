using System;
using Aspose.Cloud;

namespace CSharp.Text
{
    class GetTextItems
    {
        public static void Run()
        {            
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get Text Items from a Word Document
            WordsTextItemsResponse wordsTextItemsResponse = Common.WordsService.WordsTextItems.ReadDocumentTextItems(inputfile, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsTextItemsResponse.TextItems.List.Count.ToString() + " text items");            
        }
    }
}
