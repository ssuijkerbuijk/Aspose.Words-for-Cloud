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
  public class CommentsCollection 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentsCollection" /> class.
        /// </summary>
        /// <param name="CommentList">CommentList.</param>
        /// <param name="Link">Link.</param>
        public CommentsCollection(List<CommentDto> CommentList = default(List<CommentDto>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.CommentList = CommentList;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets CommentList
        /// </summary>    
        public List<CommentDto> CommentList { get; set; }

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
          sb.Append("class CommentsCollection {\n");
          sb.Append("  CommentList: ").Append(CommentList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
