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
  /// container class for html save options
  /// </summary>  
  public class HtmlSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.    Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
        /// </summary>
        /// <value>Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.    Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HtmlVersionEnum
        {
            
            /// <summary>
            /// Enum Xhtml for "Xhtml"
            /// </summary>            
            Xhtml,
            
            /// <summary>
            /// Enum Html5 for "Html5"
            /// </summary>            
            Html5
        }

        /// <summary>
        /// Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.
        /// </summary>
        /// <value>Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfficeMathOutputModeEnum
        {
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image,
            
            /// <summary>
            /// Enum MathML for "MathML"
            /// </summary>            
            MathML,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text
        }

        /// <summary>
        /// Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.    Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.
        /// </summary>
        /// <value>Specifies version of HTML standard that should be used when saving the document to HTML or MHTML.    Default value is Aspose.Words.Saving.HtmlVersion.Xhtml.</value>
        public HtmlVersionEnum? HtmlVersion { get; set; }

        /// <summary>
        /// Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.
        /// </summary>
        /// <value>Controls how OfficeMath objects are exported to HTML, MHTML or EPUB.  Default value is HtmlOfficeMathOutputMode.Image.</value>
        public OfficeMathOutputModeEnum? OfficeMathOutputMode { get; set; }

        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>
        /// <value>Specifies whether or not use pretty formats output</value>    
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Specifies whether negative left and right indents of paragraphs are allowed (not normalized)
        /// </summary>
        /// <value>Specifies whether negative left and right indents of paragraphs are allowed (not normalized)</value>    
        public bool? AllowNegativeIndent { get; set; }

        /// <summary>
        /// Specifies the name of the CSS file written when the document is exported to HTML
        /// </summary>
        /// <value>Specifies the name of the CSS file written when the document is exported to HTML</value>    
        public string CssStyleSheetFileName { get; set; }

        /// <summary>
        /// Specifies how CSS styles are exported
        /// </summary>
        /// <value>Specifies how CSS styles are exported</value>    
        public string CssStyleSheetType { get; set; }

        /// <summary>
        /// Specifies how the document should be split when saving
        /// </summary>
        /// <value>Specifies how the document should be split when saving</value>    
        public string DocumentSplitCriteria { get; set; }

        /// <summary>
        /// Specifies the maximum level of headings at which to split the document
        /// </summary>
        /// <value>Specifies the maximum level of headings at which to split the document</value>    
        public int? DocumentSplitHeadingLevel { get; set; }

        /// <summary>
        /// Specifies the encoding to use when exporting
        /// </summary>
        /// <value>Specifies the encoding to use when exporting</value>    
        public string Encoding { get; set; }

        /// <summary>
        /// Specifies whether to export built-in and custom document properties
        /// </summary>
        /// <value>Specifies whether to export built-in and custom document properties</value>    
        public bool? ExportDocumentProperties { get; set; }

        /// <summary>
        /// Specifies whether fonts resources should be embedded to HTML in Base64 encoding.  Default is false.
        /// </summary>
        /// <value>Specifies whether fonts resources should be embedded to HTML in Base64 encoding.  Default is false.</value>    
        public bool? ExportFontsAsBase64 { get; set; }

        /// <summary>
        /// Specifies whether font resources should be exported
        /// </summary>
        /// <value>Specifies whether font resources should be exported</value>    
        public bool? ExportFontResources { get; set; }

        /// <summary>
        /// Specifies how headers and footers are output
        /// </summary>
        /// <value>Specifies how headers and footers are output</value>    
        public string ExportHeadersFootersMode { get; set; }

        /// <summary>
        /// Specifies whether images are saved in Base64 format
        /// </summary>
        /// <value>Specifies whether images are saved in Base64 format</value>    
        public bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Specifies whether language information is exported
        /// </summary>
        /// <value>Specifies whether language information is exported</value>    
        public bool? ExportLanguageInformation { get; set; }

        /// <summary>
        /// Controls how list labels are output
        /// </summary>
        /// <value>Controls how list labels are output</value>    
        public string ExportListLabels { get; set; }

        /// <summary>
        /// Specifies whether to convert metafiles into raster images when exporting
        /// </summary>
        /// <value>Specifies whether to convert metafiles into raster images when exporting</value>    
        public bool? ExportMetafileAsRaster { get; set; }

        /// <summary>
        /// Specifies whether original URL should be used as the URL of the linked images.  Default value is false.
        /// </summary>
        /// <value>Specifies whether original URL should be used as the URL of the linked images.  Default value is false.</value>    
        public bool? ExportOriginalUrlForLinkedImages { get; set; }

        /// <summary>
        /// Specifies whether page margins is exported to HTML, MHTML or EPUB.  Default is false.
        /// </summary>
        /// <value>Specifies whether page margins is exported to HTML, MHTML or EPUB.  Default is false.</value>    
        public bool? ExportPageMargins { get; set; }

        /// <summary>
        /// Specifies whether page setup is exported
        /// </summary>
        /// <value>Specifies whether page setup is exported</value>    
        public bool? ExportPageSetup { get; set; }

        /// <summary>
        /// Specifies whether font sizes should be output in relative units when saving
        /// </summary>
        /// <value>Specifies whether font sizes should be output in relative units when saving</value>    
        public bool? ExportRelativeFontSize { get; set; }

        /// <summary>
        /// Specifies whether to write the roundtrip information when saving to HTML  Default value is true.
        /// </summary>
        /// <value>Specifies whether to write the roundtrip information when saving to HTML  Default value is true.</value>    
        public bool? ExportRoundtripInformation { get; set; }

        /// <summary>
        /// Controls how textboxes represented by Aspose.Words.Drawing.Shape are saved to HTML, MHTML or EPUB. Default value is false.  <remarks>    When set to true, exports textboxes as inline \"svg\" elements. When false, exports as \"image\" elements.  </remarks>
        /// </summary>
        /// <value>Controls how textboxes represented by Aspose.Words.Drawing.Shape are saved to HTML, MHTML or EPUB. Default value is false.  <remarks>    When set to true, exports textboxes as inline \"svg\" elements. When false, exports as \"image\" elements.  </remarks></value>    
        public bool? ExportTextBoxAsSvg { get; set; }

        /// <summary>
        /// Controls how text input form fields are saved
        /// </summary>
        /// <value>Controls how text input form fields are saved</value>    
        public bool? ExportTextInputFormFieldAsText { get; set; }

        /// <summary>
        /// Specifies whether to write page numbers to table of contents when saving
        /// </summary>
        /// <value>Specifies whether to write page numbers to table of contents when saving</value>    
        public bool? ExportTocPageNumbers { get; set; }

        /// <summary>
        /// Specifies whether to write the DOCTYPE declaration when saving
        /// </summary>
        /// <value>Specifies whether to write the DOCTYPE declaration when saving</value>    
        public bool? ExportXhtmlTransitional { get; set; }

        /// <summary>
        /// Specifies the physical folder where fonts are saved when exporting a document
        /// </summary>
        /// <value>Specifies the physical folder where fonts are saved when exporting a document</value>    
        public string FontsFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct font URIs
        /// </summary>
        /// <value>Specifies the name of the folder used to construct font URIs</value>    
        public string FontsFolderAlias { get; set; }

        /// <summary>
        /// Controls which font resources need subsetting when saving
        /// </summary>
        /// <value>Controls which font resources need subsetting when saving</value>    
        public int? FontResourcesSubsettingSizeThreshold { get; set; }

        /// <summary>
        /// Specifies the physical folder where images are saved when exporting a document
        /// </summary>
        /// <value>Specifies the physical folder where images are saved when exporting a document</value>    
        public string ImagesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct image URIs
        /// </summary>
        /// <value>Specifies the name of the folder used to construct image URIs</value>    
        public string ImagesFolderAlias { get; set; }

        /// <summary>
        /// Specifies the output resolution for images when exporting
        /// </summary>
        /// <value>Specifies the output resolution for images when exporting</value>    
        public int? ImageResolution { get; set; }

        /// <summary>
        /// Specifies a physical folder where all resources like images, fonts, and external CSS are saved when a document is exported to HTML. Default is an empty string.
        /// </summary>
        /// <value>Specifies a physical folder where all resources like images, fonts, and external CSS are saved when a document is exported to HTML. Default is an empty string.</value>    
        public string ResourceFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct URIs of all resources written into an HTML document.  Default is an empty string.
        /// </summary>
        /// <value>Specifies the name of the folder used to construct URIs of all resources written into an HTML document.  Default is an empty string.</value>    
        public string ResourceFolderAlias { get; set; }

        /// <summary>
        /// Specifies whether images are scaled by Aspose.Words to the bounding shape size when exporting
        /// </summary>
        /// <value>Specifies whether images are scaled by Aspose.Words to the bounding shape size when exporting</value>    
        public bool? ScaleImageToShapeSize { get; set; }

        /// <summary>
        /// Controls how table, row and cell widths are exported
        /// </summary>
        /// <value>Controls how table, row and cell widths are exported</value>    
        public string TableWidthOutputMode { get; set; }

        /// <summary>
        /// Controls how drop-down form fields are saved to HTML.  Default value is false.
        /// </summary>
        /// <value>Controls how drop-down form fields are saved to HTML.  Default value is false.</value>    
        public bool? ExportDropDownFormFieldAsText { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HtmlSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(PrettyFormat).Append("\n");
          sb.Append("  AllowNegativeIndent: ").Append(AllowNegativeIndent).Append("\n");
          sb.Append("  CssStyleSheetFileName: ").Append(CssStyleSheetFileName).Append("\n");
          sb.Append("  CssStyleSheetType: ").Append(CssStyleSheetType).Append("\n");
          sb.Append("  DocumentSplitCriteria: ").Append(DocumentSplitCriteria).Append("\n");
          sb.Append("  DocumentSplitHeadingLevel: ").Append(DocumentSplitHeadingLevel).Append("\n");
          sb.Append("  Encoding: ").Append(Encoding).Append("\n");
          sb.Append("  ExportDocumentProperties: ").Append(ExportDocumentProperties).Append("\n");
          sb.Append("  ExportFontsAsBase64: ").Append(ExportFontsAsBase64).Append("\n");
          sb.Append("  ExportFontResources: ").Append(ExportFontResources).Append("\n");
          sb.Append("  ExportHeadersFootersMode: ").Append(ExportHeadersFootersMode).Append("\n");
          sb.Append("  ExportImagesAsBase64: ").Append(ExportImagesAsBase64).Append("\n");
          sb.Append("  ExportLanguageInformation: ").Append(ExportLanguageInformation).Append("\n");
          sb.Append("  ExportListLabels: ").Append(ExportListLabels).Append("\n");
          sb.Append("  ExportMetafileAsRaster: ").Append(ExportMetafileAsRaster).Append("\n");
          sb.Append("  ExportOriginalUrlForLinkedImages: ").Append(ExportOriginalUrlForLinkedImages).Append("\n");
          sb.Append("  ExportPageMargins: ").Append(ExportPageMargins).Append("\n");
          sb.Append("  ExportPageSetup: ").Append(ExportPageSetup).Append("\n");
          sb.Append("  ExportRelativeFontSize: ").Append(ExportRelativeFontSize).Append("\n");
          sb.Append("  ExportRoundtripInformation: ").Append(ExportRoundtripInformation).Append("\n");
          sb.Append("  ExportTextBoxAsSvg: ").Append(ExportTextBoxAsSvg).Append("\n");
          sb.Append("  ExportTextInputFormFieldAsText: ").Append(ExportTextInputFormFieldAsText).Append("\n");
          sb.Append("  ExportTocPageNumbers: ").Append(ExportTocPageNumbers).Append("\n");
          sb.Append("  ExportXhtmlTransitional: ").Append(ExportXhtmlTransitional).Append("\n");
          sb.Append("  FontsFolder: ").Append(FontsFolder).Append("\n");
          sb.Append("  FontsFolderAlias: ").Append(FontsFolderAlias).Append("\n");
          sb.Append("  FontResourcesSubsettingSizeThreshold: ").Append(FontResourcesSubsettingSizeThreshold).Append("\n");
          sb.Append("  HtmlVersion: ").Append(HtmlVersion).Append("\n");
          sb.Append("  ImagesFolder: ").Append(ImagesFolder).Append("\n");
          sb.Append("  ImagesFolderAlias: ").Append(ImagesFolderAlias).Append("\n");
          sb.Append("  ImageResolution: ").Append(ImageResolution).Append("\n");
          sb.Append("  OfficeMathOutputMode: ").Append(OfficeMathOutputMode).Append("\n");
          sb.Append("  ResourceFolder: ").Append(ResourceFolder).Append("\n");
          sb.Append("  ResourceFolderAlias: ").Append(ResourceFolderAlias).Append("\n");
          sb.Append("  ScaleImageToShapeSize: ").Append(ScaleImageToShapeSize).Append("\n");
          sb.Append("  TableWidthOutputMode: ").Append(TableWidthOutputMode).Append("\n");
          sb.Append("  ExportDropDownFormFieldAsText: ").Append(ExportDropDownFormFieldAsText).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
