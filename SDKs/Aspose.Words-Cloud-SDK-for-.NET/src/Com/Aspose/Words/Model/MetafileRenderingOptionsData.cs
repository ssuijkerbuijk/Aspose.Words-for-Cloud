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
  /// container class for options of metafile rendering
  /// </summary>  
  public class MetafileRenderingOptionsData 
  {                       
        /// <summary>
        /// Determines how EMF+ Dual metafiles should be rendered
        /// </summary>
        /// <value>Determines how EMF+ Dual metafiles should be rendered</value>    
        public string EmfPlusDualRenderingMode { get; set; }

        /// <summary>
        /// Determines how metafile images should be rendered
        /// </summary>
        /// <value>Determines how metafile images should be rendered</value>    
        public string RenderingMode { get; set; }

        /// <summary>
        /// Determines how WMF metafiles with embedded EMF metafiles should be rendered
        /// </summary>
        /// <value>Determines how WMF metafiles with embedded EMF metafiles should be rendered</value>    
        public bool? UseEmfEmbeddedToWmf { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MetafileRenderingOptionsData {\n");
          sb.Append("  EmfPlusDualRenderingMode: ").Append(EmfPlusDualRenderingMode).Append("\n");
          sb.Append("  RenderingMode: ").Append(RenderingMode).Append("\n");
          sb.Append("  UseEmfEmbeddedToWmf: ").Append(UseEmfEmbeddedToWmf).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
