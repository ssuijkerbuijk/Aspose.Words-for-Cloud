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
  /// Container for the page&#39;s statistical data
  /// </summary>  
  public class PageStatData 
  {                       
        /// <summary>
        /// Page number
        /// </summary>  
        public int? PageNumber { get; set; }

        /// <summary>
        /// Total count of words in the page
        /// </summary>  
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in the page
        /// </summary>  
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Detailed statistics of footnotes
        /// </summary>  
        public FootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageStatData {\n");
          sb.Append("  PageNumber: ").Append(this.PageNumber).Append("\n");
          sb.Append("  WordCount: ").Append(this.WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(this.ParagraphCount).Append("\n");
          sb.Append("  FootnotesStatData: ").Append(this.FootnotesStatData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
