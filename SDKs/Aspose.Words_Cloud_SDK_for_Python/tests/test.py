import unittest
import os.path
import json

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

import asposecloudstorage
from asposecloudstorage.StorageApi import StorageApi


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
            response = self.wordsApi.GetDocument('SampleWordDocument.docx')

            self.assertIsInstance(response,BookmarksResponse.BookmarksResponse)
            self.assertEqual(response.Status,'OK')

        except ApiException as ex:
            print "Exception"
            print "Code: " + str(ex.code)
            print "Mesage: " + ex.message
            raise ex


    def testGetDocumentWithFormat(self):
        try:
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





