namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Class for insert watermark text request building.
  /// </summary>  
  public class WatermarkText 
  {                       
        /// <summary>
        /// The watermark text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// The watermark rotation angle.
        /// </summary>  
        public double? RotationAngle { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WatermarkText {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
