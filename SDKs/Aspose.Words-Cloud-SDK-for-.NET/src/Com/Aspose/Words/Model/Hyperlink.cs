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
  /// Hyperlink element.
  /// </summary>  
  public class Hyperlink 
  {                       
        /// <summary>
        /// Hypelink's display text
        /// </summary>
        /// <value>Hypelink's display text</value>    
        public string DisplayText { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>    
        public string Value { get; set; }

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
          sb.Append("class Hyperlink {\n");
          sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
          sb.Append("  Value: ").Append(Value).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
