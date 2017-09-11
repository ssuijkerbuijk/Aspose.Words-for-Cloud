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
  /// response of the modification operations for the revisions collection (now these are acceptAll and rejectAll)
  /// </summary>  
  public class RevisionsModificationResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// result of the modification operations for the revisions collection
        /// </summary>
        /// <value>result of the modification operations for the revisions collection</value>    
        public ModificationOperationResult Result { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RevisionsModificationResponse {\n");
          sb.Append("  Result: ").Append(Result).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
