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
  /// Container for the page&#39;s statistical data
  /// </summary>  
  public class PageStatData 
  {                       
        /// <summary>
        /// Page number
        /// </summary>
        /// <value>Page number</value>    
        public int? PageNumber { get; set; }

        /// <summary>
        /// Total count of words in the page
        /// </summary>
        /// <value>Total count of words in the page</value>    
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in the page
        /// </summary>
        /// <value>Total count of paragraphs in the page</value>    
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Detailed statistics of footnotes
        /// </summary>
        /// <value>Detailed statistics of footnotes</value>    
        public FootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageStatData {\n");
          sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
          sb.Append("  WordCount: ").Append(WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
          sb.Append("  FootnotesStatData: ").Append(FootnotesStatData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
