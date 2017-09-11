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
  /// Words document property DTO.
  /// </summary>  
  public class DocumentProperty 
  {                       
        /// <summary>
        /// Name of the document property.
        /// </summary>
        /// <value>Name of the document property.</value>    
        public string Name { get; set; }

        /// <summary>
        /// String value of the document property.
        /// </summary>
        /// <value>String value of the document property.</value>    
        public string Value { get; set; }

        /// <summary>
        /// Flag indicates whether the property is built-in or not.  If true the property is built-in, if false the property is custom.
        /// </summary>
        /// <value>Flag indicates whether the property is built-in or not.  If true the property is built-in, if false the property is custom.</value>    
        public bool? BuiltIn { get; set; }

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
          sb.Append("class DocumentProperty {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Value: ").Append(Value).Append("\n");
          sb.Append("  BuiltIn: ").Append(BuiltIn).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
