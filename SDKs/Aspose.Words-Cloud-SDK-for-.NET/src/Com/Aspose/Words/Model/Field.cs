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
  /// Field
  /// </summary>  
  public class Field 
  {                       
        /// <summary>
        /// Field result
        /// </summary>
        /// <value>Field result</value>    
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets LCID of the field.
        /// </summary>
        /// <value>Gets or sets LCID of the field.</value>    
        public string LocaleId { get; set; }

        /// <summary>
        /// Field code
        /// </summary>
        /// <value>Field code</value>    
        public string FieldCode { get; set; }

        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>    
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
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
