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
  /// Collection of borders.
  /// </summary>  
  public class BordersCollection 
  {                       
        /// <summary>
        /// Collection of comments
        /// </summary>  
        public List<Border> List { get; set; }

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
          sb.Append("class BordersCollection {\n");
          sb.Append("  List: ").Append(this.List).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
