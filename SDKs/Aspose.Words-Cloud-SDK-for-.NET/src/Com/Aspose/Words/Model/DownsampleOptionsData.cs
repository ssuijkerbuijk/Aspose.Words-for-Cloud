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
  /// Container class for Downsample options
  /// </summary>  
  public class DownsampleOptionsData 
  {                       
        /// <summary>
        /// Specifies whether images should be downsampled.
        /// </summary>
        /// <value>Specifies whether images should be downsampled.</value>    
        public bool? DownsampleImages { get; set; }

        /// <summary>
        /// Specifies the resolution in pixels per inch which the images should be downsampled to.
        /// </summary>
        /// <value>Specifies the resolution in pixels per inch which the images should be downsampled to.</value>    
        public int? Resolution { get; set; }

        /// <summary>
        /// Specifies the threshold resolution in pixels per inch.  If resolution of an image in the document is less than threshold value,   the downsampling algorithm will not be applied.  A value of 0 means the threshold check is not used and all images that can be reduced in size are downsampled.
        /// </summary>
        /// <value>Specifies the threshold resolution in pixels per inch.  If resolution of an image in the document is less than threshold value,   the downsampling algorithm will not be applied.  A value of 0 means the threshold check is not used and all images that can be reduced in size are downsampled.</value>    
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
