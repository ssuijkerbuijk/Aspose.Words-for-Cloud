//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words.Cloud. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System;
using Aspose.Cloud;

namespace CSharp.Section
{
    class GetAllSections
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "Section";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Get a List of Sections from a Word Document
            WordsSectionsResponse wordsSectionsResponse = Common.WordsService.WordsSections.GetSectionsList(inputfile, Common.FOLDER);

            Console.WriteLine("\n" +  inputfile + " have " + wordsSectionsResponse.Sections.SectionLinkList.Count + " sections.");
        }
    }
}
