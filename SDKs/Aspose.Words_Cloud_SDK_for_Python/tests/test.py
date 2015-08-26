import unittest
import os.path
import json
import inspect

import asposecloudwords
from asposecloudwords.ApiClient import ApiClient
from asposecloudwords.WordsApi import WordsApi
from asposecloudwords.ApiClient import ApiException
from asposecloudwords.models import BookmarksResponse
from asposecloudwords.models import BookmarkResponse
from asposecloudwords.models import BookmarkData
from asposecloudwords.models import DocumentEntryList
from asposecloudwords.models import DocumentEntry
from asposecloudwords.models import DocumentResponse
from asposecloudwords.models import PageNumber
from asposecloudwords.models import LoadWebDocumentData
from asposecloudwords.models import SaveOptionsData
from asposecloudwords.models import SaveResponse
from asposecloudwords.models import SplitDocumentResponse
from asposecloudwords.models import ResponseMessage
from asposecloudwords.models import WatermarkText
from asposecloudwords.models import ReplaceTextRequest
from asposecloudwords.models import ReplaceTextResponse
from asposecloudwords.models import TextItemsResponse
from asposecloudwords.models import SectionLinkCollectionResponse
from asposecloudwords.models import SectionPageSetupResponse
from asposecloudwords.models import SectionResponse
from asposecloudwords.models import PageSetup
from asposecloudwords.models import RevisionsModificationResponse
from asposecloudwords.models import Font
from asposecloudwords.models import FontResponse
from asposecloudwords.models import ParagraphLinkCollectionResponse
from asposecloudwords.models import RunResponse
from asposecloudwords.models import ParagraphResponse
from asposecloudwords.models import HyperlinksResponse
from asposecloudwords.models import HyperlinkResponse
from asposecloudwords.models import SaaSposeResponse
from asposecloudwords.models import DrawingObjectsResponse

import asposecloudstorage
from asposecloudstorage.StorageApi import StorageApi
from asposecloudstorage.models import ResponseMessage as StorageResponseMessage


