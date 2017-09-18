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
  /// This resonse should be returned by the service when handling:  GET {nodeWithBorders}/borders.
  /// </summary>  
  public class BordersResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Table.
        /// </summary>  
        public BordersCollection Borders { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BordersResponse {\n");
          sb.Append("  Borders: ").Append(this.Borders).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
