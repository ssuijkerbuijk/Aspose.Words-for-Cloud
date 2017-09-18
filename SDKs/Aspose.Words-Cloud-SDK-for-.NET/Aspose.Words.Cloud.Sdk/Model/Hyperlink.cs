namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Hyperlink element.
  /// </summary>  
  public class Hyperlink 
  {                       
        /// <summary>
        /// Hypelink's display text
        /// </summary>  
        public string DisplayText { get; set; }

        /// <summary>
        /// Value
        /// </summary>  
        public string Value { get; set; }

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
          sb.Append("class Hyperlink {\n");
          sb.Append("  DisplayText: ").Append(this.DisplayText).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
