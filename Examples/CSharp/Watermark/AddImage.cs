//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Watermark
{
    class AddImage
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";            
            string imagefile = "Aspose Logo.png";

            string outfile = Common.GetOutputFilePath(inputfile, true);
            
            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Upload image file from local directory to Cloud Storage
            Common.UploadFile(imagefile, string.Empty);

            // Add Watermark Image to a Word Document
            Common.WordsService.WordsDocumentWatermark.InsertDocumentWatermarkImage(inputfile, outfile, 45.0, imagefile, Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, string.Empty);

            Console.WriteLine("\nWatermark image added successfully.\nFile saved at " + dataDir);
        }
    }
}
