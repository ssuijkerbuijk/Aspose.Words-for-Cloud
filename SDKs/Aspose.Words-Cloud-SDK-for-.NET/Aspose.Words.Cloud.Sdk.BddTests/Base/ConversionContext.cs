namespace Aspose.Words.Cloud.Sdk.BddTests.Base
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Requests;

    /// <summary>
    /// This class contains implementation of all required operations for document conversion
    /// </summary>
    public class ConversionContext : BaseContext
    {
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
            using (var fileStream = System.IO.File.OpenRead(Path.Combine(this.TestDataPath, this.FileName)))
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
            var fullPath = this.Folder + documentName;
            var resp = this.StorageApi.GetDownload(fullPath, null, null);
            var request = new PutConvertDocumentRequest(this.OutputFormat, new MemoryStream(resp.ResponseStream));
            this.ConvertedDocument =
                (MemoryStream)this.MethodsApi.PutConvertDocument(request);
        }

        /// <summary>
        /// Saves converted document to specified storage
        /// </summary>
        /// <remarks>Document will save with name specified in <see cref="OutPath"/></remarks>
        public void SaveConvertedDocumentToStorage()
        {
            this.StorageApi.PutCreate(
                this.Folder + this.OutPath,
                string.Empty,
                string.Empty,
                this.ConvertedDocument.ToArray());
        }

        /// <summary>
        /// Is document with this name exist
        /// </summary>
        /// <param name="name">document name</param>
        /// <returns>is exist</returns>
        public bool? FileWithNameExists(string name)
        {
            var isExists = this.StorageApi.GetIsExist(this.Folder + this.OutPath, null, null);
            if (isExists != null 
                && isExists.FileExist != null)
            {
                return isExists.FileExist.IsExist;
            }

            return null;
        }

        /// <summary>
        /// Conversion with encoding
        /// </summary>
        public void ConversionWithEncoding()
        {
            var request = new GetDocumentWithFormatRequest(this.FileName, this.OutputFormat, this.OutPath, null, this.Folder, this.LoadEncoding);
            this.ConvertedDocument =
                (MemoryStream)this.MethodsApi.GetDocumentWithFormat(request);
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
            this.ConvertedDocument = (MemoryStream)this.MethodsApi.PutConvertDocument(request);
        }
    }
}