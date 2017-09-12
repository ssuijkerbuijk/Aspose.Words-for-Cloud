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
  /// Container for the document&#39;s statistical data
  /// </summary>  
  public class DocumentStatData 
  {                       
        /// <summary>
        /// Total count of words in the document
        /// </summary>  
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in the document
        /// </summary>  
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Total count of pages in the document
        /// </summary>  
        public int? PageCount { get; set; }

        /// <summary>
        /// Detailed statistics of footnotes
        /// </summary>  
        public FootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Detailed statistics of all pages
        /// </summary>  
        public List<PageStatData> PageStatData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentStatData {\n");
          sb.Append("  WordCount: ").Append(this.WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(this.ParagraphCount).Append("\n");
          sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
          sb.Append("  FootnotesStatData: ").Append(this.FootnotesStatData).Append("\n");
          sb.Append("  PageStatData: ").Append(this.PageStatData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
