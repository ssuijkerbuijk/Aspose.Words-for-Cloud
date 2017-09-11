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
  /// Represents all formatting for a table row.
  /// </summary>  
  public class TableRowFormat 
  {                       
        /// <summary>
        /// Gets or sets the rule for determining the height of the table row.
        /// </summary>
        /// <value>Gets or sets the rule for determining the height of the table row.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HeightRuleEnum
        {
            
            /// <summary>
            /// Enum AtLeast for "AtLeast"
            /// </summary>            
            AtLeast,
            
            /// <summary>
            /// Enum Exactly for "Exactly"
            /// </summary>            
            Exactly,
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>            
            Auto
        }

        /// <summary>
        /// Gets or sets the rule for determining the height of the table row.
        /// </summary>
        /// <value>Gets or sets the rule for determining the height of the table row.</value>
        public HeightRuleEnum? HeightRule { get; set; }

        /// <summary>
        /// Gets or sets the height of the table row in points.
        /// </summary>
        /// <value>Gets or sets the height of the table row in points.</value>    
        public double? Height { get; set; }

        /// <summary>
        /// True if the text in a table row is allowed to split across a page break.
        /// </summary>
        /// <value>True if the text in a table row is allowed to split across a page break.</value>    
        public bool? AllowBreakAcrossPages { get; set; }

        /// <summary>
        /// True if the row is repeated as a table heading on every page when the table spans more than one page.
        /// </summary>
        /// <value>True if the row is repeated as a table heading on every page when the table spans more than one page.</value>    
        public bool? HeadingFormat { get; set; }

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
          sb.Append("class TableRowFormat {\n");
          sb.Append("  Height: ").Append(Height).Append("\n");
          sb.Append("  HeightRule: ").Append(HeightRule).Append("\n");
          sb.Append("  AllowBreakAcrossPages: ").Append(AllowBreakAcrossPages).Append("\n");
          sb.Append("  HeadingFormat: ").Append(HeadingFormat).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
