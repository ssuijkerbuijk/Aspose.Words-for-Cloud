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
  public class PdfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets BookmarksOutlineLevel
        /// </summary>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets CreateNoteHyperlinks
        /// </summary>    
        public bool? CreateNoteHyperlinks { get; set; }

        /// <summary>
        /// Gets or sets Compliance
        /// </summary>    
        public string Compliance { get; set; }

        /// <summary>
        /// Gets or sets DigitalSignatureDetails
        /// </summary>    
        public PdfDigitalSignatureDetailsData DigitalSignatureDetails { get; set; }

        /// <summary>
        /// Gets or sets DisplayDocTitle
        /// </summary>    
        public bool? DisplayDocTitle { get; set; }

        /// <summary>
        /// Gets or sets DownsampleImages
        /// </summary>    
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Gets or sets DownsampleResolution
        /// </summary>    
        public int? DownsampleResolution { get; set; }

        /// <summary>
        /// Gets or sets DownsampleOptions
        /// </summary>    
        public DownsampleOptionsData DownsampleOptions { get; set; }

        /// <summary>
        /// Gets or sets EmbedFullFonts
        /// </summary>    
        public bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Gets or sets EmbedStandardWindowsFonts
        /// </summary>    
        public bool? EmbedStandardWindowsFonts { get; set; }

        /// <summary>
        /// Gets or sets EncryptionDetails
        /// </summary>    
        public PdfEncryptionDetailsData EncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets ExpandedOutlineLevels
        /// </summary>    
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets ExportCustomPropertiesAsMetadata
        /// </summary>    
        public bool? ExportCustomPropertiesAsMetadata { get; set; }

        /// <summary>
        /// Gets or sets ExportDocumentStructure
        /// </summary>    
        public bool? ExportDocumentStructure { get; set; }

        /// <summary>
        /// Gets or sets FontEmbeddingMode
        /// </summary>    
        public string FontEmbeddingMode { get; set; }

        /// <summary>
        /// Gets or sets HeadingsOutlineLevels
        /// </summary>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets ImageCompression
        /// </summary>    
        public string ImageCompression { get; set; }

        /// <summary>
        /// Gets or sets OpenHyperlinksInNewWindow
        /// </summary>    
        public bool? OpenHyperlinksInNewWindow { get; set; }

        /// <summary>
        /// Gets or sets OutlineOptions
        /// </summary>    
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets PageMode
        /// </summary>    
        public string PageMode { get; set; }

        /// <summary>
        /// Gets or sets ImageColorSpaceExportMode
        /// </summary>    
        public string ImageColorSpaceExportMode { get; set; }

        /// <summary>
        /// Gets or sets PreserveFormFields
        /// </summary>    
        public bool? PreserveFormFields { get; set; }

        /// <summary>
        /// Gets or sets TextCompression
        /// </summary>    
        public string TextCompression { get; set; }

        /// <summary>
        /// Gets or sets UseCoreFonts
        /// </summary>    
        public bool? UseCoreFonts { get; set; }

        /// <summary>
        /// Gets or sets UseBookFoldPrintingSettings
        /// </summary>    
        public bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Gets or sets ZoomBehavior
        /// </summary>    
        public string ZoomBehavior { get; set; }

        /// <summary>
        /// Gets or sets ZoomFactor
        /// </summary>    
        public int? ZoomFactor { get; set; }

        /// <summary>
        /// Gets or sets CustomPropertiesExport
        /// </summary>    
        public string CustomPropertiesExport { get; set; }

        /// <summary>
        /// Gets or sets PreblendImages
        /// </summary>    
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
