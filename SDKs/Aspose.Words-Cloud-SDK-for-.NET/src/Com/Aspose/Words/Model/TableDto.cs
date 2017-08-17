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
  public class TableDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="TableDto" /> class.
        /// </summary>
        /// <param name="TableRowList">TableRowList.</param>
        /// <param name="TableProperties">TableProperties.</param>
        /// <param name="NodeId">NodeId.</param>
        /// <param name="Link">Link.</param>
        public TableDto(List<TableRowDto> TableRowList = default(List<TableRowDto>), TablePropertiesDto TableProperties = default(TablePropertiesDto), string NodeId = default(string), WordsApiLink Link = default(WordsApiLink))
        {
                        this.TableRowList = TableRowList;
                        this.TableProperties = TableProperties;
                        this.NodeId = NodeId;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets TableRowList
        /// </summary>    
        public List<TableRowDto> TableRowList { get; set; }

        /// <summary>
        /// Gets or sets TableProperties
        /// </summary>    
        public TablePropertiesDto TableProperties { get; set; }

        /// <summary>
        /// Gets or sets NodeId
        /// </summary>    
        public string NodeId { get; set; }

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
          sb.Append("class TableDto {\n");
          sb.Append("  TableRowList: ").Append(TableRowList).Append("\n");
          sb.Append("  TableProperties: ").Append(TableProperties).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
