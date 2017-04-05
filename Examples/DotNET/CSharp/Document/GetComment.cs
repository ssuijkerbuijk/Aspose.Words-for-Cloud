using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Document
{
    class GetComment
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string name = "test_multi_pages.docx";
            int commentIndex = 1;
            string storage = null;
            string folder = null;

            try
            {
                // Upload source file to aspose cloud storage
                storageApi.PutCreate(name, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + name));
                

                // Invoke Aspose.Words Cloud SDK API to get comments
                Com.Aspose.Words.Model.CommentResponse apiResponse;
                apiResponse = wordsApi.GetComment(name, commentIndex, storage, folder);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {              
                  
                    Console.WriteLine(  apiResponse.Comment.Text);
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
