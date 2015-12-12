//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Fields.ParagraphLevel
{
    class AddFormFields
    {

        public static void Run()
        {            
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Convert Word Documents to any Format with Additional Settings
            string saveOptionsXML = @"<PdfSaveOptions>
               <SaveFormat>pdf</SaveFormat>
               <FileName>Output.pdf</FileName>
               <ImageCompression>Jpeg</ImageCompression>
               <JpegQuality>70</JpegQuality>
               <TextCompression>Flate</TextCompression>
            </PdfSaveOptions>";

            Common.WordsService.WordsDocumentSaveAs.ConvertDocument(inputfile, saveOptionsXML, Common.FOLDER);
        }
    }
}
