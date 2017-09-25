namespace Aspose.Words.Cloud.Sdk.Tests
{
    using System;

    using Aspose.Words.Cloud.Sdk;
    using Aspose.Words.Cloud.Sdk.Api;
    using Aspose.Words.Cloud.Sdk.Model;

    using Com.Aspose.Storage.Api;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This is a test class for TestWordsApi and is intended
    /// to contain all TestWordsApi Unit Tests
    /// </summary>
    [TestClass]
    [DeploymentItem("Data", "Data")]
    public class TestWordsApi
    {
        private TestContext testContextInstance;

        protected WordsApi target;
        protected StorageApi storageApi;

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }

            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        /// A test for WordsApi Constructor
        /// </summary>
        public TestWordsApi()
        {
            target = new WordsApi("0fbf678c5ecabdb5caca48452a736dd0", "91a2fd07-bba1-4b32-9112-abfb1fe8aebd", "http://api.aspose.cloud/v1.1");
            storageApi = new StorageApi("0fbf678c5ecabdb5caca48452a736dd0", "91a2fd07-bba1-4b32-9112-abfb1fe8aebd", "http://api.aspose.cloud/v1.1");
        }

        /// <summary>
        /// A test for AcceptAllRevisions
        /// </summary>
        [TestMethod]
        public void TestAcceptAllRevisions()
        {
            string name = "test_multi_pages.docx";
            string filename = "Test2.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            var request = new AcceptAllRevisionsRequest(name, filename, storage, folder);
            var actual = target.AcceptAllRevisions(request);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteComment
        /// </summary>
        [TestMethod]
        public void TestDeleteComment()
        {
            string name = "test_multi_pages.docx";
            int commentIndex = 0;           
            string fileName = "test_multi_pages.docx";
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteComment(name, commentIndex, fileName);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteDocumentFields
        /// </summary>
        [TestMethod]
        public void TestDeleteDocumentFields()
        {
            string name = "test_multi_pages.docx";
         
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteFields(name);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteDocumentMacros
        /// </summary>
        [TestMethod]
        public void TestDeleteDocumentMacros()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteDocumentMacros(name, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteDocumentProperty
        /// </summary>
        [TestMethod]
        public void TestDeleteDocumentProperty()
        {
            string name = "test_multi_pages.docx";
            string propertyName = "AsposeAuthor";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            var body = new DocumentProperty();
            body.Name = "AsposeAuthor";
            body.Value = "Imran Anwar";
            body.BuiltIn = false;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            // setting a property
            target.PutUpdateDocumentProperty(name, propertyName, body, filename, storage, folder);

            var actual = target.DeleteDocumentProperty(name, propertyName, filename, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteDocumentWatermark
        /// </summary>
        [TestMethod]
        public void TestDeleteDocumentWatermark()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteDocumentWatermark(name, filename, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteFormField
        /// </summary>
        [TestMethod]
        public void TestDeleteFormField()
        {
            string name = "FormFilled.docx";            
            int formfieldIndex = 0;
            string destFileName = "FormFilledTest.docx";
            

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                        
            SaaSposeResponse actual = target.DeleteFormField(name, formfieldIndex, "sections/0", destFileName);

            Assert.AreEqual(200, actual.Code);                        
        }

        /// <summary>
        /// A test for DeleteField
        /// </summary>
        [TestMethod]
        public void TestDeleteField()
        {
            string name = "GetField.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            int fieldIndex = 0;           
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteField(name, fieldIndex, "sections/0/paragraphs/0");

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteHeadersFooters
        /// </summary>
        [TestMethod]
        public void TestDeleteHeadersFooters()
        {
            string name = "test_multi_pages.docx";            
            string filename = "test.docx";            

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            SaaSposeResponse actual = target.DeleteHeadersFooters(name, "sections/0", destFileName: filename);

           Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for DeleteParagraphFields
        /// </summary>
        [TestMethod]
        public void TestDeleteParagraphFields()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteFields(name, "paragraphs/0", storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteSectionFields
        /// </summary>
        [TestMethod]
        public void TestDeleteSectionFields()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; // TODO: Initialize to an appropriate value
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteFields(name, "sections/0", storage, folder);

            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for GetRenderPage
        /// </summary>
        [TestMethod]
        public void TestGetRenderPage()
        {
            string name = "SampleWordDocument.docx";
            int pageNumber = 1;
            String format = "bmp";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            target.RenderPage(name, pageNumber, format, storage, folder);

            // TODO: check response file
        }

        /// <summary>
        /// A test for DeleteSectionParagraphFields
        /// </summary>
        [TestMethod]
        public void TestDeleteSectionParagraphFields()
        {

            string name = "test_multi_pages.docx";
            int sectionIndex = 0; // TODO: Initialize to an appropriate value
            int paragraphIndex = 0; // TODO: Initialize to an appropriate value
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.DeleteFields(name, "sections/0/paragraphs/0", storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for DeleteUnprotectDocument
        /// </summary>
        [TestMethod]
        public void TestDeleteUnprotectDocument()
        {
            string name = "SampleProtectedBlankWordDocument.docx";
            
            var body = new ProtectionRequest();
            body.Password = "aspose";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                        
            ProtectionDataResponse actual = target.DeleteUnprotectDocument(name, body);
            
            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for GetComment
        /// </summary>
        [TestMethod]
        public void TestGetComment()
        {
            string name = "test_multi_pages.docx";
            int commentIndex = 0;
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetComment(name, commentIndex, storage, folder);

            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for GetComments
        /// </summary>
        [TestMethod]
        public void TestGetComments()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                        
            var actual = target.GetComments(name, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocument
        /// </summary>
        [TestMethod]
        public void TestGetDocument()
        {            
            string name = "test_multi_pages.docx";          
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocument(name);

           Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for GetDocumentBookmarkByName
        /// </summary>
        [TestMethod]
        public void TestGetDocumentBookmarkByName()
        {

            string name = "test_multi_pages.docx";
            string bookmarkName = "aspose";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                        
            var actual = target.GetDocumentBookmarkByName(name, bookmarkName, storage, folder);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentBookmarks
        /// </summary>
        [TestMethod]
        public void TestGetDocumentBookmarks()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentBookmarks(name, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentDrawingObjectByIndex
        /// </summary>
        [TestMethod]
        public void TestGetDocumentDrawingObjectByIndex()
        {
            string name = "test_multi_pages.docx";
            int objectIndex = 0;
          
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            DrawingObjectResponse actual = target.GetDocumentDrawingObjectByIndex(name, objectIndex, "sections/0");

            Assert.AreEqual(200, actual.Code);                        
        }

        /// <summary>
        /// A test for GetDocumentDrawingObjectByIndexWithFormat
        /// </summary>
        [TestMethod]
        public void TestGetDocumentDrawingObjectByIndexWithFormat()
        {
            string name = "test_multi_pages.docx";
            int objectIndex = 0;
            string format = "png";
           
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.RenderDrawingObject(name, format, objectIndex, "sections/0");                        
        }

        /// <summary>
        /// A test for GetDocumentDrawingObjectImageData
        /// </summary>
        [TestMethod]
        public void TestGetDocumentDrawingObjectImageData()
        {
            string name = "test_multi_pages.docx";
            int objectIndex = 0;            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            target.GetDocumentDrawingObjectImageData(name, objectIndex, "sections/0");            
        }

        /// <summary>
        /// A test for GetDocumentDrawingObjectOleData
        /// </summary>
        [TestMethod]
        public void TestGetDocumentDrawingObjectOleData()
        {
            string name = "sample_EmbeddedOLE.docx";
            int objectIndex = 0;             
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));


            target.GetDocumentDrawingObjectOleData(name, objectIndex, "sections/0");            
        }

        /// <summary>
        /// A test for GetDocumentDrawingObjects
        /// </summary>
        [TestMethod]
        public void TestGetDocumentDrawingObjects()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentDrawingObjects(name, "sections/0", storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentFieldNames
        /// </summary>
        [TestMethod]
        public void TestGetDocumentFieldNames()
        {
            string name = name = "test_multi_pages.docx";
            bool useNonMergeFields = false;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentFieldNames(name, useNonMergeFields: useNonMergeFields);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentHyperlinkByIndex
        /// </summary>
        [TestMethod]
        public void TestGetDocumentHyperlinkByIndex()
        {
            string name = "test_doc.docx";
            int hyperlinkIndex = 0;
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentHyperlinkByIndex(name, hyperlinkIndex, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentHyperlinks
        /// </summary>
        [TestMethod]
        public void TestGetDocumentHyperlinks()
        {
            string name = "test_doc.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentHyperlinks(name, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentParagraph
        /// </summary>
        [TestMethod]
        public void TestGetDocumentParagraph()
        {
            string name = "test_multi_pages.docx";
            int index = 0;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentParagraph(name, index, "sections/0");

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentParagraph
        /// </summary>
        [TestMethod]
        public void TestGetDocumentParagraphWithoutNodePath()
        {
            string name = "test_multi_pages.docx";
            int index = 0;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            var actual = target.GetDocumentParagraph(name, index);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentParagraphRun
        /// </summary>
        [TestMethod]
        public void TestGetDocumentParagraphRun()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            int runIndex = 0; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentParagraphRun(name, "paragraphs/0", runIndex, storage, folder);

           Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentParagraphRunFont
        /// </summary>
        [TestMethod]
        public void TestGetDocumentParagraphRunFont()
        {
            string name = "test_multi_pages.docx";
            int index = 0; 
            int runIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentParagraphRunFont(name, "paragraphs/0", runIndex, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentParagraphs
        /// </summary>
        [TestMethod]
        public void TestGetDocumentParagraphs()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentParagraphs(name, "sections/0", storage, folder);

            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for GetDocumentProperties
        /// </summary>
        [TestMethod]
        public void TestGetDocumentProperties()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));            
            var actual = target.GetDocumentProperties(name);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentProperty
        /// </summary>
        [TestMethod]
        public void TestGetDocumentProperty()
        {
            string name = "test_multi_pages.docx";
            string propertyName = "Author";            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentProperty(name, propertyName);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentProtection
        /// </summary>
        [TestMethod]
        public void TestGetDocumentProtection()
        {
            string name = "test_multi_pages.docx";
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentProtection(name);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentStatistics
        /// </summary>
        [TestMethod]
        public void TestGetDocumentStatistics()
        {
            string name = "test_multi_pages.docx";
            bool includeComments = false;
            bool includeFootnotes = false;
            bool includeTextInShapes = false;
          

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentStatistics(name, includeComments: includeComments, includeFootnotes: includeFootnotes, includeTextInShapes: includeTextInShapes);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentTextItems
        /// </summary>
        [TestMethod]
        public void TestGetDocumentTextItems()
        {
            string name = "test_multi_pages.docx";
          
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetDocumentTextItems(name);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetDocumentWithFormat
        /// </summary>
        [TestMethod]
        public void TestGetDocumentWithFormat()
        {
            string name = "test_multi_pages.docx";
            string format = "text";
            string storage = null;
            string folder = null;
            string outPath = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            
            target.GetDocumentWithFormat(name, format, storage, folder, outPath);

            // TODO: add case with specified out path            
        }

        /// <summary>
        /// A test for GetField
        /// </summary>
        [TestMethod]
        public void TestGetField()
        {
            string name = "GetField.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            int fieldIndex = 0;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetField(name, fieldIndex, "sections/0/paragraphs/0");

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetFields
        /// </summary>
        [TestMethod]
        public void TestGetFields()
        {
            string name = "GetField.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;           
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            FieldsResponse actual = target.GetFields(name, "sections/0", storage, folder);

           Assert.AreEqual(200, actual.Code);           
        }

        /// <summary>
        /// A test for TestGetParagraphRuns
        /// </summary>
        [TestMethod]
        public void TestGetParagraphRuns()
        {
            string name = "GetField.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            RunsResponse actual = target.GetDocumentParagraphRuns(name, "sections/0/paragraphs/0", storage, folder);

            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        ///  A test for GetFormFields
        /// </summary>        
        [TestMethod]
        public void TestGetFormFields()
        {
            string name = "FormFilled.docx";
          
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            FormFieldsResponse actual = target.GetFormFields(name, "sections/0");

           Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for GetFormField
        /// </summary>
        [TestMethod]
        public void TestGetFormField()
        {
            string name = "FormFilled.docx";
            int formfieldIndex = 0;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            FormFieldResponse actual = target.GetFormField(name, formfieldIndex, "sections/0");

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetSection
        /// </summary>
        [TestMethod]
        public void TestGetSection()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetSection(name, sectionIndex, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetSectionPageSetup
        /// </summary>
        [TestMethod]
        public void TestGetSectionPageSetup()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0;
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetSectionPageSetup(name, sectionIndex, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for GetSections
        /// </summary>
        [TestMethod]
        public void TestGetSections()
        {
            string name = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.GetSections(name, storage, folder);

            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for PostAppendDocument
        /// </summary>
        [TestMethod]
        public void TestPostAppendDocument()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
           
            var body = new DocumentEntryList();
            System.Collections.Generic.List<DocumentEntry> docEntries = new System.Collections.Generic.List<DocumentEntry> { };

            DocumentEntry docEntry = new DocumentEntry();
            docEntry.Href = "test_multi_pages.docx";
            docEntry.ImportFormatMode = "KeepSourceFormatting";
            docEntries.Add(docEntry);
            body.DocumentEntries = docEntries;            

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            var actual = target.PostAppendDocument(name, body, filename);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostChangeDocumentProtection
        /// </summary>
        [TestMethod]
        public void TestPostChangeDocumentProtection()
        {
            string name = "test_multi_pages.docx";
            
            var body = new ProtectionRequest();
            body.NewPassword = "";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            var actual = target.PostChangeDocumentProtection(name, body);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostComment
        /// </summary>
        [TestMethod]
        public void TestPostComment()
        {
            string name = "test_multi_pages.docx";
            int commentIndex = 0;
            string fileName = null;
            string storage = null;
            string folder = null;

            var body = new Comment();

            var dpdto = new DocumentPosition();
            NodeLink nodeLink = new NodeLink();
            

            dpdto.Node = nodeLink;
            dpdto.Offset = 0;
            
            nodeLink.NodeId = "0.0.3";

            body.RangeStart = dpdto;
            body.RangeEnd = dpdto;

            body.Initial = "IA";
            body.Author = "Imran Anwar";
            body.Text = "A new Comment";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostComment(name, commentIndex, body, fileName, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostDocumentExecuteMailMerge
        /// </summary>
        [TestMethod]
        public void TestPostDocumentExecuteMailMerge()
        {
            string name = "SampleMailMergeTemplate.docx";
            bool withRegions = false;
            string mailMergeDataFile = null;
            string cleanup = null;
            string filename = "SampleMailMergeResult.docx";
            string storage = null;
            string folder = null;
            bool useWholeParagraphAsRegion = false;
            var data = System.IO.File.ReadAllText(Common.GetDataDir() + "SampleMailMergeTemplateData.txt");

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostDocumentExecuteMailMerge(name, withRegions, data, destFileName: filename, cleanup: cleanup, useWholeParagraphAsRegion: useWholeParagraphAsRegion);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostDocumentParagraphRunFont
        /// </summary>
        [TestMethod]
        public void TestPostDocumentParagraphRunFont()
        {
            string name = "test_multi_pages.docx";
            int index = 0; // TODO: Initialize to an appropriate value
            int runIndex = 0; // TODO: Initialize to an appropriate value          
            string filename = "test.docx";
            var body = new Font();
            body.Bold = true;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostDocumentParagraphRunFont(name, body, "paragraphs/0", runIndex, filename);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostDocumentSaveAs
        /// </summary>
        [TestMethod]
        public void TestPostDocumentSaveAs()
        {
            string name = "test_multi_pages.docx";
           
            var body = new SaveOptionsData();

            body.SaveFormat = "pdf";
            body.FileName = "output.pdf";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostDocumentSaveAs(name, body);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostExecuteTemplate
        /// </summary>
        [TestMethod]
        public void TestPostExecuteTemplate()
        {
            string name = "TestExecuteTemplate.doc";
            string cleanup = null;
            string destFileName = "TestExecuteResult.doc";
            string storage = null;
            string folder = null;
            bool useWholeParagraphAsRegion = false; // TODO: Initialize to an appropriate value
            bool withRegions = false; // TODO: Initialize to an appropriate value
            string data = System.IO.File.ReadAllText(Common.GetDataDir() + "TestExecuteTemplateData.txt");

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostExecuteTemplate(name, data, cleanup: cleanup, destFileName: destFileName, useWholeParagraphAsRegion: useWholeParagraphAsRegion, withRegions: withRegions);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostField
        /// </summary>
        [TestMethod]
        public void TestPostField()
        {
            string name = "GetField.docx";         
            int fieldIndex = 0; // TODO: Initialize to an appropriate value
            string destFileName = "newSampleWordDocument.docx";
            string storage = null;
            string folder = null;

            var body = new Field();
            body.Result = "3";
            body.FieldCode = "{ NUMPAGES }";
            
            body.NodeId = "0.0.3";
                        
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                        
            var actual = target.PostField(name, body, fieldIndex, "sections/0/paragraphs/0", destFileName);
            
            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for PostFormField
        /// </summary>
        [TestMethod]
        public void TestPostFormField()
        {
            // Arrange
            string name = "FormFilled.docx";           
            int formfieldIndex = 0;
            string destFileName = "newFormFilled.docx";
            
            FormFieldTextInput body = new FormFieldTextInput();

            body.Name = "FullName";
            body.Enabled = true;
            body.CalculateOnExit = true;
            body.StatusText = string.Empty;
                     
            body.TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular;
            body.TextInputDefault = string.Empty;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            // Act
            FormFieldResponse actual = target.PostFormField(name, body, formfieldIndex, "sections/0", destFileName);
            
            // Assert
            Assert.AreEqual(200, actual.Code);
            Assert.AreEqual("FullName", actual.FormField.Name);
            Assert.AreEqual(true, actual.FormField.Enabled);

            var formFieldTextInput = actual.FormField as FormFieldTextInput;
            Assert.IsTrue(formFieldTextInput != null, "Incorrect type of formfield: {0} instead of {1}", actual.FormField.GetType(), typeof(FormFieldTextInput));
            Assert.AreEqual(FormFieldTextInput.TextInputTypeEnum.Regular, formFieldTextInput.TextInputType);
        }

        /// <summary>
        /// A test for PostInsertDocumentWatermarkImage
        /// </summary>
        [TestMethod]
        public void TestPostInsertDocumentWatermarkImage()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            double rotationAngle = 0F;
            string image = "aspose-cloud.png";
           
            using (var file = System.IO.File.OpenRead(Common.GetDataDir() + image))
            {
                storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                
                var actual = target.PostInsertDocumentWatermarkImage(
                    name,
                    file,
                    rotationAngle,
                    destFileName: filename);

                Assert.AreEqual(200, actual.Code);
            }
        }

        /// <summary>
        /// A test for PostInsertDocumentWatermarkText
        /// </summary>
        [TestMethod]
        public void TestPostInsertDocumentWatermarkText()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            string text = "Aspose Watermark";
            double rotationAngle = 0F;
            
            var body = new WatermarkText();
            body.Text = "The watermark of Aspose";            

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostInsertDocumentWatermarkText(name, body, filename);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostInsertPageNumbers
        /// </summary>
        [TestMethod]
        public void TestPostInsertPageNumbers()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            
            var body = new PageNumber();
            body.Alignment = "center";
            body.Format = "{PAGE} of {NUMPAGES}";
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostInsertPageNumbers(name, body, filename);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostInsertWatermarkImage
        /// </summary>
        [TestMethod]
        public void TestPostInsertWatermarkImage()
        {
            string name = "test_multi_pages.docx";
            string filename = "test.docx";
            double rotationAngle = 0F; // TODO: Initialize to an appropriate value
            string image = "aspose-cloud.png";
            string storage = null;
            string folder = null;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            storageApi.PutCreate(image, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + image));
            
            var actual = target.PostInsertDocumentWatermarkImage(name, image: image, rotationAngle: rotationAngle);
            
            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for PostInsertWatermarkText
        /// </summary>
        [TestMethod]
        public void TestPostInsertWatermarkText()
        {
            string name = "test_multi_pages.docx";
                       
            string filename = "test_multi_pages.docx";
           
            var body = new WatermarkText();
            body.Text = "This is the text";
            body.RotationAngle = 90.0f;
            
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostInsertDocumentWatermarkText(name, body, filename);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostLoadWebDocument
        /// </summary>
        [TestMethod]
        public void TestPostLoadWebDocument()
        {
            var body = new LoadWebDocumentData();
            var soptions = new SaveOptionsData();
            soptions.FileName = "google.doc";
            soptions.SaveFormat = "doc";
            soptions.ColorMode = "1";
            soptions.DmlEffectsRenderingMode = "1";
            soptions.DmlRenderingMode = "1";
            soptions.UpdateSdtContent = false;
            soptions.ZipOutput = false;

            body.LoadingDocumentUrl = "http://google.com";
            body.SaveOptions = soptions;
            
            var actual = target.PostLoadWebDocument(body);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostReplaceText
        /// </summary>
        [TestMethod]
        public void TestPostReplaceText()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages_result.docx";
            string storage = null;
            string folder = null;
            var body = new ReplaceTextRequest();
            body.OldValue = "aspose";
            body.NewValue = "aspose new";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            
            var actual = target.PostReplaceText(name, body, filename, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
        }
        
        /// <summary>
        /// A test for PostSplitDocument
        /// </summary>
        [TestMethod]
        public void TestPostSplitDocument()
        {
            string name = "test_multi_pages.docx";
            string format = "text";
            int from = 1; 
            int to = 2; 
            bool zipOutput = false; 
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostSplitDocument(name, format: format, from: from, to: to);
            
            Assert.AreEqual(200, actual.Code);            
        }

        /// <summary>
        /// A test for PostUpdateDocumentBookmark
        /// </summary>
        [TestMethod]
        public void TestPostUpdateDocumentBookmark()
        {
            string name = "test_multi_pages.docx";
            string bookmarkName = "aspose";
            string filename = "test.docx";
            string storage = null;
            string folder = null;
            var body = new BookmarkData();
            body.Name = "aspose";
            body.Text = "This will be the text for Aspose";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            var actual = target.PostUpdateDocumentBookmark(name, body, bookmarkName, filename, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PostUpdateDocumentFields
        /// </summary>
        [TestMethod]
        public void TestPostUpdateDocumentFields()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            var actual = target.PostUpdateDocumentFields(name, filename, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PutComment
        /// </summary>
        [TestMethod]
        public void TestPutComment()
        {
            string name = "test_multi_pages.docx";
            string fileName = null;
            string storage = null;
            string folder = null;
            var body = new Comment();

            var dpdto = new DocumentPosition();
            NodeLink nodeLink = new NodeLink();
            

            dpdto.Node = nodeLink;
            dpdto.Offset = 0;            
            nodeLink.NodeId = "0.0.3";

            body.RangeStart = dpdto;
            body.RangeEnd = dpdto;

            body.Initial = "IA";
            body.Author = "Imran Anwar";
            body.Text = "A new Comment";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            CommentResponse actual;
            actual = target.PutComment(name, body, fileName, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PutConvertDocument
        /// </summary>
        [TestMethod]
        public void TestPutConvertDocument()
        {
            string format = "pdf";
            string outPath = null;
            string replaceResourcesHostTo = "new_pdf.pdf";
            using (var fileStream = System.IO.File.OpenRead(Common.GetDataDir() + "test_uploadfile.docx"))
            {                
                target.PutConvertDocument(format, fileStream);             
            }
        }

        /// <summary>
        /// A test for PutDocumentFieldNames
        /// </summary>
        [TestMethod]
        public void TestPutDocumentFieldNames()
        {            
            using (var fileStream = System.IO.File.OpenRead(Common.GetDataDir() + "SampleExecuteTemplate.docx"))
            {                
                FieldNamesResponse actual = target.PutDocumentFieldNames(fileStream, true);

                Assert.AreEqual(200, actual.Code);
            }
        }

        /// <summary>
        /// A test for PutDocumentSaveAsTiff
        /// </summary>
        [TestMethod]
        public void TestPutDocumentSaveAsTiff()
        {
            string name = "test_multi_pages.docx";
            string resultFile = "test.docx";
         
            TiffSaveOptionsData body = new TiffSaveOptionsData();
            body.FileName = "abc.tiff";
            body.SaveFormat = "tiff";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));            
            SaveResponse actual = target.PutDocumentSaveAsTiff(
                name, 
                body, 
                resultFile);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PutExecuteMailMergeOnline
        /// </summary>
        [TestMethod]
        public void TestPutExecuteMailMergeOnline()
        {
            bool withRegions = false;
            string cleanup = null;
            using (var file = System.IO.File.OpenRead(Common.GetDataDir() + "SampleExecuteTemplate.docx"))
            {
                using (var data = System.IO.File.OpenRead(Common.GetDataDir() + "SampleExecuteTemplateData.txt"))
                {                    
                    var actual = target.PutExecuteMailMergeOnline(file, data, withRegions, cleanup);                   
                }
            }
        }

        /// <summary>
        /// A test for PutExecuteTemplateOnline
        /// </summary>
        [TestMethod]
        public void TestPutExecuteTemplateOnline()
        {
            string cleanup = null;
            bool useWholeParagraphAsRegion = false;
            bool withRegions = false; 
         
            using (var file = System.IO.File.OpenRead(Common.GetDataDir() + "SampleMailMergeTemplate.docx"))
            {
                using (var data = System.IO.File.OpenRead(Common.GetDataDir() + "SampleExecuteTemplateData.txt"))
                {                    
                    var actual = target.PutExecuteTemplateOnline(
                        file,
                        data,
                        cleanup,
                        useWholeParagraphAsRegion,
                        withRegions);                    
                }
            }
        }

        /// <summary>
        /// A test for PutField
        /// </summary>
        [TestMethod]
        public void TestPutField()
        {
            string name = "SampleWordDocument.docx";
            int sectionIndex = 0; 
            int paragraphIndex = 0; 
            string insertBeforeNode = null;
            string destFileName = null;
            string storage = null;
            string folder = null;

            Field body = new Field();
            body.Result = "3";
            body.FieldCode = "{ NUMPAGES }";
            
            body.NodeId = "0.0.3";
            

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            FieldResponse actual;
            actual = target.PutField(name, body, "sections/0/paragraphs/0", insertBeforeNode, destFileName, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PutFormField
        /// </summary>
        [TestMethod]
        public void TestPutFormField()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            string insertBeforeNode = null;
            string destFileName = "test.docx";
            string storage = null;
            string folder = null;

            var body = new FormFieldTextInput();

            body.Name = "FullName";
            body.Enabled = true;
            body.CalculateOnExit = true;
            body.StatusText = "";


            body.TextInputType = FormFieldTextInput.TextInputTypeEnum.Regular;
            body.TextInputDefault = "123";
            body.TextInputFormat = "UPPERCASE";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            FormFieldResponse actual;
            actual = target.PutFormField(name, body, "sections/0/paragraphs/0", destFileName: destFileName);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PutProtectDocument
        /// </summary>
        [TestMethod]
        public void TestPutProtectDocument()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            ProtectionRequest body = new ProtectionRequest(); 

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            ProtectionDataResponse actual;
            actual = target.PutProtectDocument(name, body, filename, storage, folder);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for PutUpdateDocumentProperty
        /// </summary>
        [TestMethod]
        public void TestPutUpdateDocumentProperty()
        {
            string name = "test_multi_pages.docx";
            string propertyName = "Author";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;
            DocumentProperty body = new DocumentProperty();
            body.Name = "Author";
            body.Value = "Imran Anwar";

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            DocumentPropertyResponse actual;
            actual = target.PutUpdateDocumentProperty(name, propertyName, body, filename, storage, folder);
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for RejectAllRevisions
        /// </summary>
        [TestMethod]
        public void TestRejectAllRevisions()
        {
            string name = "test_multi_pages.docx";
            string filename = "test_multi_pages.docx";
            string storage = null;
            string folder = null;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));

            RevisionsModificationResponse actual;
            actual = target.RejectAllRevisions(name, filename, storage, folder);

            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for Search
        /// </summary>
        [TestMethod]
        public void TestSearch()
        {
            string name = "SampleWordDocument.docx";
            string pattern = "aspose";
         
            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
            
            SearchResponse actual;
            actual = target.Search(name, pattern: pattern);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// A test for UpdateSectionPageSetup
        /// </summary>
        [TestMethod]
        public void TestUpdateSectionPageSetup()
        {
            string name = "test_multi_pages.docx";
            int sectionIndex = 0; 
            string storage = null;
            string folder = null;
            string filename = null;

            var body = new PageSetup();
            body.RtlGutter = true;
            body.LeftMargin = 10.0f;
            body.Orientation = PageSetup.OrientationEnum.Landscape;
            body.PaperSize = PageSetup.PaperSizeEnum.A5;

            storageApi.PutCreate(name, null, null, System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                        
            var actual = target.UpdateSectionPageSetup(name, sectionIndex, body, storage, folder, filename);
            
            Assert.AreEqual(200, actual.Code);
        }

        /// <summary>
        /// If file does not exist, 400 response should be returned with message "Error while loading file ".
        /// </summary>
        [TestMethod]
        public void TestHandleErrors()
        {
            string name = "noFileWithThisName.docx";

            try
            {
                var result = this.target.GetSections(name);

                Assert.Fail("Excpected exception has not been throwed");
            }
            catch (ApiException apiException)
            {
                Assert.AreEqual(400, apiException.ErrorCode);
                Assert.IsTrue(apiException.Message.StartsWith("Error while loading file 'noFileWithThisName.docx' from storage:"), "Current message: " + apiException.Message);
            }
        }
    }
}
