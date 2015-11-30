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
    class ConvertToAnotherFormat
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = Common.GetDataDir();

            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            dataDir = dataDir + Common.GetOutputFilePath(inputfile, false) + ".pdf";

            // Convert Word to other File Formats. This can be using the Cloud Storage or without cloud storage
            Common.WordsService.ConvertDocument(inputfile, WordOutputFormat.Pdf, Common.FOLDER, dataDir);
            
            Console.WriteLine("\nFile converted to another format.\nFile saved at " + dataDir);
        }
    }
}
