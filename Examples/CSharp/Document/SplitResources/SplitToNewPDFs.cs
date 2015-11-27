//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Document.SplitResources
{
    class SplitToNewPDFs
    {
        public static void Run()
        {           
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Split all Pages to new PDFs
            WordsSplitResultResponse wordsSplitResultResponse = Common.WordsService.SplitDocument(inputfile, SplitDocumentFormat.Pdf, 1, 2, Common.FOLDER);
             
            Console.WriteLine("\n" + inputfile + " splitted successfully to new PDFs");
        }
    }
}
