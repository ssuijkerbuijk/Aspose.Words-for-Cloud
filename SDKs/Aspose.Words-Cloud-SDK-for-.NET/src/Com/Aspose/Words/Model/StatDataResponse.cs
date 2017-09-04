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
  public class StatDataResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets StatData
        /// </summary>    
        public DocumentStatData StatData { get; set; }

        /// <summary>
        /// Gets or sets DocumentLink
        /// </summary>    
        public FileLink DocumentLink { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StatDataResponse {\n");
          sb.Append("  StatData: ").Append(StatData).Append("\n");
          sb.Append("  DocumentLink: ").Append(DocumentLink).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
