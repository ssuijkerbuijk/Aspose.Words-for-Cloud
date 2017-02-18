using System;
using System.Collections.Generic;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Fields.ParagraphLevel
{
    class AddFormFields
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            string fileName = "test_multi_pages.docx";
            int sectionIndex = 0;
            int paragraphIndex = 0;
            string insertBeforeNode = null;
            string destFileName = "test.docx";
            string storage = null;
            string folder = null;

            FormField body = new FormField();
            Link lnk = new Link();
            lnk.Href = "";

            body.Name = "FullName";
            body.Enabled = true;
            body.CalculateOnExit = true;
            body.StatusText = "";
            body.link = lnk;
            body.TextInputType = "Regular";
            body.TextInputDefault = "";
            body.TextInputFormat = "UPPERCASE";

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", "", System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to add form fileds
                FormFieldResponse apiResponse = wordsApi.PutFormField(fileName, sectionIndex, paragraphIndex, insertBeforeNode, destFileName, storage, folder, body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Form field has been added successfully");
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
