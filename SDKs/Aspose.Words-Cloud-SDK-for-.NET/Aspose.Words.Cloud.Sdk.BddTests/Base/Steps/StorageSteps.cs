namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;

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
        [Given(@"There is no file (.*) in storage")]

        public void GivenThereIsNoFileInStorage(string fileName)
        {
            this.context.StorageApi.DeleteFile(this.context.TestFolderInStorage + fileName, null, null);
        }

        /// <summary>
        /// Saves converted document to storage.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <param name="format">Expected format.</param>
        [Then(@"document (.*) is existed in storage with format (.*)")]
        public void ThenDocumentIsExistedInStorageWithFormat(string fileName, string format)
        {
            Assert.IsTrue(this.FileWithNameExists(fileName));
            // TODO: add format check
            throw new NotImplementedException();
        }
      
        /// <summary>
        /// Is document with this name exist
        /// </summary>
        /// <param name="name">document name</param>
        /// <returns>is exist</returns>
        private bool FileWithNameExists(string name)
        {
            var isExists = this.context.StorageApi.GetIsExist(this.context.TestFolderInStorage + name, null, null);
            if (isExists != null && isExists.FileExist != null)
            {
                return isExists.FileExist.IsExist;
            }

            return false;
        }             
    }
}