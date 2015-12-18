Imports System.Collections.Generic
Imports System.IO
Imports System.Configuration
Imports VisualBasic.Document
Imports VisualBasic.Document.SplitResources
Imports VisualBasic.Text
Imports VisualBasic.Fields
Imports VisualBasic.Fields.ParagraphLevel
Imports VisualBasic.Mail_Merge
Imports VisualBasic.Drawing
Imports VisualBasic.Watermark
Imports VisualBasic.Bookmark
Imports VisualBasic.Hyperlink
Imports VisualBasic.Protection
Imports VisualBasic.Section
Imports VisualBasic.Section.Header_and_Footer
Imports VisualBasic.Page_Setup
Imports VisualBasic.Paragraph

Module RunExamples

    Sub Main()
        Console.WriteLine("Open RunExamples.cs. In Main() method, Un-comment the example that you want to run")
        Console.WriteLine("=====================================================")
        ' Un-comment the one you want to try out

        '' =====================================================
        '' =====================================================
        '' Document
        '' =====================================================
        '' =====================================================

        'AppendDocuments.Run();
        'ConvertToAnotherFormat.Run();
        'SplitToNewPDFs.Run();
        'SplitToAnyFormat.Run();
        'WordAndParagraphCount.Run();
        'AcceptTrackingChanges.Run();
        'RejectTrackingChanges.Run();
        'CovertWebPagesToDocuments.Run();

        '' =====================================================
        '' =====================================================
        '' Text
        '' =====================================================
        '' =====================================================

        'GetTextItems.Run();
        'ReplaceText.Run();

        '' =====================================================
        '' =====================================================
        '' Fields
        '' =====================================================
        '' =====================================================

        'GetMergeFieldNames.Run();
        'InsertPageNumberField.Run();
        'UpdateFields.Run();
        'AddFormFields.Run();

        '' =====================================================
        '' =====================================================
        '' Mail-Merge
        '' =====================================================
        '' =====================================================

        'ExecuteTemplate.Run();
        'ExecuteWithoutRegions.Run();
        'ExecuteWithRegions.Run();
        'WithoutRegionsWithoutCloudStorage.Run();

        '' =====================================================
        '' =====================================================
        '' Drawing
        '' =====================================================
        '' =====================================================

        'ConvertToImage.Run();
        'GetAllObjects.Run();
        'GetImageObject.Run();

        '' =====================================================
        '' =====================================================
        '' Watermark
        '' =====================================================
        '' =====================================================

        'AddImage.Run();
        'AddText.Run();
        'RemoveWatermark.Run();

        '' =====================================================
        '' =====================================================
        '' Bookmark
        '' =====================================================
        '' =====================================================

        'GetAllBookmarks.Run();
        'GetSpecificBookmark.Run();
        'UpdateBookmarkText.Run();

        '' =====================================================
        '' =====================================================
        '' Hyperlink
        '' =====================================================
        '' =====================================================

        'GetAllHyperlinks.Run();
        'GetParticularHyperlink.Run();

        '' =====================================================
        '' =====================================================
        '' Protection
        '' =====================================================
        '' =====================================================

        'ProtectDocument.Run();
        'UnprotectDocument.Run();
        'ModifyProtection.Run();

        '' =====================================================
        '' =====================================================
        '' Section
        '' =====================================================
        '' =====================================================

        RemoveHeaderAndFooter.Run()
        'GetAllSections.Run();

        '' =====================================================
        '' =====================================================
        '' Page-Setup
        '' =====================================================
        '' =====================================================

        'ExtractPageSetupInformation.Run();

        '' =====================================================
        '' =====================================================
        '' Paragraph
        '' =====================================================
        '' =====================================================

        'GetParagraphs.Run();
        'GetSpecificRunOfParagraph.Run();
        'GetFontOfRun.Run();

        ' Stop before exiting
        Console.WriteLine(vbLf & vbLf & "Program Finished. Press any key to exit....")
        Console.ReadKey()
    End Sub

End Module

