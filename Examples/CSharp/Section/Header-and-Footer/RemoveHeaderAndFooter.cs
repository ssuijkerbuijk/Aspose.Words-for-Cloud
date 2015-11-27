//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Section.Header_and_Footer
{
    class RemoveHeaderAndFooter
    {
        public static void Run()
        {
            string inputfile = "header-footer.doc";
            string subdirection = "Section";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Remove all Headers and Footers
            Common.WordsService.WordsHeadersFooters.DeleteDocumentHeadersAndFooters(inputfile, string.Empty, Common.GetOutputFilePath(inputfile,true), Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirection);

            Console.WriteLine("\nAll headers and footers removed successfully.\nFile saved at " + dataDir);
        }
    }
}
