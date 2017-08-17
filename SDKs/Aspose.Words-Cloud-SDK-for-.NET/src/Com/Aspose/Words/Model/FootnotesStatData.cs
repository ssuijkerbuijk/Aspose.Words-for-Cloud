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
  public class FootnotesStatData 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="FootnotesStatData" /> class.
        /// </summary>
        /// <param name="WordCount">WordCount.</param>
        /// <param name="ParagraphCount">ParagraphCount.</param>
        public FootnotesStatData(int? WordCount = default(int?), int? ParagraphCount = default(int?))
        {
                        this.WordCount = WordCount;
                        this.ParagraphCount = ParagraphCount;
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
