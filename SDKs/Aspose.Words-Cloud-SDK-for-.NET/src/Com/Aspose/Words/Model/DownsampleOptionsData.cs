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
  public class DownsampleOptionsData 
  {                       
        /// <summary>
        /// Gets or sets DownsampleImages
        /// </summary>    
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Gets or sets Resolution
        /// </summary>    
        public int? Resolution { get; set; }

        /// <summary>
        /// Gets or sets ResolutionThreshold
        /// </summary>    
        public int? ResolutionThreshold { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DownsampleOptionsData {\n");
          sb.Append("  DownsampleImages: ").Append(DownsampleImages).Append("\n");
          sb.Append("  Resolution: ").Append(Resolution).Append("\n");
          sb.Append("  ResolutionThreshold: ").Append(ResolutionThreshold).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
