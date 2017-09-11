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
  /// container class for svg save options
  /// </summary>  
  public class SvgSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specified whether images should be embedded into SVG document as base64
        /// </summary>
        /// <value>Specified whether images should be embedded into SVG document as base64</value>    
        public bool? ExportEmbeddedImages { get; set; }

        /// <summary>
        /// Specifies if the output SVG should fill the available viewport area (browser window or container). When set to true width and height of output SVG are set to 100%.
        /// </summary>
        /// <value>Specifies if the output SVG should fill the available viewport area (browser window or container). When set to true width and height of output SVG are set to 100%.</value>    
        public bool? FitToViewPort { get; set; }

        /// <summary>
        /// Specifies the physical folder where resources (images) are saved when exporting
        /// </summary>
        /// <value>Specifies the physical folder where resources (images) are saved when exporting</value>    
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct image URIs
        /// </summary>
        /// <value>Specifies the name of the folder used to construct image URIs</value>    
        public string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Show/hide page stepper
        /// </summary>
        /// <value>Show/hide page stepper</value>    
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Determines how text should be rendered
        /// </summary>
        /// <value>Determines how text should be rendered</value>    
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
