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
  /// Represents a position in the document tree.
  /// </summary>  
  public class DocumentPosition 
  {                       
        /// <summary>
        /// Link to  node.
        /// </summary>  
        public NodeLink Node { get; set; }

        /// <summary>
        /// Offset into the node.
        /// </summary>  
        public int? Offset { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentPosition {\n");
          sb.Append("  Node: ").Append(this.Node).Append("\n");
          sb.Append("  Offset: ").Append(this.Offset).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
