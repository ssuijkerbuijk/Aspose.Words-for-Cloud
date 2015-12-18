using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using CSharp.Document;
using CSharp.Document.SplitResources;
using CSharp.Text;
using CSharp.Fields;
using CSharp.Fields.ParagraphLevel;
using CSharp.Mail_Merge;
using CSharp.Drawing;
using CSharp.Watermark;
using CSharp.Bookmark;
using CSharp.Hyperlink;
using CSharp.Protection;
using CSharp.Section;
using CSharp.Section.Header_and_Footer;
using CSharp.Page_Setup;
using CSharp.Paragraph;

namespace CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run");
            Console.WriteLine("=====================================================");
            // Un-comment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// Document
            //// =====================================================
            //// =====================================================

            //AppendDocuments.Run();
            //ConvertToAnotherFormat.Run();
            //SplitToNewPDFs.Run();
            //SplitToAnyFormat.Run();
            //WordAndParagraphCount.Run();
            //AcceptTrackingChanges.Run();
            //RejectTrackingChanges.Run();
            //CovertWebPagesToDocuments.Run();

            //// =====================================================
            //// =====================================================
            //// Text
            //// =====================================================
            //// =====================================================

            //GetTextItems.Run();
            //ReplaceText.Run();

            //// =====================================================
            //// =====================================================
            //// Fields
            //// =====================================================
            //// =====================================================

            //GetMergeFieldNames.Run();
            //InsertPageNumberField.Run();
            //UpdateFields.Run();
            //AddFormFields.Run();

            //// =====================================================
            //// =====================================================
            //// Mail-Merge
            //// =====================================================
            //// =====================================================

            //ExecuteTemplate.Run();
            //ExecuteWithoutRegions.Run();
            //ExecuteWithRegions.Run();
            //WithoutRegionsWithoutCloudStorage.Run();

            //// =====================================================
            //// =====================================================
            //// Drawing
            //// =====================================================
            //// =====================================================

            //ConvertToImage.Run();
            //GetAllObjects.Run();
            //GetImageObject.Run();

            //// =====================================================
            //// =====================================================
            //// Watermark
            //// =====================================================
            //// =====================================================

            //AddImage.Run();
            //AddText.Run();
            //RemoveWatermark.Run();

            //// =====================================================
            //// =====================================================
            //// Bookmark
            //// =====================================================
            //// =====================================================

            //GetAllBookmarks.Run();
            //GetSpecificBookmark.Run();
            //UpdateBookmarkText.Run();

            //// =====================================================
            //// =====================================================
            //// Hyperlink
            //// =====================================================
            //// =====================================================

            //GetAllHyperlinks.Run();
            //GetParticularHyperlink.Run();

            //// =====================================================
            //// =====================================================
            //// Protection
            //// =====================================================
            //// =====================================================

            //ProtectDocument.Run();
            //UnprotectDocument.Run();
            //ModifyProtection.Run();

            //// =====================================================
            //// =====================================================
            //// Section
            //// =====================================================
            //// =====================================================

            RemoveHeaderAndFooter.Run();
            //GetAllSections.Run();

            //// =====================================================
            //// =====================================================
            //// Page-Setup
            //// =====================================================
            //// =====================================================

            //ExtractPageSetupInformation.Run();

            //// =====================================================
            //// =====================================================
            //// Paragraph
            //// =====================================================
            //// =====================================================

            //GetParagraphs.Run();
            //GetSpecificRunOfParagraph.Run();
            //GetFontOfRun.Run();

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }
        
    }
}
