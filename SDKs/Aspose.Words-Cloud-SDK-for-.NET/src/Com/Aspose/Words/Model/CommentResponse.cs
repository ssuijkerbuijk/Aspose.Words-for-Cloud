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
  public class CommentResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Comment
        /// </summary>    
        public Comment Comment { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CommentResponse {\n");
          sb.Append("  Comment: ").Append(Comment).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
