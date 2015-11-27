//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

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
