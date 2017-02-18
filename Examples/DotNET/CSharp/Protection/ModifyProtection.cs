using System;
using Com.Aspose.Words.Api;
using Com.Aspose.Words.Model;
using Com.Aspose.Storage.Api;

namespace Protection
{
    class ModifyProtection
    {
        public static void Run()
        {
            // ExStart:1
            WordsApi wordsApi = new WordsApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);
            StorageApi storageApi = new StorageApi(Common.APP_KEY, Common.APP_SID, Common.BASEPATH);

            String fileName = "SampleProtectedBlankWordDocument.docx";
            String destFileName = fileName;
            String storage = null;
            String folder = null;

            ProtectionRequest body = new ProtectionRequest();
            body.Password = "aspose";
            body.NewPassword = "";
            body.ProtectionType = "NoProtection";

            try
            {
                // Upload the file
                storageApi.PutCreate(fileName, "", storage, System.IO.File.ReadAllBytes(Common.GetDataDir() + fileName));
                // Invoke Aspose.Words Cloud SDK API to modify the document protection
                ProtectionDataResponse apiResponse = wordsApi.PostChangeDocumentProtection(fileName, destFileName, storage, folder, body);

                if (apiResponse != null && apiResponse.Status.Equals("OK"))
                {
                    Console.WriteLine("Document protection property has been changed from protected to unprotected successfully");
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
