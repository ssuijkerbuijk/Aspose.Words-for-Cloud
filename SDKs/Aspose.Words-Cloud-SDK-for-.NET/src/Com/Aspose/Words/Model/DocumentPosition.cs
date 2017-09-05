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
  public class DocumentPosition 
  {                       
        /// <summary>
        /// Gets or sets Node
        /// </summary>    
        public NodeLink Node { get; set; }

        /// <summary>
        /// Gets or sets Offset
        /// </summary>    
        public int? Offset { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentPosition {\n");
          sb.Append("  Node: ").Append(Node).Append("\n");
          sb.Append("  Offset: ").Append(Offset).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
