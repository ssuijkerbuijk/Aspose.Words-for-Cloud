namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Context
{
    using Aspose.Words.Cloud.Sdk.Api;

    using Com.Aspose.Storage.Api;

    /// <summary>
    /// Base context for all tests.
    /// </summary>
    public class BaseContext
    {
        private const string BaseProductUri = @"http://api-dev.aspose.cloud/v1.1";
        private const string AppSID = "78b637f6-b4cc-41de-a619-d8bd9fc2b6b6";
        private const string AppKey = "3d588eb82b3d5a634ad3141f09b03629";

        private string testFolder;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseContext"/>.
        /// </summary>
        protected BaseContext()
        {            
            this.WordsApi = new WordsApi(AppKey, AppSID, BaseProductUri);
            this.StorageApi = new StorageApi(AppKey, AppSID, BaseProductUri);
        }

        /// <summary>
        /// Storage API
        /// </summary>
        public StorageApi StorageApi { get; set; }

        /// <summary>
        /// Words API
        /// </summary>
        public WordsApi WordsApi { get; set; }

        /// <summary>
        /// Response.
        /// </summary>
        public object Response { get; set; }        

        /// <summary>
        /// Get path to test data
        /// </summary>
        public string TestDataPath
        {
            get
            {
                return this.testFolder ?? (this.testFolder = DirectoryHelper.GetTestDataPath());
            }
        }

        /// <summary>
        /// Folder name
        /// </summary>
        public string TestFolderInStorage
        {
            get
            {
                return "TempSDKTests/";
            }
        }

        /// <summary>
        /// Is document with this name exist
        /// </summary>
        /// <param name="name">document name</param>
        /// <returns>is exist</returns>
        public bool FileWithNameExists(string name)
        {
            var isExists = this.StorageApi.GetIsExist(this.TestFolderInStorage + name, null, null);
            if (isExists != null && isExists.FileExist != null)
            {
                return isExists.FileExist.IsExist;
            }

            return false;
        }
    }
}