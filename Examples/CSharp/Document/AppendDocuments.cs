//////////////////////////////////////////////////////////////////////////
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
    class AppendDocuments
    {
       public static void Run()
        {           
            string storagefile = "doc-sample.doc";
            string inputfile1 = "doc-sample1.doc";
            string inputfile2 = "doc-sample2.doc";           

            // Upload input files from local directory to Cloud Storage
            Common.UploadFile(storagefile, string.Empty);
            Common.UploadFile(inputfile1, string.Empty);
            Common.UploadFile(inputfile2, string.Empty);
           
            // Append a List of Word Documents
            WordDocumentEntryRequest wordDocumentEntryRequest = new WordDocumentEntryRequest();
            wordDocumentEntryRequest.DocumentEntries.Add(new WordDocumentEntry(inputfile1, WordImportFormatMode.KeepSourceFormatting));
            wordDocumentEntryRequest.DocumentEntries.Add(new WordDocumentEntry(inputfile2, WordImportFormatMode.KeepSourceFormatting));
            Common.WordsService.SplitDocument(storagefile, SplitDocumentFormat.Jpeg, 1, 2, Common.FOLDER);

            /// <summary>
            /// Append Documents to Original Document.
            /// </summary>
            /// <param name="name">file name</param>
            /// <param name="wordDocumentEntryRequest">List of Word documents.</param>
            /// <param name="filename">Path to save result. Must be a Cloud storage path e.g. MyFolder\out.doc</param>
            /// <param name="folder">Folder name on Cloud storage e.g. MyFolder. Empty means files will be uploaded on Default Cloud storage</param>
            WordsDocumentResponse wordsDocumentResponse = Common.WordsService.AppendDocumentsToOriginalDocument(storagefile, wordDocumentEntryRequest, Common.GetOutputFilePath(storagefile, true), Common.FOLDER);

            // Download appended document file from cloud storage and save it to local directory
            string dataDir = Common.DownloadFile(storagefile, string.Empty);

            Console.WriteLine("\nDocuments appended successfully.\nFile saved at " + dataDir);
        }
    }
}
