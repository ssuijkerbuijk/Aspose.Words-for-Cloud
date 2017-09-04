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
  /// 
  /// </summary>  
  public class HtmlSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets HtmlVersion
        /// </summary>
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
        /// Gets or sets OfficeMathOutputMode
        /// </summary>
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
        /// Gets or sets HtmlVersion
        /// </summary>
        public HtmlVersionEnum? HtmlVersion { get; set; }

        /// <summary>
        /// Gets or sets OfficeMathOutputMode
        /// </summary>
        public OfficeMathOutputModeEnum? OfficeMathOutputMode { get; set; }

        /// <summary>
        /// Gets or sets PrettyFormat
        /// </summary>    
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Gets or sets AllowNegativeIndent
        /// </summary>    
        public bool? AllowNegativeIndent { get; set; }

        /// <summary>
        /// Gets or sets CssStyleSheetFileName
        /// </summary>    
        public string CssStyleSheetFileName { get; set; }

        /// <summary>
        /// Gets or sets CssStyleSheetType
        /// </summary>    
        public string CssStyleSheetType { get; set; }

        /// <summary>
        /// Gets or sets DocumentSplitCriteria
        /// </summary>    
        public string DocumentSplitCriteria { get; set; }

        /// <summary>
        /// Gets or sets DocumentSplitHeadingLevel
        /// </summary>    
        public int? DocumentSplitHeadingLevel { get; set; }

        /// <summary>
        /// Gets or sets Encoding
        /// </summary>    
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets ExportDocumentProperties
        /// </summary>    
        public bool? ExportDocumentProperties { get; set; }

        /// <summary>
        /// Gets or sets ExportFontsAsBase64
        /// </summary>    
        public bool? ExportFontsAsBase64 { get; set; }

        /// <summary>
        /// Gets or sets ExportFontResources
        /// </summary>    
        public bool? ExportFontResources { get; set; }

        /// <summary>
        /// Gets or sets ExportHeadersFootersMode
        /// </summary>    
        public string ExportHeadersFootersMode { get; set; }

        /// <summary>
        /// Gets or sets ExportImagesAsBase64
        /// </summary>    
        public bool? ExportImagesAsBase64 { get; set; }

        /// <summary>
        /// Gets or sets ExportLanguageInformation
        /// </summary>    
        public bool? ExportLanguageInformation { get; set; }

        /// <summary>
        /// Gets or sets ExportListLabels
        /// </summary>    
        public string ExportListLabels { get; set; }

        /// <summary>
        /// Gets or sets ExportMetafileAsRaster
        /// </summary>    
        public bool? ExportMetafileAsRaster { get; set; }

        /// <summary>
        /// Gets or sets ExportOriginalUrlForLinkedImages
        /// </summary>    
        public bool? ExportOriginalUrlForLinkedImages { get; set; }

        /// <summary>
        /// Gets or sets ExportPageMargins
        /// </summary>    
        public bool? ExportPageMargins { get; set; }

        /// <summary>
        /// Gets or sets ExportPageSetup
        /// </summary>    
        public bool? ExportPageSetup { get; set; }

        /// <summary>
        /// Gets or sets ExportRelativeFontSize
        /// </summary>    
        public bool? ExportRelativeFontSize { get; set; }

        /// <summary>
        /// Gets or sets ExportRoundtripInformation
        /// </summary>    
        public bool? ExportRoundtripInformation { get; set; }

        /// <summary>
        /// Gets or sets ExportTextBoxAsSvg
        /// </summary>    
        public bool? ExportTextBoxAsSvg { get; set; }

        /// <summary>
        /// Gets or sets ExportTextInputFormFieldAsText
        /// </summary>    
        public bool? ExportTextInputFormFieldAsText { get; set; }

        /// <summary>
        /// Gets or sets ExportTocPageNumbers
        /// </summary>    
        public bool? ExportTocPageNumbers { get; set; }

        /// <summary>
        /// Gets or sets ExportXhtmlTransitional
        /// </summary>    
        public bool? ExportXhtmlTransitional { get; set; }

        /// <summary>
        /// Gets or sets FontsFolder
        /// </summary>    
        public string FontsFolder { get; set; }

        /// <summary>
        /// Gets or sets FontsFolderAlias
        /// </summary>    
        public string FontsFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets FontResourcesSubsettingSizeThreshold
        /// </summary>    
        public int? FontResourcesSubsettingSizeThreshold { get; set; }

        /// <summary>
        /// Gets or sets ImagesFolder
        /// </summary>    
        public string ImagesFolder { get; set; }

        /// <summary>
        /// Gets or sets ImagesFolderAlias
        /// </summary>    
        public string ImagesFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets ImageResolution
        /// </summary>    
        public int? ImageResolution { get; set; }

        /// <summary>
        /// Gets or sets ResourceFolder
        /// </summary>    
        public string ResourceFolder { get; set; }

        /// <summary>
        /// Gets or sets ResourceFolderAlias
        /// </summary>    
        public string ResourceFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets ScaleImageToShapeSize
        /// </summary>    
        public bool? ScaleImageToShapeSize { get; set; }

        /// <summary>
        /// Gets or sets TableWidthOutputMode
        /// </summary>    
        public string TableWidthOutputMode { get; set; }

        /// <summary>
        /// Gets or sets ExportDropDownFormFieldAsText
        /// </summary>    
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
