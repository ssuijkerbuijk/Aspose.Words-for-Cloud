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
  public class Hyperlink 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperlink" /> class.
        /// </summary>
        /// <param name="DisplayText">DisplayText.</param>
        /// <param name="Value">Value.</param>
        /// <param name="Link">Link.</param>
        public Hyperlink(string DisplayText = default(string), string Value = default(string), WordsApiLink Link = default(WordsApiLink))
        {
                        this.DisplayText = DisplayText;
                        this.Value = Value;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets DisplayText
        /// </summary>    
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or sets Value
        /// </summary>    
        public string Value { get; set; }

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
          sb.Append("class Hyperlink {\n");
          sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
          sb.Append("  Value: ").Append(Value).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
