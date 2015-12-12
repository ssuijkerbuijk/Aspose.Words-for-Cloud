//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Fields
{
    class InsertPageNumberField
    {
        public static void Run()
        {            
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);
                       
            // Insert Page Number Field into the Document
            PageNumberSettings pageNumberSettings = new PageNumberSettings("{PAGE} of {NUMPAGES}", "right", true, true);
            Common.WordsService.InsertDocumentPageNumbers(inputfile, Common.GetOutputFilePath(inputfile, true), Common.FOLDER, pageNumberSettings);

            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nPage number inserted successfully.\nFile saved at " + dataDir);
        }
    }
}
