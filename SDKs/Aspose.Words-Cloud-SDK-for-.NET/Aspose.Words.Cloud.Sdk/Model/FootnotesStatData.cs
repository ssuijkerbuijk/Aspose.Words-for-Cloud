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
  /// Container for the footnotes statistical data
  /// </summary>  
  public class FootnotesStatData 
  {                       
        /// <summary>
        /// Total count of words in footnotes
        /// </summary>  
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in footnotes
        /// </summary>  
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FootnotesStatData {\n");
          sb.Append("  WordCount: ").Append(this.WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(this.ParagraphCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
