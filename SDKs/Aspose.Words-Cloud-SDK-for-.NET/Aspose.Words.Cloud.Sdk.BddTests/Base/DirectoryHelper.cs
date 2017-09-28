namespace Aspose.Words.Cloud.Sdk.BddTests.Base
{
    using System.IO;

    /// <summary>
    /// This class contains helper methods for working with directories
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Returns path to folder with test data
        /// </summary>
        /// <returns>path to test data folder</returns>
        public static string GetTestDataPath()
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName, "Data");
            return path;
        }
    }
}