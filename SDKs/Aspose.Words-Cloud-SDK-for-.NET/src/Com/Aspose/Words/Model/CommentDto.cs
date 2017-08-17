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
        /// Initializes a new instance of the <see cref="CommentDto" /> class.
        /// </summary>
        /// <param name="RangeStart">RangeStart.</param>
        /// <param name="RangeEnd">RangeEnd.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Initial">Initial.</param>
        /// <param name="DateTime">DateTime.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Content">Content.</param>
        /// <param name="Link">Link.</param>
        public CommentDto(DocumentPositionDto RangeStart = default(DocumentPositionDto), DocumentPositionDto RangeEnd = default(DocumentPositionDto), string Author = default(string), string Initial = default(string), DateTime? DateTime = default(DateTime?), string Text = default(string), StoryChildNodes Content = default(StoryChildNodes), WordsApiLink Link = default(WordsApiLink))
        {
                        this.RangeStart = RangeStart;
                        this.RangeEnd = RangeEnd;
                        this.Author = Author;
                        this.Initial = Initial;
                        this.DateTime = DateTime;
                        this.Text = Text;
                        this.Content = Content;
                        this.Link = Link;
        }

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
