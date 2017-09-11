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
  /// Container for the footnotes statistical data
  /// </summary>  
  public class FootnotesStatData 
  {                       
        /// <summary>
        /// Total count of words in footnotes
        /// </summary>
        /// <value>Total count of words in footnotes</value>    
        public int? WordCount { get; set; }

        /// <summary>
        /// Total count of paragraphs in footnotes
        /// </summary>
        /// <value>Total count of paragraphs in footnotes</value>    
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FootnotesStatData {\n");
          sb.Append("  WordCount: ").Append(WordCount).Append("\n");
          sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
