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
  public class SaveResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets SaveResult
        /// </summary>    
        public SaveResult SaveResult { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveResponse {\n");
          sb.Append("  SaveResult: ").Append(SaveResult).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
