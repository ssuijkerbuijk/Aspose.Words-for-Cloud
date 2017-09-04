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
  public class CommentDto 
  {                       
        /// <summary>
        /// Gets or sets RangeStart
        /// </summary>    
        public DocumentPositionDto RangeStart { get; set; }

        /// <summary>
        /// Gets or sets RangeEnd
        /// </summary>    
        public DocumentPositionDto RangeEnd { get; set; }

        /// <summary>
        /// Gets or sets Author
        /// </summary>    
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets Initial
        /// </summary>    
        public string Initial { get; set; }

        /// <summary>
        /// Gets or sets DateTime
        /// </summary>    
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>    
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets Content
        /// </summary>    
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CommentDto {\n");
          sb.Append("  RangeStart: ").Append(RangeStart).Append("\n");
          sb.Append("  RangeEnd: ").Append(RangeEnd).Append("\n");
          sb.Append("  Author: ").Append(Author).Append("\n");
          sb.Append("  Initial: ").Append(Initial).Append("\n");
          sb.Append("  DateTime: ").Append(DateTime).Append("\n");
          sb.Append("  Text: ").Append(Text).Append("\n");
          sb.Append("  Content: ").Append(Content).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
