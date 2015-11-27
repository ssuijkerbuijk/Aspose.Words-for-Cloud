//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

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
