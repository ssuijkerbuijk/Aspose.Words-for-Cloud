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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/paragraphs/{0}/fields/{1}
  /// </summary>  
  public class FieldResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Field information
        /// </summary>  
        public Field Field { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FieldResponse {\n");
          sb.Append("  Field: ").Append(this.Field).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
