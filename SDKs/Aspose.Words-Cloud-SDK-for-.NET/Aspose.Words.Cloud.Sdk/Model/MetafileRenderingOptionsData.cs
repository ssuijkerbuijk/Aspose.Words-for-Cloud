namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// container class for options of metafile rendering
  /// </summary>  
  public class MetafileRenderingOptionsData 
  {                       
        /// <summary>
        /// Determines how EMF+ Dual metafiles should be rendered
        /// </summary>  
        public string EmfPlusDualRenderingMode { get; set; }

        /// <summary>
        /// Determines how metafile images should be rendered
        /// </summary>  
        public string RenderingMode { get; set; }

        /// <summary>
        /// Determines how WMF metafiles with embedded EMF metafiles should be rendered
        /// </summary>  
        public bool? UseEmfEmbeddedToWmf { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class MetafileRenderingOptionsData {\n");
          sb.Append("  EmfPlusDualRenderingMode: ").Append(this.EmfPlusDualRenderingMode).Append("\n");
          sb.Append("  RenderingMode: ").Append(this.RenderingMode).Append("\n");
          sb.Append("  UseEmfEmbeddedToWmf: ").Append(this.UseEmfEmbeddedToWmf).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
