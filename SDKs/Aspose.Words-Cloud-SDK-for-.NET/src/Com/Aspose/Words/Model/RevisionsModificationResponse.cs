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
  public class RevisionsModificationResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Result
        /// </summary>    
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
