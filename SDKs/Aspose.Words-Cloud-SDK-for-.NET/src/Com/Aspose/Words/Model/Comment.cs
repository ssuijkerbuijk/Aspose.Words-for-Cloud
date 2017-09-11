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
  /// Comment.
  /// </summary>  
  public class Comment 
  {                       
        /// <summary>
        /// Link to comment range start node.
        /// </summary>
        /// <value>Link to comment range start node.</value>    
        public DocumentPosition RangeStart { get; set; }

        /// <summary>
        /// Link to comment range end node.
        /// </summary>
        /// <value>Link to comment range end node.</value>    
        public DocumentPosition RangeEnd { get; set; }

        /// <summary>
        /// Returns or sets the author name for a comment.
        /// </summary>
        /// <value>Returns or sets the author name for a comment.</value>    
        public string Author { get; set; }

        /// <summary>
        /// Returns or sets the initials of the user associated with a specific comment.
        /// </summary>
        /// <value>Returns or sets the initials of the user associated with a specific comment.</value>    
        public string Initial { get; set; }

        /// <summary>
        /// Gets the date and time that the comment was made.
        /// </summary>
        /// <value>Gets the date and time that the comment was made.</value>    
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// This is a convenience property that allows to easily get or set text of the comment.
        /// </summary>
        /// <value>This is a convenience property that allows to easily get or set text of the comment.</value>    
        public string Text { get; set; }

        /// <summary>
        /// Content of comment
        /// </summary>
        /// <value>Content of comment</value>    
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Comment {\n");
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
