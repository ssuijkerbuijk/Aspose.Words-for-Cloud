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
  public class DocumentProperty 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentProperty" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Value">Value.</param>
        /// <param name="BuiltIn">BuiltIn.</param>
        /// <param name="Link">Link.</param>
        public DocumentProperty(string Name = default(string), string Value = default(string), bool? BuiltIn = default(bool?), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Name = Name;
                        this.Value = Value;
                        this.BuiltIn = BuiltIn;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>    
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Value
        /// </summary>    
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets BuiltIn
        /// </summary>    
        public bool? BuiltIn { get; set; }

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
