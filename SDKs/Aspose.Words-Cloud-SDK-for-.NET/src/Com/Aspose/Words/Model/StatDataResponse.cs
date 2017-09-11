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
  /// Response for the request of the document&#39;s statistical data
  /// </summary>  
  public class StatDataResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Statistical data of the document
        /// </summary>
        /// <value>Statistical data of the document</value>    
        public DocumentStatData StatData { get; set; }

        /// <summary>
        /// Link to the document
        /// </summary>
        /// <value>Link to the document</value>    
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
