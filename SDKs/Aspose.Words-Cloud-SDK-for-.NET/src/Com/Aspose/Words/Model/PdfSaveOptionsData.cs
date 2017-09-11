using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// container class for pdf save options
  /// </summary>  
  public class PdfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the level in the PDF document outline at which to display Word bookmarks
        /// </summary>
        /// <value>Specifies the level in the PDF document outline at which to display Word bookmarks</value>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies whether to convert footnote/endnote references in main text story into active hyperlinks.  When clicked the hyperlink will lead to the corresponding footnote/endnote.  Default is false.
        /// </summary>
        /// <value>Specifies whether to convert footnote/endnote references in main text story into active hyperlinks.  When clicked the hyperlink will lead to the corresponding footnote/endnote.  Default is false.</value>    
        public bool? CreateNoteHyperlinks { get; set; }

        /// <summary>
        /// Specifies the PDF standards compliance level for output documents
        /// </summary>
        /// <value>Specifies the PDF standards compliance level for output documents</value>    
        public string Compliance { get; set; }

        /// <summary>
        /// Specifies the details for signing the output PDF document
        /// </summary>
        /// <value>Specifies the details for signing the output PDF document</value>    
        public PdfDigitalSignatureDetailsData DigitalSignatureDetails { get; set; }

        /// <summary>
        /// A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.
        /// </summary>
        /// <value>A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.</value>    
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Specifies whether or not the images should be downsampled
        /// </summary>
        /// <value>Specifies whether or not the images should be downsampled</value>    
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Specifies the resolution in pixels per inch to which the images should be downsampled
        /// </summary>
        /// <value>Specifies the resolution in pixels per inch to which the images should be downsampled</value>    
        public int? DownsampleResolution { get; set; }

        /// <summary>
        /// Allows to specify downsample options.
        /// </summary>
        /// <value>Allows to specify downsample options.</value>    
        public DownsampleOptionsData DownsampleOptions { get; set; }

        /// <summary>
        /// Controls how fonts are embedded into the resulting PDF documents
        /// </summary>
        /// <value>Controls how fonts are embedded into the resulting PDF documents</value>    
        public bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Determines whether or not to embed standard windows fonts Arial and Times New Roman
        /// </summary>
        /// <value>Determines whether or not to embed standard windows fonts Arial and Times New Roman</value>    
        public bool? EmbedStandardWindowsFonts { get; set; }

        /// <summary>
        /// Specifies the details for encrypting the output PDF document
        /// </summary>
        /// <value>Specifies the details for encrypting the output PDF document</value>    
        public PdfEncryptionDetailsData EncryptionDetails { get; set; }

        /// <summary>
        /// Specifies how many levels in the PDF document outline to show expanded when the PDF file is viewed
        /// </summary>
        /// <value>Specifies how many levels in the PDF document outline to show expanded when the PDF file is viewed</value>    
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Determines whether or not to export custom properties of document as Metadata
        /// </summary>
        /// <value>Determines whether or not to export custom properties of document as Metadata</value>    
        public bool? ExportCustomPropertiesAsMetadata { get; set; }

        /// <summary>
        /// Determines whether or not to export document structure
        /// </summary>
        /// <value>Determines whether or not to export document structure</value>    
        public bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Specifies the font embedding mode
        /// </summary>
        /// <value>Specifies the font embedding mode</value>    
        public string FontEmbeddingMode { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the PDF document outline
        /// </summary>
        /// <value>Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the PDF document outline</value>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Specifies compression type to be used for all images in the document
        /// </summary>
        /// <value>Specifies compression type to be used for all images in the document</value>    
        public string ImageCompression { get; set; }

        /// <summary>
        /// Determines whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser
        /// </summary>
        /// <value>Determines whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser</value>    
        public bool? OpenHyperlinksInNewWindow { get; set; }

        /// <summary>
        /// Allows to specify outline options
        /// </summary>
        /// <value>Allows to specify outline options</value>    
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Specifies how the PDF document should be displayed when opened in the PDF reader
        /// </summary>
        /// <value>Specifies how the PDF document should be displayed when opened in the PDF reader</value>    
        public string PageMode { get; set; }

        /// <summary>
        /// Specifies how the color space will be selected for the images in PDF document.
        /// </summary>
        /// <value>Specifies how the color space will be selected for the images in PDF document.</value>    
        public string ImageColorSpaceExportMode { get; set; }

        /// <summary>
        /// Specifies whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text
        /// </summary>
        /// <value>Specifies whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text</value>    
        public bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Specifies compression type to be used for all textual content in the document
        /// </summary>
        /// <value>Specifies compression type to be used for all textual content in the document</value>    
        public string TextCompression { get; set; }

        /// <summary>
        /// Determines whether or not to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts
        /// </summary>
        /// <value>Determines whether or not to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts</value>    
        public bool? UseCoreFonts { get; set; }

        /// <summary>
        /// Determines whether the document should be saved using a booklet printing layout
        /// </summary>
        /// <value>Determines whether the document should be saved using a booklet printing layout</value>    
        public bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Determines what type of zoom should be applied when a document is opened with a PDF viewer
        /// </summary>
        /// <value>Determines what type of zoom should be applied when a document is opened with a PDF viewer</value>    
        public string ZoomBehavior { get; set; }

        /// <summary>
        /// Determines zoom factor (in percentages) for a document
        /// </summary>
        /// <value>Determines zoom factor (in percentages) for a document</value>    
        public int? ZoomFactor { get; set; }

        /// <summary>
        /// Gets or sets a value determining the way {Aspose.Words.Properties.CustomDocumentProperties} are exported to PDF file.  Default value is {Aspose.Words.Saving.PdfCustomPropertiesExport.None}.
        /// </summary>
        /// <value>Gets or sets a value determining the way {Aspose.Words.Properties.CustomDocumentProperties} are exported to PDF file.  Default value is {Aspose.Words.Saving.PdfCustomPropertiesExport.None}.</value>    
        public string CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not to preblend transparent images with black background color.
        /// </summary>
        /// <value>Gets or sets a value determining whether or not to preblend transparent images with black background color.</value>    
        public bool? PreblendImages { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfSaveOptionsData {\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(BookmarksOutlineLevel).Append("\n");
          sb.Append("  CreateNoteHyperlinks: ").Append(CreateNoteHyperlinks).Append("\n");
          sb.Append("  Compliance: ").Append(Compliance).Append("\n");
          sb.Append("  DigitalSignatureDetails: ").Append(DigitalSignatureDetails).Append("\n");
          sb.Append("  DisplayDocTitle: ").Append(DisplayDocTitle).Append("\n");
          sb.Append("  DownsampleImages: ").Append(DownsampleImages).Append("\n");
          sb.Append("  DownsampleResolution: ").Append(DownsampleResolution).Append("\n");
          sb.Append("  DownsampleOptions: ").Append(DownsampleOptions).Append("\n");
          sb.Append("  EmbedFullFonts: ").Append(EmbedFullFonts).Append("\n");
          sb.Append("  EmbedStandardWindowsFonts: ").Append(EmbedStandardWindowsFonts).Append("\n");
          sb.Append("  EncryptionDetails: ").Append(EncryptionDetails).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(ExpandedOutlineLevels).Append("\n");
          sb.Append("  ExportCustomPropertiesAsMetadata: ").Append(ExportCustomPropertiesAsMetadata).Append("\n");
          sb.Append("  ExportDocumentStructure: ").Append(ExportDocumentStructure).Append("\n");
          sb.Append("  FontEmbeddingMode: ").Append(FontEmbeddingMode).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(HeadingsOutlineLevels).Append("\n");
          sb.Append("  ImageCompression: ").Append(ImageCompression).Append("\n");
          sb.Append("  OpenHyperlinksInNewWindow: ").Append(OpenHyperlinksInNewWindow).Append("\n");
          sb.Append("  OutlineOptions: ").Append(OutlineOptions).Append("\n");
          sb.Append("  PageMode: ").Append(PageMode).Append("\n");
          sb.Append("  ImageColorSpaceExportMode: ").Append(ImageColorSpaceExportMode).Append("\n");
          sb.Append("  PreserveFormFields: ").Append(PreserveFormFields).Append("\n");
          sb.Append("  TextCompression: ").Append(TextCompression).Append("\n");
          sb.Append("  UseCoreFonts: ").Append(UseCoreFonts).Append("\n");
          sb.Append("  UseBookFoldPrintingSettings: ").Append(UseBookFoldPrintingSettings).Append("\n");
          sb.Append("  ZoomBehavior: ").Append(ZoomBehavior).Append("\n");
          sb.Append("  ZoomFactor: ").Append(ZoomFactor).Append("\n");
          sb.Append("  CustomPropertiesExport: ").Append(CustomPropertiesExport).Append("\n");
          sb.Append("  PreblendImages: ").Append(PreblendImages).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
