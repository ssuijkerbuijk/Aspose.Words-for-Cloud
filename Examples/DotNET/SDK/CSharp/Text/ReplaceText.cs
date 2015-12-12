//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Text
{
    class ReplaceText
    {
        public static void Run()
        {           
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Replace Text in a Word Document
            WordsReplaceText replaceText = new WordsReplaceText("Aspose", "Aspose Pty Ltd", true, false);
           Common.WordsService.WordsTextItems.ReplaceDocumentText(inputfile, Common.GetOutputFilePath(inputfile, true), replaceText, Common.FOLDER);

           Console.WriteLine("\nText replaced successfully");
        }
    }
}
