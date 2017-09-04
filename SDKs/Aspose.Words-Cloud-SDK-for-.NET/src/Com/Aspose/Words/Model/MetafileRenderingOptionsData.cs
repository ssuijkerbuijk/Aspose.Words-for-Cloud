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
  public class MetafileRenderingOptionsData 
  {                       
        /// <summary>
        /// Gets or sets EmfPlusDualRenderingMode
        /// </summary>    
        public string EmfPlusDualRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets RenderingMode
        /// </summary>    
        public string RenderingMode { get; set; }

        /// <summary>
        /// Gets or sets UseEmfEmbeddedToWmf
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
          sb.Append("  EmfPlusDualRenderingMode: ").Append(EmfPlusDualRenderingMode).Append("\n");
          sb.Append("  RenderingMode: ").Append(RenderingMode).Append("\n");
          sb.Append("  UseEmfEmbeddedToWmf: ").Append(UseEmfEmbeddedToWmf).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
