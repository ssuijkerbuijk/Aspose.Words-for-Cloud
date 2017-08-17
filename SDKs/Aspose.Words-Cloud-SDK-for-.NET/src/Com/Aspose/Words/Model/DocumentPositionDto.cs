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
  public class DocumentPositionDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentPositionDto" /> class.
        /// </summary>
        /// <param name="Node">Node.</param>
        /// <param name="Offset">Offset.</param>
        public DocumentPositionDto(NodeLink Node = default(NodeLink), int? Offset = default(int?))
        {
                        this.Node = Node;
                        this.Offset = Offset;
        }

        /// <summary>
        /// Gets or sets Node
        /// </summary>    
        public NodeLink Node { get; set; }

        /// <summary>
        /// Gets or sets Offset
        /// </summary>    
        public int? Offset { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentPositionDto {\n");
          sb.Append("  Node: ").Append(Node).Append("\n");
          sb.Append("  Offset: ").Append(Offset).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
