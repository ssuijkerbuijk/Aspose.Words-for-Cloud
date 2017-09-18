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
  /// Utility class for {System.Drawing.Color} serialization
  /// </summary>  
  public class XmlColor 
  {                       
        /// <summary>
        /// HTML string color representation
        /// </summary>  
        public string Web { get; set; }

        /// <summary>
        /// Alpha component of color structure
        /// </summary>  
        public int? Alpha { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class XmlColor {\n");
          sb.Append("  Web: ").Append(this.Web).Append("\n");
          sb.Append("  Alpha: ").Append(this.Alpha).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
