namespace Aspose.Words.Cloud.Sdk.BddTests.Base
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.Api;

    using Com.Aspose.Storage.Api;

    /// <summary>
    /// Base context for all tests
    /// </summary>
    public abstract class BaseContext
    {
        private const string BaseProductUri = @"http://api-dev.aspose.cloud/v1.1";
        private const string AppSID = "78b637f6-b4cc-41de-a619-d8bd9fc2b6b6";
        private const string AppKey = "3d588eb82b3d5a634ad3141f09b03629";

        private string testFolder;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseContext"/> class.
        /// </summary>
        protected BaseContext()
        {
            this.MethodsApi = new WordsApi(AppKey, AppSID, BaseProductUri);
            this.StorageApi = new StorageApi(AppKey, AppSID, BaseProductUri);
        }


        /// <summary>
        /// File we want to convert
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Storage API
        /// </summary>
        protected StorageApi StorageApi { get; set; }

        /// <summary>
        /// Methods API
        /// </summary>
        protected WordsApi MethodsApi { get; set; }

        /// <summary>
        /// Folder name
        /// </summary>
        protected string Folder
        {
            get
            {
                return "TempSDKTests/";
            }
        }

        /// <summary>
        /// Get path to test data
        /// </summary>
        protected string TestDataPath
        {
            get
            {
                return this.testFolder ?? (this.testFolder = DirectoryHelper.GetTestDataPath());
            }
        }

        /// <summary>
        /// Uploads document to storage
        /// </summary>
        public void UploadDocumentToStorage()
        {
            this.StorageApi.PutCreate(
                this.Folder + this.FileName,
                null,
                null,
                File.ReadAllBytes(Path.Combine(this.TestDataPath, this.FileName)));
        }
    }
}