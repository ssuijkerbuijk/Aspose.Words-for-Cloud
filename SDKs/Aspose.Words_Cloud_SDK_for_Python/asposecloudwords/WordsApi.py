#!/usr/bin/env python

import sys
import os
import urllib
import json
import re
from models import *
from ApiClient import ApiException


class WordsApi(object):

    def __init__(self, apiClient):
      self.apiClient = apiClient

    

    def GetDocumentBookmarkByName(self, name, bookmarkName, **kwargs):
        """Read document bookmark data by its name.
        Args:
            name (str): The document name. (required)

            bookmarkName (str): The bookmark name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: BookmarkResponse
        """

        allParams = dict.fromkeys(['name', 'bookmarkName', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentBookmarkByName" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'bookmarkName' in allParams and allParams['bookmarkName'] is not None:
            resourcePath = resourcePath.replace("{" + "bookmarkName" + "}" , str(allParams['bookmarkName']))
        else:
            resourcePath = re.sub("[&?]bookmarkName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'BookmarkResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentBookmarks(self, name, **kwargs):
        """Read document bookmarks common info.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: BookmarksResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentBookmarks" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/bookmarks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'BookmarksResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostUpdateDocumentBookmark(self, name, bookmarkName, body, **kwargs):
        """Update document bookmark.
        Args:
            name (str): The document name. (required)

            bookmarkName (str): The bookmark name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (BookmarkData): with new bookmark data. (required)

            

        Returns: BookmarkResponse
        """

        allParams = dict.fromkeys(['name', 'bookmarkName', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostUpdateDocumentBookmark" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/bookmarks/{bookmarkName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'bookmarkName' in allParams and allParams['bookmarkName'] is not None:
            resourcePath = resourcePath.replace("{" + "bookmarkName" + "}" , str(allParams['bookmarkName']))
        else:
            resourcePath = re.sub("[&?]bookmarkName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'BookmarkResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocument(self, name, **kwargs):
        """RRead document common info.
        Args:
            name (str): The file name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentWithFormat(self, name, format, **kwargs):
        """Export the document into the specified format.
        Args:
            name (str): The file name. (required)

            format (str): The destination format. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            outPath (str): Path to save result (optional)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['name', 'format', 'storage', 'folder', 'outPath'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentWithFormat" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}&amp;outPath={outPath}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'format' in allParams and allParams['format'] is not None:
            resourcePath = resourcePath.replace("{" + "format" + "}" , str(allParams['format']))
        else:
            resourcePath = re.sub("[&?]format.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'outPath' in allParams and allParams['outPath'] is not None:
            resourcePath = resourcePath.replace("{" + "outPath" + "}" , str(allParams['outPath']))
        else:
            resourcePath = re.sub("[&?]outPath.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostAppendDocument(self, name, body, **kwargs):
        """Append documents to original document.
        Args:
            name (str): Original document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): Original document storage. (optional)

            folder (str): Original document folder. (optional)

            body (DocumentEntryList): with a list of documents to append. (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostAppendDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/appendDocument/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostExecuteTemplate(self, name, file, **kwargs):
        """Populate document template with data.
        Args:
            name (str): The template document name. (required)

            cleanup (str): Clean up options. (optional)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            useWholeParagraphAsRegion (bool): Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.              The default value is true. (optional)

            withRegions (bool): Merge with regions or not. True by default (optional)

            file (File):  (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'cleanup', 'filename', 'storage', 'folder', 'useWholeParagraphAsRegion', 'withRegions', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostExecuteTemplate" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'cleanup' in allParams and allParams['cleanup'] is not None:
            resourcePath = resourcePath.replace("{" + "cleanup" + "}" , str(allParams['cleanup']))
        else:
            resourcePath = re.sub("[&?]cleanup.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'useWholeParagraphAsRegion' in allParams and allParams['useWholeParagraphAsRegion'] is not None:
            resourcePath = resourcePath.replace("{" + "useWholeParagraphAsRegion" + "}" , str(allParams['useWholeParagraphAsRegion']))
        else:
            resourcePath = re.sub("[&?]useWholeParagraphAsRegion.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'withRegions' in allParams and allParams['withRegions'] is not None:
            resourcePath = resourcePath.replace("{" + "withRegions" + "}" , str(allParams['withRegions']))
        else:
            resourcePath = re.sub("[&?]withRegions.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostInsertPageNumbers(self, name, body, **kwargs):
        """Insert document page numbers.
        Args:
            name (str): A document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (PageNumber): with the page numbers settings. (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostInsertPageNumbers" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/insertPageNumbers/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostLoadWebDocument(self, body, **kwargs):
        """Load new document from web into the file with any supported format of data.
        Args:
            
        body (LoadWebDocumentData): The property with new value. (required)
        
        Returns: SaveResponse
        """

        allParams = dict.fromkeys([])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostLoadWebDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/loadWebDocument/?appSid={appSid}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaveResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostRunTask(self, **kwargs):
        """Run tasks
        Args:
            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys([])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostRunTask" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/tasks/?appSid={appSid}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostSplitDocument(self, name, **kwargs):
        """Split document.
        Args:
            name (str): Original document name. (required)

            format (str): Format to split. (optional)

            ffrom (int): Start page. (optional)

            to (int): End page. (optional)

            zipOutput (bool): ZipOutput or not. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SplitDocumentResponse
        """

        allParams = dict.fromkeys(['name', 'format', 'ffrom', 'to', 'zipOutput', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostSplitDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/split/?appSid={appSid}&amp;toFormat={toFormat}&amp;from={from}&amp;to={to}&amp;zipOutput={zipOutput}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'format' in allParams and allParams['format'] is not None:
            resourcePath = resourcePath.replace("{" + "format" + "}" , str(allParams['format']))
        else:
            resourcePath = re.sub("[&?]format.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'ffrom' in allParams and allParams['ffrom'] is not None:
            resourcePath = resourcePath.replace("{" + "from" + "}" , str(allParams['ffrom']))
        else:
            resourcePath = re.sub("[&?]from.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'to' in allParams and allParams['to'] is not None:
            resourcePath = resourcePath.replace("{" + "to" + "}" , str(allParams['to']))
        else:
            resourcePath = re.sub("[&?]to.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'zipOutput' in allParams and allParams['zipOutput'] is not None:
            resourcePath = resourcePath.replace("{" + "zipOutput" + "}" , str(allParams['zipOutput']))
        else:
            resourcePath = re.sub("[&?]zipOutput.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SplitDocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutConvertDocument(self, file, **kwargs):
        """Convert document from request content to format specified.
        Args:
            format (str): Format to convert. (optional)

            outPath (str):  (optional)

            file (File):  (required)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['format', 'outPath', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutConvertDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/convert/?appSid={appSid}&amp;toFormat={toFormat}&amp;outPath={outPath}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'format' in allParams and allParams['format'] is not None:
            resourcePath = resourcePath.replace("{" + "format" + "}" , str(allParams['format']))
        else:
            resourcePath = re.sub("[&?]format.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'outPath' in allParams and allParams['outPath'] is not None:
            resourcePath = resourcePath.replace("{" + "outPath" + "}" , str(allParams['outPath']))
        else:
            resourcePath = re.sub("[&?]outPath.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutDocumentFieldNames(self, **kwargs):
        """Read document field names.
        Args:
            useNonMergeFields (bool):  (optional)

            

        Returns: FieldNamesResponse
        """

        allParams = dict.fromkeys(['useNonMergeFields'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutDocumentFieldNames" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'useNonMergeFields' in allParams and allParams['useNonMergeFields'] is not None:
            resourcePath = resourcePath.replace("{" + "useNonMergeFields" + "}" , str(allParams['useNonMergeFields']))
        else:
            resourcePath = re.sub("[&?]useNonMergeFields.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FieldNamesResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutExecuteMailMergeOnline(self, withRegions, file, **kwargs):
        """Execute document mail merge online.
        Args:
            withRegions (bool): With regions flag. (required)

            cleanup (str): Clean up options. (optional)

            file (File):  (required)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['withRegions', 'cleanup', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutExecuteMailMergeOnline" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/executeMailMerge/?withRegions={withRegions}&amp;appSid={appSid}&amp;cleanup={cleanup}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'withRegions' in allParams and allParams['withRegions'] is not None:
            resourcePath = resourcePath.replace("{" + "withRegions" + "}" , str(allParams['withRegions']))
        else:
            resourcePath = re.sub("[&?]withRegions.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'cleanup' in allParams and allParams['cleanup'] is not None:
            resourcePath = resourcePath.replace("{" + "cleanup" + "}" , str(allParams['cleanup']))
        else:
            resourcePath = re.sub("[&?]cleanup.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutExecuteTemplateOnline(self, file, **kwargs):
        """Populate document template with data online.
        Args:
            cleanup (str): Clean up options. (optional)

            useWholeParagraphAsRegion (bool): Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.             The default value is true. (optional)

            withRegions (bool): Merge with regions or not. True by default (optional)

            file (File):  (required)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['cleanup', 'useWholeParagraphAsRegion', 'withRegions', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutExecuteTemplateOnline" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/executeTemplate/?appSid={appSid}&amp;cleanup={cleanup}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}&amp;withRegions={withRegions}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'cleanup' in allParams and allParams['cleanup'] is not None:
            resourcePath = resourcePath.replace("{" + "cleanup" + "}" , str(allParams['cleanup']))
        else:
            resourcePath = re.sub("[&?]cleanup.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'useWholeParagraphAsRegion' in allParams and allParams['useWholeParagraphAsRegion'] is not None:
            resourcePath = resourcePath.replace("{" + "useWholeParagraphAsRegion" + "}" , str(allParams['useWholeParagraphAsRegion']))
        else:
            resourcePath = re.sub("[&?]useWholeParagraphAsRegion.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'withRegions' in allParams and allParams['withRegions'] is not None:
            resourcePath = resourcePath.replace("{" + "withRegions" + "}" , str(allParams['withRegions']))
        else:
            resourcePath = re.sub("[&?]withRegions.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteDocumentFields(self, name, **kwargs):
        """Remove fields from document.
        Args:
            name (str): The file name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteDocumentFields" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostUpdateDocumentFields(self, name, **kwargs):
        """Update (reevaluate) fields in document.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostUpdateDocumentFields" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/updateFields/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteDocumentProperty(self, name, propertyName, **kwargs):
        """Delete document property.
        Args:
            name (str): The document name. (required)

            propertyName (str): The property name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): Document's storage. (optional)

            folder (str): Document's folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'propertyName', 'filename', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteDocumentProperty" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'propertyName' in allParams and allParams['propertyName'] is not None:
            resourcePath = resourcePath.replace("{" + "propertyName" + "}" , str(allParams['propertyName']))
        else:
            resourcePath = re.sub("[&?]propertyName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentProperties(self, name, **kwargs):
        """Read document properties info.
        Args:
            name (str): The document's name. (required)

            storage (str): The document's storage. (optional)

            folder (str): The document's folder. (optional)

            

        Returns: DocumentPropertiesResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentProperties" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/documentProperties/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentPropertiesResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentProperty(self, name, propertyName, **kwargs):
        """Read document property info by the property name.
        Args:
            name (str): The document name. (required)

            propertyName (str): The property name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: DocumentPropertyResponse
        """

        allParams = dict.fromkeys(['name', 'propertyName', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentProperty" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'propertyName' in allParams and allParams['propertyName'] is not None:
            resourcePath = resourcePath.replace("{" + "propertyName" + "}" , str(allParams['propertyName']))
        else:
            resourcePath = re.sub("[&?]propertyName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentPropertyResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutUpdateDocumentProperty(self, name, propertyName, body, **kwargs):
        """Add new or update existing document property.
        Args:
            name (str): The document name. (required)

            propertyName (str): The property name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): Document's storage. (optional)

            folder (str): Document's folder. (optional)

            body (DocumentProperty): The property with new value. (required)

            

        Returns: DocumentPropertyResponse
        """

        allParams = dict.fromkeys(['name', 'propertyName', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutUpdateDocumentProperty" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/documentProperties/{propertyName}/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'propertyName' in allParams and allParams['propertyName'] is not None:
            resourcePath = resourcePath.replace("{" + "propertyName" + "}" , str(allParams['propertyName']))
        else:
            resourcePath = re.sub("[&?]propertyName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentPropertyResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteUnprotectDocument(self, name, body, **kwargs):
        """Unprotect document.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (ProtectionRequest): with protection settings. (required)

            

        Returns: ProtectionDataResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteUnprotectDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ProtectionDataResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentProtection(self, name, **kwargs):
        """Read document protection common info.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: ProtectionDataResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentProtection" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/protection/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ProtectionDataResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostChangeDocumentProtection(self, name, body, **kwargs):
        """Change document protection.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (ProtectionRequest): with protection settings. (required)

            

        Returns: ProtectionDataResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostChangeDocumentProtection" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ProtectionDataResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutProtectDocument(self, name, body, **kwargs):
        """Protect document.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (ProtectionRequest): with protection settings. (required)

            

        Returns: ProtectionDataResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutProtectDocument" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/protection/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ProtectionDataResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostDocumentSaveAs(self, name, body, **kwargs):
        """Convert document to tiff with detailed settings and save result to storage.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (SaveOptionsData): Save options. (required)

            

        Returns: SaveResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostDocumentSaveAs" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/SaveAs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaveResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutDocumentSaveAsTiff(self, name, body, **kwargs):
        """Convert document to tiff with detailed settings and save result to storage.
        Args:
            name (str): The document name. (required)

            resultFile (str): The resulting file name. (optional)

            useAntiAliasing (bool): Use antialiasing flag. (optional)

            useHighQualityRendering (bool): Use high quality flag. (optional)

            imageBrightness (float): Brightness for the generated images. (optional)

            imageColorMode (str): Color mode for the generated images. (optional)

            imageContrast (float): The contrast for the generated images. (optional)

            numeralFormat (str): The images numeral format. (optional)

            pageCount (int): Number of pages to render. (optional)

            pageIndex (int): Page index to start rendering. (optional)

            paperColor (str): Background image color. (optional)

            pixelFormat (str): The pixel format of generated images. (optional)

            resolution (float): The resolution of generated images. (optional)

            scale (float): Zoom factor for generated images. (optional)

            tiffCompression (str): The compression tipe. (optional)

            dmlRenderingMode (str): Optional, default is Fallback. (optional)

            dmlEffectsRenderingMode (str): Optional, default is Simplified. (optional)

            tiffBinarizationMethod (str): Optional, Tiff binarization method, possible values are: FloydSteinbergDithering, Threshold. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            zipOutput (bool): Optional. A value determining zip output or not. (optional)

            body (TiffSaveOptionsData): Tiff save options. (required)

            

        Returns: SaveResponse
        """

        allParams = dict.fromkeys(['name', 'resultFile', 'useAntiAliasing', 'useHighQualityRendering', 'imageBrightness', 'imageColorMode', 'imageContrast', 'numeralFormat', 'pageCount', 'pageIndex', 'paperColor', 'pixelFormat', 'resolution', 'scale', 'tiffCompression', 'dmlRenderingMode', 'dmlEffectsRenderingMode', 'tiffBinarizationMethod', 'storage', 'folder', 'zipOutput', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutDocumentSaveAsTiff" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/SaveAs/tiff/?appSid={appSid}&amp;resultFile={resultFile}&amp;useAntiAliasing={useAntiAliasing}&amp;useHighQualityRendering={useHighQualityRendering}&amp;imageBrightness={imageBrightness}&amp;imageColorMode={imageColorMode}&amp;imageContrast={imageContrast}&amp;numeralFormat={numeralFormat}&amp;pageCount={pageCount}&amp;pageIndex={pageIndex}&amp;paperColor={paperColor}&amp;pixelFormat={pixelFormat}&amp;resolution={resolution}&amp;scale={scale}&amp;tiffCompression={tiffCompression}&amp;dmlRenderingMode={dmlRenderingMode}&amp;dmlEffectsRenderingMode={dmlEffectsRenderingMode}&amp;tiffBinarizationMethod={tiffBinarizationMethod}&amp;storage={storage}&amp;folder={folder}&amp;zipOutput={zipOutput}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'resultFile' in allParams and allParams['resultFile'] is not None:
            resourcePath = resourcePath.replace("{" + "resultFile" + "}" , str(allParams['resultFile']))
        else:
            resourcePath = re.sub("[&?]resultFile.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'useAntiAliasing' in allParams and allParams['useAntiAliasing'] is not None:
            resourcePath = resourcePath.replace("{" + "useAntiAliasing" + "}" , str(allParams['useAntiAliasing']))
        else:
            resourcePath = re.sub("[&?]useAntiAliasing.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'useHighQualityRendering' in allParams and allParams['useHighQualityRendering'] is not None:
            resourcePath = resourcePath.replace("{" + "useHighQualityRendering" + "}" , str(allParams['useHighQualityRendering']))
        else:
            resourcePath = re.sub("[&?]useHighQualityRendering.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'imageBrightness' in allParams and allParams['imageBrightness'] is not None:
            resourcePath = resourcePath.replace("{" + "imageBrightness" + "}" , str(allParams['imageBrightness']))
        else:
            resourcePath = re.sub("[&?]imageBrightness.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'imageColorMode' in allParams and allParams['imageColorMode'] is not None:
            resourcePath = resourcePath.replace("{" + "imageColorMode" + "}" , str(allParams['imageColorMode']))
        else:
            resourcePath = re.sub("[&?]imageColorMode.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'imageContrast' in allParams and allParams['imageContrast'] is not None:
            resourcePath = resourcePath.replace("{" + "imageContrast" + "}" , str(allParams['imageContrast']))
        else:
            resourcePath = re.sub("[&?]imageContrast.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'numeralFormat' in allParams and allParams['numeralFormat'] is not None:
            resourcePath = resourcePath.replace("{" + "numeralFormat" + "}" , str(allParams['numeralFormat']))
        else:
            resourcePath = re.sub("[&?]numeralFormat.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'pageCount' in allParams and allParams['pageCount'] is not None:
            resourcePath = resourcePath.replace("{" + "pageCount" + "}" , str(allParams['pageCount']))
        else:
            resourcePath = re.sub("[&?]pageCount.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'pageIndex' in allParams and allParams['pageIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "pageIndex" + "}" , str(allParams['pageIndex']))
        else:
            resourcePath = re.sub("[&?]pageIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'paperColor' in allParams and allParams['paperColor'] is not None:
            resourcePath = resourcePath.replace("{" + "paperColor" + "}" , str(allParams['paperColor']))
        else:
            resourcePath = re.sub("[&?]paperColor.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'pixelFormat' in allParams and allParams['pixelFormat'] is not None:
            resourcePath = resourcePath.replace("{" + "pixelFormat" + "}" , str(allParams['pixelFormat']))
        else:
            resourcePath = re.sub("[&?]pixelFormat.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'resolution' in allParams and allParams['resolution'] is not None:
            resourcePath = resourcePath.replace("{" + "resolution" + "}" , str(allParams['resolution']))
        else:
            resourcePath = re.sub("[&?]resolution.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'scale' in allParams and allParams['scale'] is not None:
            resourcePath = resourcePath.replace("{" + "scale" + "}" , str(allParams['scale']))
        else:
            resourcePath = re.sub("[&?]scale.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'tiffCompression' in allParams and allParams['tiffCompression'] is not None:
            resourcePath = resourcePath.replace("{" + "tiffCompression" + "}" , str(allParams['tiffCompression']))
        else:
            resourcePath = re.sub("[&?]tiffCompression.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'dmlRenderingMode' in allParams and allParams['dmlRenderingMode'] is not None:
            resourcePath = resourcePath.replace("{" + "dmlRenderingMode" + "}" , str(allParams['dmlRenderingMode']))
        else:
            resourcePath = re.sub("[&?]dmlRenderingMode.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'dmlEffectsRenderingMode' in allParams and allParams['dmlEffectsRenderingMode'] is not None:
            resourcePath = resourcePath.replace("{" + "dmlEffectsRenderingMode" + "}" , str(allParams['dmlEffectsRenderingMode']))
        else:
            resourcePath = re.sub("[&?]dmlEffectsRenderingMode.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'tiffBinarizationMethod' in allParams and allParams['tiffBinarizationMethod'] is not None:
            resourcePath = resourcePath.replace("{" + "tiffBinarizationMethod" + "}" , str(allParams['tiffBinarizationMethod']))
        else:
            resourcePath = re.sub("[&?]tiffBinarizationMethod.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'zipOutput' in allParams and allParams['zipOutput'] is not None:
            resourcePath = resourcePath.replace("{" + "zipOutput" + "}" , str(allParams['zipOutput']))
        else:
            resourcePath = re.sub("[&?]zipOutput.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaveResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentStatistics(self, name, **kwargs):
        """Read document statistics.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: StatDataResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentStatistics" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/statistics/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'StatDataResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteDocumentWatermark(self, name, **kwargs):
        """Delete watermark (for deleting last watermark from the document).
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteDocumentWatermark" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/watermark/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostInsertDocumentWatermarkImage(self, name, file, **kwargs):
        """Insert document watermark image.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            rotationAngle (float): The watermark rotation angle. (optional)

            image (str): The image file server full name. If the name is empty the image is expected in request content. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            file (File):  (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'rotationAngle', 'image', 'storage', 'folder', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostInsertDocumentWatermarkImage" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/watermark/insertImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'rotationAngle' in allParams and allParams['rotationAngle'] is not None:
            resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , str(allParams['rotationAngle']))
        else:
            resourcePath = re.sub("[&?]rotationAngle.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'image' in allParams and allParams['image'] is not None:
            resourcePath = resourcePath.replace("{" + "image" + "}" , str(allParams['image']))
        else:
            resourcePath = re.sub("[&?]image.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostInsertDocumentWatermarkText(self, name, body, **kwargs):
        """Insert document watermark text.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            text (str): The text to insert. (optional)

            rotationAngle (float): The text rotation angle. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (WatermarkText): with the watermark data.            If the parameter is provided the query string parameters are ignored. (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'text', 'rotationAngle', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostInsertDocumentWatermarkText" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/watermark/insertText/?appSid={appSid}&amp;filename={filename}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'text' in allParams and allParams['text'] is not None:
            resourcePath = resourcePath.replace("{" + "text" + "}" , str(allParams['text']))
        else:
            resourcePath = re.sub("[&?]text.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'rotationAngle' in allParams and allParams['rotationAngle'] is not None:
            resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , str(allParams['rotationAngle']))
        else:
            resourcePath = re.sub("[&?]rotationAngle.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentDrawingObjectByIndex(self, name, objectIndex, **kwargs):
        """Read document drawing object common info by its index or convert to format specified.
        Args:
            name (str): The document name. (required)

            objectIndex (int): The drawing object index. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder full path. (optional)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['name', 'objectIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentDrawingObjectByIndex" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'objectIndex' in allParams and allParams['objectIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "objectIndex" + "}" , str(allParams['objectIndex']))
        else:
            resourcePath = re.sub("[&?]objectIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentDrawingObjectByIndexWithFormat(self, name, objectIndex, format, **kwargs):
        """Read document drawing object common info by its index or convert to format specified.
        Args:
            name (str): The document name. (required)

            objectIndex (int): The drawing object index. (required)

            format (str): The format to convert (if specified). (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder full path. (optional)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['name', 'objectIndex', 'format', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentDrawingObjectByIndexWithFormat" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/drawingObjects/{objectIndex}/?appSid={appSid}&amp;toFormat={toFormat}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'objectIndex' in allParams and allParams['objectIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "objectIndex" + "}" , str(allParams['objectIndex']))
        else:
            resourcePath = re.sub("[&?]objectIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'format' in allParams and allParams['format'] is not None:
            resourcePath = resourcePath.replace("{" + "format" + "}" , str(allParams['format']))
        else:
            resourcePath = re.sub("[&?]format.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentDrawingObjectImageData(self, name, objectIndex, **kwargs):
        """Read drawing object image data.
        Args:
            name (str): The document name. (required)

            objectIndex (int): The drawing object index. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['name', 'objectIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentDrawingObjectImageData" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/drawingObjects/{objectIndex}/imageData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'objectIndex' in allParams and allParams['objectIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "objectIndex" + "}" , str(allParams['objectIndex']))
        else:
            resourcePath = re.sub("[&?]objectIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentDrawingObjectOleData(self, name, objectIndex, **kwargs):
        """Get drawing object OLE data.
        Args:
            name (str): The document name. (required)

            objectIndex (int): The object index. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: ResponseMessage
        """

        allParams = dict.fromkeys(['name', 'objectIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentDrawingObjectOleData" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/drawingObjects/{objectIndex}/oleData/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'objectIndex' in allParams and allParams['objectIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "objectIndex" + "}" , str(allParams['objectIndex']))
        else:
            resourcePath = re.sub("[&?]objectIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/octet-stream'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ResponseMessage', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentDrawingObjects(self, name, **kwargs):
        """Read document drawing objects common info.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: DrawingObjectsResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentDrawingObjects" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/drawingObjects/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DrawingObjectsResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteFormField(self, name, sectionIndex, paragraphIndex, formfieldIndex, **kwargs):
        """Removes form field from document.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index. (required)

            paragraphIndex (int): Paragraph index. (required)

            formfieldIndex (int): Form field index. (required)

            destFileName (str): Destination file name. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'paragraphIndex', 'formfieldIndex', 'destFileName', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteFormField" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'paragraphIndex' in allParams and allParams['paragraphIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}" , str(allParams['paragraphIndex']))
        else:
            resourcePath = re.sub("[&?]paragraphIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'formfieldIndex' in allParams and allParams['formfieldIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "formfieldIndex" + "}" , str(allParams['formfieldIndex']))
        else:
            resourcePath = re.sub("[&?]formfieldIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'destFileName' in allParams and allParams['destFileName'] is not None:
            resourcePath = resourcePath.replace("{" + "destFileName" + "}" , str(allParams['destFileName']))
        else:
            resourcePath = re.sub("[&?]destFileName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetFormField(self, name, sectionIndex, paragraphIndex, formfieldIndex, **kwargs):
        """Returns representation of an one of the form field.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index. (required)

            paragraphIndex (int): Paragraph index. (required)

            formfieldIndex (int): Form field index. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: FormFieldResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'paragraphIndex', 'formfieldIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetFormField" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'paragraphIndex' in allParams and allParams['paragraphIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}" , str(allParams['paragraphIndex']))
        else:
            resourcePath = re.sub("[&?]paragraphIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'formfieldIndex' in allParams and allParams['formfieldIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "formfieldIndex" + "}" , str(allParams['formfieldIndex']))
        else:
            resourcePath = re.sub("[&?]formfieldIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FormFieldResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostFormField(self, name, sectionIndex, paragraphIndex, formfieldIndex, body, **kwargs):
        """Updates form field's properties, returns updated form field's data.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index. (required)

            paragraphIndex (int): Paragraph index. (required)

            formfieldIndex (int): Form field index. (required)

            destFileName (str): Destination file name. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (FormField): From field data. (required)

            

        Returns: FormFieldResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'paragraphIndex', 'formfieldIndex', 'destFileName', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostFormField" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/{formfieldIndex}/?appSid={appSid}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'paragraphIndex' in allParams and allParams['paragraphIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}" , str(allParams['paragraphIndex']))
        else:
            resourcePath = re.sub("[&?]paragraphIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'formfieldIndex' in allParams and allParams['formfieldIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "formfieldIndex" + "}" , str(allParams['formfieldIndex']))
        else:
            resourcePath = re.sub("[&?]formfieldIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'destFileName' in allParams and allParams['destFileName'] is not None:
            resourcePath = resourcePath.replace("{" + "destFileName" + "}" , str(allParams['destFileName']))
        else:
            resourcePath = re.sub("[&?]destFileName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FormFieldResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PutFormField(self, name, sectionIndex, paragraphIndex, body, **kwargs):
        """Adds form field to paragraph, returns added form field's data.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index. (required)

            paragraphIndex (int): Paragraph index. (required)

            insertBeforeNode (str): Form field will be inserted before node with index. (optional)

            destFileName (str): Destination file name. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (FormField): From field data. (required)

            

        Returns: FormFieldResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'paragraphIndex', 'insertBeforeNode', 'destFileName', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PutFormField" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/formfields/?appSid={appSid}&amp;insertBeforeNode={insertBeforeNode}&amp;destFileName={destFileName}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'paragraphIndex' in allParams and allParams['paragraphIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}" , str(allParams['paragraphIndex']))
        else:
            resourcePath = re.sub("[&?]paragraphIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'insertBeforeNode' in allParams and allParams['insertBeforeNode'] is not None:
            resourcePath = resourcePath.replace("{" + "insertBeforeNode" + "}" , str(allParams['insertBeforeNode']))
        else:
            resourcePath = re.sub("[&?]insertBeforeNode.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'destFileName' in allParams and allParams['destFileName'] is not None:
            resourcePath = resourcePath.replace("{" + "destFileName" + "}" , str(allParams['destFileName']))
        else:
            resourcePath = re.sub("[&?]destFileName.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'PUT'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FormFieldResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteHeadersFooters(self, name, **kwargs):
        """Delete document headers and footers.
        Args:
            name (str): The document name. (required)

            headersFootersTypes (str): List of types of headers and footers. (optional)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'headersFootersTypes', 'filename', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteHeadersFooters" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/headersfooters/?appSid={appSid}&amp;headersFootersTypes={headersFootersTypes}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'headersFootersTypes' in allParams and allParams['headersFootersTypes'] is not None:
            resourcePath = resourcePath.replace("{" + "headersFootersTypes" + "}" , str(allParams['headersFootersTypes']))
        else:
            resourcePath = re.sub("[&?]headersFootersTypes.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentHyperlinkByIndex(self, name, hyperlinkIndex, **kwargs):
        """Read document hyperlink by its index.
        Args:
            name (str): The document name. (required)

            hyperlinkIndex (int): The hyperlink index. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: HyperlinkResponse
        """

        allParams = dict.fromkeys(['name', 'hyperlinkIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentHyperlinkByIndex" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/hyperlinks/{hyperlinkIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'hyperlinkIndex' in allParams and allParams['hyperlinkIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "hyperlinkIndex" + "}" , str(allParams['hyperlinkIndex']))
        else:
            resourcePath = re.sub("[&?]hyperlinkIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'HyperlinkResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentHyperlinks(self, name, **kwargs):
        """Read document hyperlinks common info.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: HyperlinksResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentHyperlinks" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/hyperlinks/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'HyperlinksResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteDocumentMacros(self, name, **kwargs):
        """Remove macros from document.
        Args:
            name (str): The file name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteDocumentMacros" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/macros/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentFieldNames(self, name, **kwargs):
        """Read document field names.
        Args:
            name (str): The document name. (required)

            useNonMergeFields (bool):  (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: FieldNamesResponse
        """

        allParams = dict.fromkeys(['name', 'useNonMergeFields', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentFieldNames" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/mailMergeFieldNames/?appSid={appSid}&amp;useNonMergeFields={useNonMergeFields}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'useNonMergeFields' in allParams and allParams['useNonMergeFields'] is not None:
            resourcePath = resourcePath.replace("{" + "useNonMergeFields" + "}" , str(allParams['useNonMergeFields']))
        else:
            resourcePath = re.sub("[&?]useNonMergeFields.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FieldNamesResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostDocumentExecuteMailMerge(self, name, withRegions, file, **kwargs):
        """Execute document mail merge operation.
        Args:
            name (str): The document name. (required)

            withRegions (bool): With regions flag. (required)

            mailMergeDataFile (str): Mail merge data. (optional)

            cleanup (str): Clean up options. (optional)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            useWholeParagraphAsRegion (bool): Gets or sets a value indicating whether paragraph with TableStart or TableEnd field should be fully included into mail merge region or particular range between TableStart and TableEnd fields.             The default value is true. (optional)

            file (File):  (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'withRegions', 'mailMergeDataFile', 'cleanup', 'filename', 'storage', 'folder', 'useWholeParagraphAsRegion', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostDocumentExecuteMailMerge" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/executeMailMerge/{withRegions}/?appSid={appSid}&amp;mailMergeDataFile={mailMergeDataFile}&amp;cleanup={cleanup}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}&amp;useWholeParagraphAsRegion={useWholeParagraphAsRegion}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'withRegions' in allParams and allParams['withRegions'] is not None:
            resourcePath = resourcePath.replace("{" + "withRegions" + "}" , str(allParams['withRegions']))
        else:
            resourcePath = re.sub("[&?]withRegions.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'mailMergeDataFile' in allParams and allParams['mailMergeDataFile'] is not None:
            resourcePath = resourcePath.replace("{" + "mailMergeDataFile" + "}" , str(allParams['mailMergeDataFile']))
        else:
            resourcePath = re.sub("[&?]mailMergeDataFile.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'cleanup' in allParams and allParams['cleanup'] is not None:
            resourcePath = resourcePath.replace("{" + "cleanup" + "}" , str(allParams['cleanup']))
        else:
            resourcePath = re.sub("[&?]cleanup.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'useWholeParagraphAsRegion' in allParams and allParams['useWholeParagraphAsRegion'] is not None:
            resourcePath = resourcePath.replace("{" + "useWholeParagraphAsRegion" + "}" , str(allParams['useWholeParagraphAsRegion']))
        else:
            resourcePath = re.sub("[&?]useWholeParagraphAsRegion.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteParagraphFields(self, name, index, **kwargs):
        """Remove fields from paragraph.
        Args:
            name (str): The file name. (required)

            index (int): Paragraph index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'index', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteParagraphFields" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/paragraphs/{index}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'index' in allParams and allParams['index'] is not None:
            resourcePath = resourcePath.replace("{" + "index" + "}" , str(allParams['index']))
        else:
            resourcePath = re.sub("[&?]index.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentParagraph(self, name, index, **kwargs):
        """This resource represents one of the paragraphs contained in the document.
        Args:
            name (str): The document name. (required)

            index (int): Paragraph index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: ParagraphResponse
        """

        allParams = dict.fromkeys(['name', 'index', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentParagraph" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/paragraphs/{index}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'index' in allParams and allParams['index'] is not None:
            resourcePath = resourcePath.replace("{" + "index" + "}" , str(allParams['index']))
        else:
            resourcePath = re.sub("[&?]index.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ParagraphResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentParagraphRun(self, name, index, runIndex, **kwargs):
        """This resource represents one of the paragraphs contained in the document.
        Args:
            name (str): The document name. (required)

            index (int): Paragraph index (required)

            runIndex (int): Run index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: RunResponse
        """

        allParams = dict.fromkeys(['name', 'index', 'runIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentParagraphRun" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/paragraphs/{index}/runs/{runIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'index' in allParams and allParams['index'] is not None:
            resourcePath = resourcePath.replace("{" + "index" + "}" , str(allParams['index']))
        else:
            resourcePath = re.sub("[&?]index.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'runIndex' in allParams and allParams['runIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "runIndex" + "}" , str(allParams['runIndex']))
        else:
            resourcePath = re.sub("[&?]runIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'RunResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentParagraphRunFont(self, name, index, runIndex, **kwargs):
        """This resource represents one of the paragraphs contained in the document.
        Args:
            name (str): The document name. (required)

            index (int): Paragraph index (required)

            runIndex (int): Run index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: FontResponse
        """

        allParams = dict.fromkeys(['name', 'index', 'runIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentParagraphRunFont" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'index' in allParams and allParams['index'] is not None:
            resourcePath = resourcePath.replace("{" + "index" + "}" , str(allParams['index']))
        else:
            resourcePath = re.sub("[&?]index.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'runIndex' in allParams and allParams['runIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "runIndex" + "}" , str(allParams['runIndex']))
        else:
            resourcePath = re.sub("[&?]runIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FontResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentParagraphs(self, name, **kwargs):
        """Return a list of paragraphs that are contained in the document.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: ParagraphLinkCollectionResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentParagraphs" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/paragraphs/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ParagraphLinkCollectionResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostDocumentParagraphRunFont(self, name, index, runIndex, body, **kwargs):
        """This resource represents one of the paragraphs contained in the document.
        Args:
            name (str): The document name. (required)

            index (int): Paragraph index (required)

            runIndex (int): Run index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            body (Font): Font dto object (required)

            

        Returns: FontResponse
        """

        allParams = dict.fromkeys(['name', 'index', 'runIndex', 'storage', 'folder', 'filename', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostDocumentParagraphRunFont" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/paragraphs/{index}/runs/{runIndex}/font/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'index' in allParams and allParams['index'] is not None:
            resourcePath = resourcePath.replace("{" + "index" + "}" , str(allParams['index']))
        else:
            resourcePath = re.sub("[&?]index.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'runIndex' in allParams and allParams['runIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "runIndex" + "}" , str(allParams['runIndex']))
        else:
            resourcePath = re.sub("[&?]runIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'FontResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def AcceptAllRevisions(self, name, **kwargs):
        """Accept all revisions in document
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: RevisionsModificationResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method AcceptAllRevisions" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/revisions/acceptAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'RevisionsModificationResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def RejectAllRevisions(self, name, **kwargs):
        """Reject all revisions in document
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: RevisionsModificationResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method RejectAllRevisions" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/revisions/rejectAll/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'RevisionsModificationResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteSectionFields(self, name, sectionIndex, **kwargs):
        """Remove fields from section.
        Args:
            name (str): The file name. (required)

            sectionIndex (int): Section index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteSectionFields" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def DeleteSectionParagraphFields(self, name, sectionIndex, paragraphIndex, **kwargs):
        """Remove fields from section paragraph.
        Args:
            name (str): The file name. (required)

            sectionIndex (int): Section index (required)

            paragraphIndex (int): Paragraph index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SaaSposeResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'paragraphIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method DeleteSectionParagraphFields" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/paragraphs/{paragraphIndex}/fields/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'paragraphIndex' in allParams and allParams['paragraphIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "paragraphIndex" + "}" , str(allParams['paragraphIndex']))
        else:
            resourcePath = re.sub("[&?]paragraphIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'DELETE'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SaaSposeResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetSection(self, name, sectionIndex, **kwargs):
        """Get document section by index.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SectionResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetSection" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
            
        print "resourcePath" + resourcePath

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        
        print "resourcePath" + resourcePath
        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SectionResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetSectionPageSetup(self, name, sectionIndex, **kwargs):
        """Get page setup of section.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SectionPageSetupResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetSectionPageSetup" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SectionPageSetupResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetSections(self, name, **kwargs):
        """Return a list of sections that are contained in the document.
        Args:
            name (str): The document name. (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            

        Returns: SectionLinkCollectionResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetSections" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SectionLinkCollectionResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def UpdateSectionPageSetup(self, name, sectionIndex, body, **kwargs):
        """Update page setup of section.
        Args:
            name (str): The document name. (required)

            sectionIndex (int): Section index (required)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document. (optional)

            body (PageSetup): Page setup properties dto (required)

            

        Returns: SectionPageSetupResponse
        """

        allParams = dict.fromkeys(['name', 'sectionIndex', 'storage', 'folder', 'filename', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method UpdateSectionPageSetup" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/sections/{sectionIndex}/pageSetup/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}&amp;filename={filename}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'sectionIndex' in allParams and allParams['sectionIndex'] is not None:
            resourcePath = resourcePath.replace("{" + "sectionIndex" + "}" , str(allParams['sectionIndex']))
        else:
            resourcePath = re.sub("[&?]sectionIndex.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'SectionPageSetupResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def GetDocumentTextItems(self, name, **kwargs):
        """Read document text items.
        Args:
            name (str): The document name. (required)

            storage (str): Document's storage. (optional)

            folder (str): Document's folder. (optional)

            

        Returns: TextItemsResponse
        """

        allParams = dict.fromkeys(['name', 'storage', 'folder'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method GetDocumentTextItems" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/textItems/?appSid={appSid}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'GET'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'TextItemsResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostReplaceText(self, name, body, **kwargs):
        """Replace document text.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (ReplaceTextRequest): with the replace operation settings. (required)

            

        Returns: ReplaceTextResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostReplaceText" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/replaceText/?appSid={appSid}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'ReplaceTextResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostInsertWatermarkImage(self, name, file, **kwargs):
        """Insert document watermark image.
        Args:
            name (str): The document name. (required)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            rotationAngle (float): The watermark rotation angle. (optional)

            image (str): The image file server full name. If the name is empty the image is expected in request content. (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            file (File):  (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'filename', 'rotationAngle', 'image', 'storage', 'folder', 'file'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostInsertWatermarkImage" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/insertWatermarkImage/?appSid={appSid}&amp;filename={filename}&amp;rotationAngle={rotationAngle}&amp;image={image}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'rotationAngle' in allParams and allParams['rotationAngle'] is not None:
            resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , str(allParams['rotationAngle']))
        else:
            resourcePath = re.sub("[&?]rotationAngle.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'image' in allParams and allParams['image'] is not None:
            resourcePath = resourcePath.replace("{" + "image" + "}" , str(allParams['image']))
        else:
            resourcePath = re.sub("[&?]image.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { 'file':open(file, 'rb')}
        bodyParam = None

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'multipart/form-data'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    def PostInsertWatermarkText(self, name, body, **kwargs):
        """Insert document watermark text.
        Args:
            name (str): The document name. (required)

            text (str): The text to insert. (optional)

            rotationAngle (float): The text rotation angle. (optional)

            filename (str): Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document (optional)

            storage (str): The document storage. (optional)

            folder (str): The document folder. (optional)

            body (WatermarkText): with the watermark data.            If the parameter is provided the query string parameters are ignored. (required)

            

        Returns: DocumentResponse
        """

        allParams = dict.fromkeys(['name', 'text', 'rotationAngle', 'filename', 'storage', 'folder', 'body'])

        params = locals()
        for (key, val) in params['kwargs'].iteritems():
            if key not in allParams:
                raise TypeError("Got an unexpected keyword argument '%s' to method PostInsertWatermarkText" % key)
            params[key] = val
        
        for (key, val) in params.iteritems():
            if key in allParams:
                allParams[key] = val
        
        resourcePath = '/words/{name}/insertWatermarkText/?appSid={appSid}&amp;text={text}&amp;rotationAngle={rotationAngle}&amp;filename={filename}&amp;storage={storage}&amp;folder={folder}'
        
    
        resourcePath = resourcePath.replace('&amp;','&').replace("/?","?").replace("toFormat={toFormat}","format={format}").replace("{path}","{Path}")

        if 'name' in allParams and allParams['name'] is not None:
            resourcePath = resourcePath.replace("{" + "name" + "}" , str(allParams['name']))
        else:
            resourcePath = re.sub("[&?]name.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'text' in allParams and allParams['text'] is not None:
            resourcePath = resourcePath.replace("{" + "text" + "}" , str(allParams['text']))
        else:
            resourcePath = re.sub("[&?]text.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'rotationAngle' in allParams and allParams['rotationAngle'] is not None:
            resourcePath = resourcePath.replace("{" + "rotationAngle" + "}" , str(allParams['rotationAngle']))
        else:
            resourcePath = re.sub("[&?]rotationAngle.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'filename' in allParams and allParams['filename'] is not None:
            resourcePath = resourcePath.replace("{" + "filename" + "}" , str(allParams['filename']))
        else:
            resourcePath = re.sub("[&?]filename.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'storage' in allParams and allParams['storage'] is not None:
            resourcePath = resourcePath.replace("{" + "storage" + "}" , str(allParams['storage']))
        else:
            resourcePath = re.sub("[&?]storage.*?(?=&|\\?|$)", "", resourcePath)
        

        if 'folder' in allParams and allParams['folder'] is not None:
            resourcePath = resourcePath.replace("{" + "folder" + "}" , str(allParams['folder']))
        else:
            resourcePath = re.sub("[&?]folder.*?(?=&|\\?|$)", "", resourcePath)
        

        method = 'POST'
        queryParams = {}
        headerParams = {}
        formParams = {}
        files = { }
        bodyParam = body

        headerParams['Accept'] = 'application/xml,application/json'
        headerParams['Content-Type'] = 'application/json'

        postData = (formParams if formParams else bodyParam)

        response =  self.apiClient.callAPI(resourcePath, method, queryParams, postData, headerParams, files=files)

        try:
            if response.status_code in [200,201,202]:
                responseObject = self.apiClient.pre_deserialize(response.content, 'DocumentResponse', response.headers['content-type'])
                return responseObject
            else:
                raise ApiException(response.status_code,response.content)
        except Exception:
            raise ApiException(response.status_code,response.content)

        

        

    




