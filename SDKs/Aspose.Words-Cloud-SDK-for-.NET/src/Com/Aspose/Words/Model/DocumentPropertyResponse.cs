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
  public class DocumentPropertyResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets DocumentProperty
        /// </summary>    
        public DocumentProperty DocumentProperty { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentPropertyResponse {\n");
          sb.Append("  DocumentProperty: ").Append(DocumentProperty).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
