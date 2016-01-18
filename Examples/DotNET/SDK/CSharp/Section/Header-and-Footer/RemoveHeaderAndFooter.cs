using System;
using Aspose.Cloud;

namespace CSharp.Section.Header_and_Footer
{
    class RemoveHeaderAndFooter
    {
        public static void Run()
        {
            string inputfile = "header-footer.doc";
            string subdirection = "Section";

            // Upload input file from local directory to Cloud Storage
            Common.UploadFile(inputfile, subdirection);

            // Remove all Headers and Footers
            Common.WordsService.WordsHeadersFooters.DeleteDocumentHeadersAndFooters(inputfile, string.Empty, Common.GetOutputFilePath(inputfile,true), Common.FOLDER);

            // Download output file from cloud storage and save on local directory
            string dataDir = Common.DownloadFile(inputfile, subdirection);

            Console.WriteLine("\nAll headers and footers removed successfully.\nFile saved at " + dataDir);
        }
    }
}
