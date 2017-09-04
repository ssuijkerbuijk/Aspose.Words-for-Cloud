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
  public class HtmlFixedSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets CssClassNamesPrefix
        /// </summary>    
        public string CssClassNamesPrefix { get; set; }

        /// <summary>
        /// Gets or sets ExportEmbeddedCss
        /// </summary>    
        public bool? ExportEmbeddedCss { get; set; }

        /// <summary>
        /// Gets or sets ExportEmbeddedFonts
        /// </summary>    
        public bool? ExportEmbeddedFonts { get; set; }

        /// <summary>
        /// Gets or sets ExportEmbeddedImages
        /// </summary>    
        public bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Gets or sets ExportFormFields
        /// </summary>    
        public bool? ExportFormFields { get; set; }

        /// <summary>
        /// Gets or sets Encoding
        /// </summary>    
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets FontFormat
        /// </summary>    
        public string FontFormat { get; set; }

        /// <summary>
        /// Gets or sets ResourcesFolder
        /// </summary>    
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Gets or sets ResourcesFolderAlias
        /// </summary>    
        public string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Gets or sets ShowPageBorder
        /// </summary>    
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Gets or sets PageHorizontalAlignment
        /// </summary>    
        public string PageHorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets PageMargins
        /// </summary>    
        public double? PageMargins { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class HtmlFixedSaveOptionsData {\n");
          sb.Append("  CssClassNamesPrefix: ").Append(CssClassNamesPrefix).Append("\n");
          sb.Append("  ExportEmbeddedCss: ").Append(ExportEmbeddedCss).Append("\n");
          sb.Append("  ExportEmbeddedFonts: ").Append(ExportEmbeddedFonts).Append("\n");
          sb.Append("  ExportEmbeddedImages: ").Append(ExportEmbeddedImages).Append("\n");
          sb.Append("  ExportFormFields: ").Append(ExportFormFields).Append("\n");
          sb.Append("  Encoding: ").Append(Encoding).Append("\n");
          sb.Append("  FontFormat: ").Append(FontFormat).Append("\n");
          sb.Append("  ResourcesFolder: ").Append(ResourcesFolder).Append("\n");
          sb.Append("  ResourcesFolderAlias: ").Append(ResourcesFolderAlias).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(ShowPageBorder).Append("\n");
          sb.Append("  PageHorizontalAlignment: ").Append(PageHorizontalAlignment).Append("\n");
          sb.Append("  PageMargins: ").Append(PageMargins).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
