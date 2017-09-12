namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Words document property DTO.
  /// </summary>  
  public class DocumentProperty 
  {                       
        /// <summary>
        /// Name of the document property.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// String value of the document property.
        /// </summary>  
        public string Value { get; set; }

        /// <summary>
        /// Flag indicates whether the property is built-in or not.  If true the property is built-in, if false the property is custom.
        /// </summary>  
        public bool? BuiltIn { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentProperty {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  BuiltIn: ").Append(this.BuiltIn).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
