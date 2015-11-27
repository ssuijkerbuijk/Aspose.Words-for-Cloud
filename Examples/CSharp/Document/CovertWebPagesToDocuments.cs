/////////////////////////////////////////////////////////////////////////
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
    class CovertWebPagesToDocuments
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = Common.GetDataDir();

            string inputfile = "google-sample.xml";

            // Create XMLDocument object           
            System.Xml.XmlDocument docXML = new System.Xml.XmlDocument();
            // Load XML from XML file
            docXML.Load(dataDir + inputfile);

            Common.WordsService.LoadNewDocumentFromWebIntoFile(docXML.InnerXml);
        }
    }
}
