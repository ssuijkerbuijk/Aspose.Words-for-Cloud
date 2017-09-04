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
  public class SvgSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets ExportEmbeddedImages
        /// </summary>    
        public bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Gets or sets FitToViewPort
        /// </summary>    
        public bool? FitToViewPort { get; set; }

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
        /// Gets or sets TextOutputMode
        /// </summary>    
        public string TextOutputMode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SvgSaveOptionsData {\n");
          sb.Append("  ExportEmbeddedImages: ").Append(ExportEmbeddedImages).Append("\n");
          sb.Append("  FitToViewPort: ").Append(FitToViewPort).Append("\n");
          sb.Append("  ResourcesFolder: ").Append(ResourcesFolder).Append("\n");
          sb.Append("  ResourcesFolderAlias: ").Append(ResourcesFolderAlias).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(ShowPageBorder).Append("\n");
          sb.Append("  TextOutputMode: ").Append(TextOutputMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
