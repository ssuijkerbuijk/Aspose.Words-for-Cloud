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
  /// Container for the document&#39;s statistical data
  /// </summary>  
  public class DocumentStatData 
  {                       
        /// <summary>
        /// Total count of words in the document
        /// </summary>
        /// <value>Total count of words in the document</value>    
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in the document
        /// </summary>
        /// <value>Total count of paragraphs in the document</value>    
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Total count of pages in the document
        /// </summary>
        /// <value>Total count of pages in the document</value>    
        public int? PageCount { get; set; }

        /// <summary>
        /// Detailed statistics of footnotes
        /// </summary>
        /// <value>Detailed statistics of footnotes</value>    
        public FootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Detailed statistics of all pages
        /// </summary>
        /// <value>Detailed statistics of all pages</value>    
        public List<PageStatData> PageStatData { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentStatData {\n");
          sb.Append("  WordCount: ").Append(WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
          sb.Append("  PageCount: ").Append(PageCount).Append("\n");
          sb.Append("  FootnotesStatData: ").Append(FootnotesStatData).Append("\n");
          sb.Append("  PageStatData: ").Append(PageStatData).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
