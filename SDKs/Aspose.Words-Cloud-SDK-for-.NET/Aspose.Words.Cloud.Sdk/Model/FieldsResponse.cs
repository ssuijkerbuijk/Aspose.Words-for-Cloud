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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/{nodePath}/fields
  /// </summary>  
  public class FieldsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Collection of fields.
        /// </summary>  
        public FieldCollection Fields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FieldsResponse {\n");
          sb.Append("  Fields: ").Append(this.Fields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