class TestAsposeCloudWords(unittest.TestCase):

    def setUp(self):

        with open('setup.json') as json_file:
            data = json.load(json_file)

        self.storageApiClient = asposecloudstorage.ApiClient.ApiClient(apiKey=str(data['app_key']),appSid=str(data['app_sid']),debug=True,apiServer=str(data['product_uri']))
        self.storageApi = StorageApi(self.storageApiClient)

        self.apiClient = ApiClient(apiKey=str(data['app_key']),appSid=str(data['app_sid']),debug=True,apiServer=str(data['product_uri']))
        self.wordsApi = WordsApi(self.apiClient)

        self.output_path = str(data['output_location'])

    def testPostUpdateDocumentBookmark(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            bookmarkData = BookmarkData.BookmarkData()
            bookmarkData.Name = 'aspose'
            bookmarkData.Text = 'Bookmark is very good'

            response = self.wordsApi.PostUpdateDocumentBookmark('SampleWordDocument.docx','aspose',bookmarkData)

            self.assertIsInstance(response,BookmarkResponse.BookmarkResponse)
            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentBookmarkByName(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentBookmarkByName('SampleWordDocument.docx','aspose')

            self.assertIsInstance(response,BookmarkResponse.BookmarkResponse)
            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentBookmarks(self):
        
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')
            response = self.wordsApi.GetDocumentBookmarks('SampleWordDocument.docx')

            self.assertIsInstance(response,BookmarksResponse.BookmarksResponse)
            self.assertEqual(response.Status,'OK')
        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocument(self):

        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')
            response = self.wordsApi.GetDocument('SampleWordDocument.docx')

            self.assertIsInstance(response,DocumentResponse.DocumentResponse)
            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex


    def testGetDocumentWithFormat(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')
            response = self.wordsApi.GetDocumentWithFormat('SampleWordDocument.docx','pdf')

            self.assertEqual(response.Status,'OK')

            with open("./output/" + 'SampleWordDocument.pdf', 'wb') as f:
                for chunk in response.InputStream:
                    f.write(chunk)


            self.assertTrue(True, os.path.exists("./output/" + 'SampleWordDocument.pdf'))

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostAppendDocument(self):
        try:

            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')
            response = self.storageApi.PutCreate('SampleAppendDoc.docx','./data/SampleAppendDoc.docx')
            response = self.storageApi.PutCreate('SampleAppendDoc2.docx','./data/SampleAppendDoc2.docx')


            document1 = DocumentEntry.DocumentEntry()
            document1.Href = 'SampleAppendDoc.docx'
            document1.ImportFormatMode = 'KeepSourceFormatting'

            document2 = DocumentEntry.DocumentEntry()
            document2.Href = 'SampleAppendDoc2.docx'
            document2.ImportFormatMode = 'KeepSourceFormatting'

            documentList = DocumentEntryList.DocumentEntryList()
            documentList.DocumentEntries = [document1,document2]

            response = self.wordsApi.PostAppendDocument('SampleWordDocument.docx',documentList)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostInsertPageNumbers(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            pagenumber = PageNumber.PageNumber()
            pagenumber.Format = '{PAGE} of {NUMPAGES}'
            pagenumber.Alignment = 'center'

            response = self.wordsApi.PostInsertPageNumbers('SampleWordDocument.docx',pagenumber)
            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostLoadWebDocument(self):
        try:

            loadWebDocumentData = LoadWebDocumentData.LoadWebDocumentData()
            loadWebDocumentData.LoadingDocumentUrl = 'http://google.com'

            saveOptions = SaveOptionsData.SaveOptionsData()
            saveOptions.SaveFormat = 'doc'
            saveOptions.FileName = 'google.doc'

            loadWebDocumentData.SaveOptions = saveOptions


            response = self.wordsApi.PostLoadWebDocument(loadWebDocumentData)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SaveResponse.SaveResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostSplitDocument(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')
            response = self.wordsApi.PostSplitDocument('SampleWordDocument.docx',format='text',ffrom=1,to=2,zipOutput=False)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SplitDocumentResponse.SplitDocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPutConvertDocument(self):
        try:
            response = self.wordsApi.PutConvertDocument('./data/SampleWordDocument.docx',format='pdf')

            self.assertEqual(response.Status,'OK')

            with open("./output/" + 'SampleWordDocument.pdf', 'wb') as f:
                for chunk in response.InputStream:
                    f.write(chunk)

            self.assertTrue(True, os.path.exists("./output/" + 'SampleWordDocument.pdf'))

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostInsertWatermarkText(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertWatermarkText('SampleWordDocument.docx',watermarkText)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostInsertDocumentWatermarkText(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertDocumentWatermarkText('SampleWordDocument.docx',watermarkText)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostInsertWatermarkImage(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertWatermarkImage('SampleWordDocument.docx','./data/aspose-words.png')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostInsertDocumentWatermarkImage(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertDocumentWatermarkImage('SampleWordDocument.docx','./data/aspose-words.png')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostReplaceText(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            replaceText = ReplaceTextRequest.ReplaceTextRequest()
            replaceText.OldValue = 'Times New Roman'
            replaceText.NewValue = 'Arial Black'

            response = self.wordsApi.PostReplaceText('SampleWordDocument.docx',replaceText)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,ReplaceTextResponse.ReplaceTextResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentTextItems(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentTextItems('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,TextItemsResponse.TextItemsResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetSections(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetSections('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SectionLinkCollectionResponse.SectionLinkCollectionResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetSectionPageSetup(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetSectionPageSetup('SampleWordDocument.docx',0)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SectionPageSetupResponse.SectionPageSetupResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetSection(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetSection('SampleWordDocument.docx',0)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SectionResponse.SectionResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testUpdateSectionPageSetup(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            pageSetup = PageSetup.PageSetup()
            pageSetup.RtlGutter = True
            pageSetup.LeftMargin = 10.0
            pageSetup.Orientation = 'Landscape'
            pageSetup.PaperSize = 'A5'

            response = self.wordsApi.UpdateSectionPageSetup('SampleWordDocument.docx',0,pageSetup)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SectionPageSetupResponse.SectionPageSetupResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testRejectAllRevisions(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.RejectAllRevisions('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,RevisionsModificationResponse.RevisionsModificationResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testAcceptAllRevisions(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.AcceptAllRevisions('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,RevisionsModificationResponse.RevisionsModificationResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testPostDocumentParagraphRunFont(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            font = Font.Font()
            font.Name = "Arial"
            font.Bold = True

            response = self.wordsApi.PostDocumentParagraphRunFont('SampleWordDocument.docx',0,0,font)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,FontResponse.FontResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentParagraphs(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraphs('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,ParagraphLinkCollectionResponse.ParagraphLinkCollectionResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentParagraphRunFont(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraphRunFont('SampleWordDocument.docx',0,0)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,FontResponse.FontResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentParagraphRun(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraphRun('SampleWordDocument.docx',0,0)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,RunResponse.RunResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentParagraph(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentParagraph('SampleWordDocument.docx',1)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,ParagraphResponse.ParagraphResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentHyperlinks(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentHyperlinks('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,HyperlinksResponse.HyperlinksResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentHyperlinkByIndex(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentHyperlinkByIndex('SampleWordDocument.docx',0)

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,HyperlinkResponse.HyperlinkResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testDeleteHeadersFooters(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.DeleteHeadersFooters('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,SaaSposeResponse.SaaSposeResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentDrawingObjects(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjects('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DrawingObjectsResponse.DrawingObjectsResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentDrawingObjectOleData(self):
        try:
            response = self.storageApi.PutCreate('sample_EmbeddedOLE.docx','./data/sample_EmbeddedOLE.docx')

            response = self.wordsApi.GetDocumentDrawingObjectOleData('sample_EmbeddedOLE.docx',0)

            print inspect.getmembers(response)

            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentDrawingObjectImageData(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjectImageData('SampleWordDocument.docx',1)

            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentDrawingObjectByIndexWithFormat(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjectByIndexWithFormat('SampleWordDocument.docx',1,'jpg')

            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testGetDocumentDrawingObjectByIndex(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            response = self.wordsApi.GetDocumentDrawingObjectByIndex('SampleWordDocument.docx',1)

            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex

    def testDeleteDocumentWatermark(self):
        try:
            response = self.storageApi.PutCreate('SampleWordDocument.docx','./data/SampleWordDocument.docx')

            watermarkText = WatermarkText.WatermarkText()
            watermarkText.Text = "Welcome Aspose"
            watermarkText.RotationAngle = '45'

            response = self.wordsApi.PostInsertWatermarkText('SampleWordDocument.docx',watermarkText)

            response = self.wordsApi.DeleteDocumentWatermark('SampleWordDocument.docx')

            self.assertEqual(response.Status,'OK')
            self.assertIsInstance(response,DocumentResponse.DocumentResponse)

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex