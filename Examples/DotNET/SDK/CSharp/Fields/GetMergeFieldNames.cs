using System;
using Aspose.Cloud;

namespace CSharp.Fields
{
    class GetMergeFieldNames
    {
        public static void Run()
        {            
            string inputfile = "doc-sample3.doc";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, string.Empty);

            // Get All Merge Field Names from a Word Document
            WordsFieldNamesResponse wordsFieldNamesResponse = Common.WordsService.WordsMailMerge.ReadDocumentFieldNames(inputfile, true, Common.FOLDER);

            Console.WriteLine("\n" + inputfile + " have " + wordsFieldNamesResponse.FieldNames.Names.Count + " Merge Field");
        }
    }
}
