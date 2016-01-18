using System;
using Aspose.Cloud;

namespace CSharp.Document
{
    class WordAndParagraphCount
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get Word and Paragraph Count from Document
            WordsStatDataResponse WordsStatDataResponse = Common.WordsService.WordsDocumentStatistics.ReadDocumentStatistics(inputfile, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have page count " + WordsStatDataResponse.StatData.PageCount + ", paragraph count " + WordsStatDataResponse.StatData.ParagraphCount + " and words count " + WordsStatDataResponse.StatData.WordCount);
        }
    }
}
