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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/comments/0
  /// </summary>  
  public class CommentResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Comment information
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
          sb.Append("  Comment: ").Append(this.Comment).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
