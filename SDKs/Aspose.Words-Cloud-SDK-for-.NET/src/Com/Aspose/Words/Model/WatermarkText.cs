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
  public class WatermarkText 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkText" /> class.
        /// </summary>
        /// <param name="Text">Text.</param>
        /// <param name="RotationAngle">RotationAngle.</param>
        public WatermarkText(string Text = default(string), double? RotationAngle = default(double?))
        {
                        this.Text = Text;
                        this.RotationAngle = RotationAngle;
        }

        /// <summary>
        /// Gets or sets Text
        /// </summary>    
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets RotationAngle
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
          sb.Append("  Text: ").Append(Text).Append("\n");
          sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
