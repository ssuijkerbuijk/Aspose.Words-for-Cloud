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
  /// This response should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/OfficeMathObjects
  /// </summary>  
  public class OfficeMathObjectsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Collection of OfficeMath objects.
        /// </summary>  
        public OfficeMathObjectsCollection OfficeMathObjects { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OfficeMathObjectsResponse {\n");
          sb.Append("  OfficeMathObjects: ").Append(this.OfficeMathObjects).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
