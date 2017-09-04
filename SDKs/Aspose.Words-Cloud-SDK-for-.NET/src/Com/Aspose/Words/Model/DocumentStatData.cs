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
  /// 
  /// </summary>  
  public class DocumentStatData 
  {                       
        /// <summary>
        /// Gets or sets WordCount
        /// </summary>    
        public int? WordCount { get; set; }

        /// <summary>
        /// Gets or sets ParagraphCount
        /// </summary>    
        public int? ParagraphCount { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>    
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets FootnotesStatData
        /// </summary>    
        public FootnotesStatData FootnotesStatData { get; set; }

        /// <summary>
        /// Gets or sets PageStatData
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
