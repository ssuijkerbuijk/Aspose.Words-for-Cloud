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
        /// Initializes a new instance of the <see cref="DocumentStatData" /> class.
        /// </summary>
        /// <param name="WordCount">WordCount.</param>
        /// <param name="ParagraphCount">ParagraphCount.</param>
        /// <param name="PageCount">PageCount.</param>
        /// <param name="FootnotesStatData">FootnotesStatData.</param>
        /// <param name="PageStatData">PageStatData.</param>
        public DocumentStatData(int? WordCount = default(int?), int? ParagraphCount = default(int?), int? PageCount = default(int?), FootnotesStatData FootnotesStatData = default(FootnotesStatData), List<PageStatData> PageStatData = default(List<PageStatData>))
        {
                        this.WordCount = WordCount;
                        this.ParagraphCount = ParagraphCount;
                        this.PageCount = PageCount;
                        this.FootnotesStatData = FootnotesStatData;
                        this.PageStatData = PageStatData;
        }

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
