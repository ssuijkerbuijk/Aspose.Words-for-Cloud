using System;
using System.IO;

class Common
{
    public static string APP_SID = "C8CBC3A0-1DC6-473D-9FBC-D47CD85687F0";
    public static string APP_KEY = "4a8fd1d4e29263dc8d2a9fb61ef45406";
    public static string FOLDER = "";
    public static string STORAGE = "";
    public static string BASEPATH = "http://api.aspose.cloud/v1.1";
    // public static string BASEPATH = "http://localhost:8080/v1.1";
    public static string OUTFOLDER = "C://temp/";

    public static string GetDataDir()
    {
        var parent = ((Directory.GetParent(Directory.GetCurrentDirectory()).Parent).Parent).Parent;
        string startDirectory = null;
        if (parent != null)
        {
            var directoryInfo = parent.Parent;
            if (directoryInfo != null)
            {
                startDirectory = directoryInfo.FullName;
            }
        }
        else
        {
            startDirectory = parent.FullName;
        }
        return Path.Combine(startDirectory, "Data\\");
    }

}

