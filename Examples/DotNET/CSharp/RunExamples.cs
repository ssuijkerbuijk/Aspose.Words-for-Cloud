using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using Mail_Merge;
using Text;
using Page_Setup;
using Paragraph;
using Document;
using Document.SplitResources;
using Fields;
using Fields.ParagraphLevel;
using Document_Properties;
using Sections;
using Sections.Header_and_Footer;
using Bookmark;
using Hyperlink;
using Protection;
using Drawing;
using Watermark;

namespace CSharp
{
    class RunExamples
    {
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("Open RunExamples.cs. \nIn Main() method uncomment the example that you want to run.");
            Console.WriteLine("=====================================================");

            // Uncomment the one you want to try out

            //// =====================================================
            //// =====================================================
            //// Mail_Merge
            //// =====================================================
            //// =====================================================

            //ExecuteTemplate.Run();
            //ExecuteTemplateUsingThirdPartyStorage.Run();
            //ExecuteWithoutRegions.Run();
            //ExecuteWithoutRegionsUsingThirdPartyStorage.Run();
            //ExecuteWithRegions.Run();
            //ExecuteWithRegionsUsingThirdPartyStorage.Run();
            //InsertDynamicImages.Run();
            //WithoutRegionsWithoutCloudStorage.Run();

            //// =====================================================
            //// =====================================================
            //// Text
            //// =====================================================
            //// =====================================================

            //ReplaceTextUsingThirdPartyStorage.Run();
            //ReplaceText.Run();
            //GetTextItems.Run();

            //// =====================================================
            //// =====================================================
            //// Page-Setup
            //// =====================================================
            //// =====================================================

            //ExtractPageSetupInformation.Run();
            //UpdatePageSetup.Run();
            //GetRenderPage.Run();

            //// =====================================================
            //// =====================================================
            //// Paragraph
            //// =====================================================
            //// =====================================================

            //GetFontOfRun.Run();
            //GetListOfParagraphs.Run();
            //GetParagraph.Run();
            //GetSpecificRunOfParagraph.Run();
            //UpdateFontOfRun.Run();
            //ReadAllRuns.Run();

            //// =====================================================
            //// =====================================================
            //// Document
            //// =====================================================
            //// =====================================================

            //AcceptAllTrackingChanges.Run();
            //AppendDocuments.Run();
            ConvertToAnyFormat.Run();
            //ConvertToImages.Run();
            //ConvertToImagesUsingThirdPartyStorage.Run();
            //ConvertToOtherFormatWithOutStorage.Run();
            //ConvertWebPages.Run();
            //RejectAllTrackingChanges.Run();

            //// SplitResources
            //// =====================================================

            //SplitPagesToNewPDFs.Run();
            //SplitSpecificPagesToAnyFormat.Run();
            //SplitSpecificPagesToNewPDFs.Run();

            //// =====================================================
            //// =====================================================
            //// Fields
            //// =====================================================
            //// =====================================================

            //GetMergeFieldNames.Run();
            //InsertPageNumberField.Run();
            //InsertPageNumberFieldUsingThirdPartyStorage.Run();
            //UpdateFields.Run();
            //GetFields.Run();
            //DeleteField.Run();

            //// ParagraphLevel
            //// =====================================================

            //AddFormFields.Run();

            //// =====================================================
            //// =====================================================
            //// Document-Properties
            //// =====================================================
            //// =====================================================

            //GetAllDocumentProperties.Run();
            //GetParticularDocumentProperty.Run();
            //RemoveParticularDocumentProperty.Run();
            //SetSingleProperty.Run();

            //// =====================================================
            //// =====================================================
            //// Sections
            //// =====================================================
            //// =====================================================

            //GetAllSections.Run();
            //GetSpecificSection.Run();

            //// Header-and-Footer
            //// =====================================================

            //RemoveHeaderAndFooter.Run();

            //// =====================================================
            //// =====================================================
            //// Bookmark
            //// =====================================================
            //// =====================================================

            //GetAllBookmarks.Run();
            //ReadBookmarkByName.Run();
            //UpdateBookmarkText.Run();

            //// =====================================================
            //// =====================================================
            //// Hyperlink
            //// =====================================================
            //// =====================================================

            //GetParticularHyperlink.Run();
            //ReadAllHyperlinks.Run();

            //// =====================================================
            //// =====================================================
            //// Protection
            //// =====================================================
            //// =====================================================

            //ModifyProtection.Run();
            //RemoveProtection.Run();

            //// =====================================================
            //// =====================================================
            //// Drawing
            //// =====================================================
            //// =====================================================

            //GetAllDrawingObject.Run();
            //GetOLEData.Run();
            //ReadingImageData.Run();

            //// =====================================================
            //// =====================================================
            //// Watermark
            //// =====================================================
            //// =====================================================

            //AddWatermarkImage.Run();
            //AddWatermarkText.Run();
            //RemoveWatermark.Run();

            // Stop before exiting
            Console.WriteLine("\n\nProgram Finished. Press any key to exit....");
            Console.ReadKey();
        }

    }
}
