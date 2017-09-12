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
  /// This resonse should be returned by the service when handling:  GET {nodeWithBorders}/borders.
  /// </summary>  
  public class BorderResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Table.
        /// </summary>  
        public Border Border { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BorderResponse {\n");
          sb.Append("  Border: ").Append(this.Border).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
