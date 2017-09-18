namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Child nodes of {Aspose.Words.Story} or {Aspose.Words.InlineStory}
  /// </summary>  
  public class StoryChildNodes 
  {                       
        /// <summary>
        /// Child nodes.
        /// </summary>  
        public List<NodeLink> ChildNodes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StoryChildNodes {\n");
          sb.Append("  ChildNodes: ").Append(this.ChildNodes).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
