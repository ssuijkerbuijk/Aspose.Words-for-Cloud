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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/tables/{0}
  /// </summary>  
  public class TableResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Table.
        /// </summary>  
        public Table Table { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableResponse {\n");
          sb.Append("  Table: ").Append(this.Table).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
