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
  /// Container class for tiff save options.
  /// </summary>  
  public class TiffSaveOptionsData : ImageSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies method used while converting images to 1 bpp format.
        /// </summary>
        /// <value>Specifies method used while converting images to 1 bpp format.</value>    
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Type of compression.
        /// </summary>
        /// <value>Type of compression.</value>    
        public string TiffCompression { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TiffSaveOptionsData {\n");
          sb.Append("  TiffBinarizationMethod: ").Append(TiffBinarizationMethod).Append("\n");
          sb.Append("  TiffCompression: ").Append(TiffCompression).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
