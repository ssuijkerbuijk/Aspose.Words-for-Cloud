//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Page_Setup
{
    class ExtractPageSetupInformation
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "PageSetup";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Extract Page Setup Information from a Word Document
            PageSetupResponse pageSetupResponse = Common.WordsService.WordsSections.GetPageSetupOfSection(inputfile, 0, Common.FOLDER);

            Console.WriteLine("\nPage setup informations from " + inputfile + " file extracted successfully.");
        }
    }
}
