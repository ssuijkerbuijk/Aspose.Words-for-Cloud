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
