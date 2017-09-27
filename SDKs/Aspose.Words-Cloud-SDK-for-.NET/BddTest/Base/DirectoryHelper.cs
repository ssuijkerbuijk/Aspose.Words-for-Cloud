namespace BddTest.Base
{
    using System.IO;

    public static class DirectoryHelper
    {
        public static string GetTestDataPath()
        {
            var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName, "Data");
            return path;
        }
    }
}