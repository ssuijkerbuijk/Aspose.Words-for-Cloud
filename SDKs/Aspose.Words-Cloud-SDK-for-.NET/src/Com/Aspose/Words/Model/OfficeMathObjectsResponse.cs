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
  /// This response should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/OfficeMathObjects
  /// </summary>  
  public class OfficeMathObjectsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Collection of OfficeMath objects.
        /// </summary>
        /// <value>Collection of OfficeMath objects.</value>    
        public OfficeMathObjectsCollection OfficeMathObjects { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OfficeMathObjectsResponse {\n");
          sb.Append("  OfficeMathObjects: ").Append(OfficeMathObjects).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
