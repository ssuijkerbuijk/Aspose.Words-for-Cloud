namespace BddTest.Base
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Api;
    using Aspose.Words.Cloud.Sdk.Requests;

    using Com.Aspose.Storage.Api;

    /// <summary>
    /// This is a context for conversion operation
    /// </summary>
    public class ConversionContext : IDisposable
    {
        private const string BaseProductUri = @"http://api-dev.aspose.cloud/v1.1";
        private const string AppSID = "78b637f6-b4cc-41de-a619-d8bd9fc2b6b6";
        private const string AppKey = "3d588eb82b3d5a634ad3141f09b03629";

        private const string Folder = "TempSDKTests/";
        private WordsApi methodsApi;

        private StorageApi storageApi;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionContext"/> class.
        /// </summary>
        public ConversionContext()
        {
            this.methodsApi = new WordsApi(AppKey, AppSID, BaseProductUri);
            this.storageApi = new StorageApi(AppKey, AppSID, BaseProductUri);
        }

        /// <summary>
        /// File we want to convert
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Format of document we want to get
        /// </summary>
        public string OutputFormat { get; set; }

        /// <summary>
        /// Path for output
        /// </summary>
        public string OutPath { get; set; }

        /// <summary>
        /// Encoding for document
        /// </summary>
        public string LoadEncoding { get; set; }

        /// <summary>
        /// Document in output format
        /// </summary>
        public MemoryStream ConvertedDocument { get; private set; }

        /// <summary>
        /// Converts document from attachment
        /// </summary>
        public void ConvertDocumentFormAttachment()
        {
            var path = DirectoryHelper.GetTestDataPath();
            using (var fileStream = System.IO.File.OpenRead(Path.Combine(path, this.FileName)))
            {
                this.ConvertDocumentFromAttachment(this.OutputFormat, fileStream);
            }
        }

        /// <summary>
        /// Executes document conversion to specified format
        /// </summary>
        /// <param name="documentName">the name of a document on storage</param>
        public void ConvertDocumentFromStorage(string documentName)
        {
            var fullPath = Folder + documentName;
            var resp = this.storageApi.GetDownload(fullPath, null, null);
            var request = new PutConvertDocumentRequest(this.OutputFormat, new MemoryStream(resp.ResponseStream));
            this.ConvertedDocument =
                (MemoryStream)this.methodsApi.PutConvertDocument(request);
        }

        /// <summary>
        /// Saves converted document to specified storage
        /// </summary>
        /// <remarks>Document will save with name specified in <see cref="OutPath"/></remarks>
        public void SaveConvertedDocumentToStorage()
        {
            this.storageApi.PutCreate(
                Folder + this.OutPath,
                string.Empty,
                string.Empty,
                this.ConvertedDocument.ToArray());
        }

        /// <summary>
        /// Uploads document to storage
        /// </summary>
        public void UploadDocumentToStorage()
        {
            this.storageApi.PutCreate(
                Folder + this.FileName,
                null,
                null,
                File.ReadAllBytes(Path.Combine(DirectoryHelper.GetTestDataPath(), this.FileName)));
        }

        /// <summary>
        /// Is document with this name exist
        /// </summary>
        /// <param name="name">document name</param>
        /// <returns>is exist</returns>
        public bool? FileWithNameExists(string name)
        {
            return this.storageApi.GetIsExist(Folder + this.OutPath, null, null)?.FileExist?.IsExist;
        }

        /// <summary>
        /// Conversion with encoding
        /// </summary>
        public void ConversionWithEncoding()
        {
            var request = new GetDocumentWithFormatRequest(this.FileName, this.OutputFormat, this.OutPath, null, Folder, this.LoadEncoding);
            this.ConvertedDocument =
                (MemoryStream)this.methodsApi.GetDocumentWithFormat(request);
        }

        /// <summary>
        /// Release stream's resources
        /// </summary>
        public void Dispose()
        {
            this.ConvertedDocument.Close();
        }

        /// <summary>
        /// Executes document conversion to specified format
        /// </summary>
        /// <param name="format">format to convert</param>
        /// <param name="document">attached document</param>
        private void ConvertDocumentFromAttachment(
            string format,
            Stream document)
        {
            var request = new PutConvertDocumentRequest(format, document);
            this.ConvertedDocument = (MemoryStream)this.methodsApi.PutConvertDocument(request);
        }
    }
}