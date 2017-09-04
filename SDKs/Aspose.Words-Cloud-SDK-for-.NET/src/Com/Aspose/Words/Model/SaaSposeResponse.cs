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
  public class SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Code
        /// </summary>    
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets Status
        /// </summary>    
        public string Status { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaaSposeResponse {\n");
          sb.Append("  Code: ").Append(Code).Append("\n");
          sb.Append("  Status: ").Append(Status).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
