//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Drawing
{
    class GetImageObject
    {
        public static void Run()
        {
            string subdirectory = "Drawing";

            // The path to the documents directory.
            string dataDir = Common.GetDataDir() + subdirectory + "\\";

            string inputfile = "imagefile.doc";
            string outputfile = "imagefile_out_.png";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirectory);

            dataDir = dataDir + outputfile;

            // Get the Image Drawing Object from Document
            Common.WordsService.WordsDrawingObjects.ReadDrawingObjectImageData(inputfile, 1, string.Empty, dataDir);

            Console.WriteLine("\nImage object fetched successfully.\nFile saved at " + dataDir);
        }
    }
}
