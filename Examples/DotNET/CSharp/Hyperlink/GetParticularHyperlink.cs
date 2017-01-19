using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Hyperlink
{
    class GetParticularHyperlink
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "SampleWordDocument.docx";
            int hyperlinkIndex = 0;
            string storage = null;
            string folder = null;

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to get particular hyperlink
                HyperlinkResponse apiResponse = wordsApi.GetDocumentHyperlinkByIndex(fileName, hyperlinkIndex, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Com.Aspose.Words.Model.Hyperlink hyperlink = apiResponse.Hyperlink;
                    Console.WriteLine("Display Text: " + hyperlink.DisplayText + " Value: " + hyperlink.Value + " link: " + hyperlink.link.Href);
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("error:" + ex.Message + "\n" + ex.StackTrace);
            }
            // ExEnd:1
        }
    }
}
