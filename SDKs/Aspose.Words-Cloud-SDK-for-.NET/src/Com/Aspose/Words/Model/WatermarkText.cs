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
  /// Class for insert watermark text request building.
  /// </summary>  
  public class WatermarkText 
  {                       
        /// <summary>
        /// The watermark text.
        /// </summary>
        /// <value>The watermark text.</value>    
        public string Text { get; set; }

        /// <summary>
        /// The watermark rotation angle.
        /// </summary>
        /// <value>The watermark rotation angle.</value>    
        public double? RotationAngle { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WatermarkText {\n");
          sb.Append("  Text: ").Append(Text).Append("\n");
          sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
