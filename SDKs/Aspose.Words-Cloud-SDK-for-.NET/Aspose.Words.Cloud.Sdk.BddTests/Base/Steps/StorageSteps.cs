namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for working with storage.
    /// </summary>
    [Binding]
    public class StorageSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected StorageSteps(BaseContext context)
        {
            this.context = context;
        }

        private ICanSpecifyOutputFormatRequest Request
        {
            get { return ScenarioContext.Current["Request"] as ICanSpecifyOutputFormatRequest; }
        }

        /// <summary>
        /// Uploads specified document to storage
        /// </summary>
        /// <param name="fileName">document name</param>
        [Given(@"I have uploaded document with name (.*) to storage")]
        public void GivenIHaveUploadedDocumentWithNameToStorage(string fileName)
        {
            this.context.StorageApi.PutCreate(
               this.context.TestFolderInStorage + fileName,
               null,
               null,
               File.ReadAllBytes(Path.Combine(this.context.TestDataPath, fileName)));
        }

        /// <summary>
        /// Check if file with the name exists in storage and delete it if true.
        /// </summary>
        /// <param name="fileName">File name.</param>
        [Given(@"There is no file (.*) on storage")]
        public void GivenThereIsNoFileInStorage(string fileName)
        {
            this.context.StorageApi.DeleteFile(this.context.TestFolderInStorage + fileName, null, null);
        }

        /// <summary>
        /// Checks converted document exists on storage.
        /// </summary>
        /// <param name="fileName">File name.</param>
        [Then(@"document (.*) is existed on storage")]
        public void ThenDocumentIsExistedInStorageWithFormat(string fileName)
        {
            Assert.IsTrue(this.context.FileWithNameExists(fileName));
        }

        /// <summary>
        /// Downloads saved to storage document
        /// </summary>
        [Then(@"document from storage is downloadble")]
        public void ThenDocumentFromStorageIsDownloadble()
        {
            var resp = this.context.StorageApi
                .GetDownload(this.Request.OutPath, null, null);
            this.context.Response = new MemoryStream(resp.ResponseStream);
        }
    }
}