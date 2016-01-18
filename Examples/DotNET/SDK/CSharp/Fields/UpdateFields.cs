using System;
using Aspose.Cloud;

namespace CSharp.Fields
{
    class UpdateFields
    {
        public static void Run()
        {          
            string inputfile = "doc-sample.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Update All Fields in the Word Document
            WordsDocumentResponse wordsDocumentResponse = Common.WordsService.WordsDocumentFields.UpdateFieldsInDocument(inputfile, Common.GetOutputFilePath(inputfile, true), Common.FOLDER);
            
            Console.WriteLine("\nAll fields updated successfully.");
        }
    }
}
