using System;
using Aspose.Cloud;

namespace CSharp.Section
{
    class GetAllSections
    {
        public static void Run()
        {
            string inputfile = "doc-sample.doc";
            string subdirection = "Section";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Get a List of Sections from a Word Document
            WordsSectionsResponse wordsSectionsResponse = Common.WordsService.WordsSections.GetSectionsList(inputfile, Common.FOLDER);

            Console.WriteLine("\n" +  inputfile + " have " + wordsSectionsResponse.Sections.SectionLinkList.Count + " sections.");
        }
    }
}
