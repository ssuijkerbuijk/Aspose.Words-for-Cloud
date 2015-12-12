//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

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
