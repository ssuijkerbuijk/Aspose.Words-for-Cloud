﻿using System;
using System.IO;

class Common
{
    public static string APP_SID = "xxxxxxxxxxxxxxxxxxx"; // Get App Key and App SID from https://dashboard.aspose.cloud/
    public static string APP_KEY = "xxxxxxxxxxxxxxxxxxx"; // Get App Key and App SID from https://dashboard.aspose.cloud/
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

