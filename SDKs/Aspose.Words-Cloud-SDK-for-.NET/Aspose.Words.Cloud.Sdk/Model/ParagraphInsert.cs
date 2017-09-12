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
  /// Paragraph element
  /// </summary>  
  public class ParagraphInsert 
  {                       
        /// <summary>
        /// Paragraph's text
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ParagraphInsert {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
