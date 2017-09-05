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
  public class Field 
  {                       
        /// <summary>
        /// Gets or sets Result
        /// </summary>    
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets LocaleId
        /// </summary>    
        public string LocaleId { get; set; }

        /// <summary>
        /// Gets or sets FieldCode
        /// </summary>    
        public string FieldCode { get; set; }

        /// <summary>
        /// Gets or sets NodeId
        /// </summary>    
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Field {\n");
          sb.Append("  Result: ").Append(Result).Append("\n");
          sb.Append("  LocaleId: ").Append(LocaleId).Append("\n");
          sb.Append("  FieldCode: ").Append(FieldCode).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
