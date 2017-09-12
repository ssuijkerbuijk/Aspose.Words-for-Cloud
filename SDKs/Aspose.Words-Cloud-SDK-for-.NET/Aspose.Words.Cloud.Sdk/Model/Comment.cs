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
  /// Comment.
  /// </summary>  
  public class Comment 
  {                       
        /// <summary>
        /// Link to comment range start node.
        /// </summary>  
        public DocumentPosition RangeStart { get; set; }

        /// <summary>
        /// Link to comment range end node.
        /// </summary>  
        public DocumentPosition RangeEnd { get; set; }

        /// <summary>
        /// Returns or sets the author name for a comment.
        /// </summary>  
        public string Author { get; set; }

        /// <summary>
        /// Returns or sets the initials of the user associated with a specific comment.
        /// </summary>  
        public string Initial { get; set; }

        /// <summary>
        /// Gets the date and time that the comment was made.
        /// </summary>  
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// This is a convenience property that allows to easily get or set text of the comment.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Content of comment
        /// </summary>  
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Comment {\n");
          sb.Append("  RangeStart: ").Append(this.RangeStart).Append("\n");
          sb.Append("  RangeEnd: ").Append(this.RangeEnd).Append("\n");
          sb.Append("  Author: ").Append(this.Author).Append("\n");
          sb.Append("  Initial: ").Append(this.Initial).Append("\n");
          sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Content: ").Append(this.Content).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
