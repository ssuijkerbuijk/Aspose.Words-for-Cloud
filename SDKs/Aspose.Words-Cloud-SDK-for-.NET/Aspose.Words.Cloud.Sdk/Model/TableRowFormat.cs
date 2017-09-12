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
        public double? Height { get; set; }

        /// <summary>
        /// True if the text in a table row is allowed to split across a page break.
        /// </summary>  
        public bool? AllowBreakAcrossPages { get; set; }

        /// <summary>
        /// True if the row is repeated as a table heading on every page when the table spans more than one page.
        /// </summary>  
        public bool? HeadingFormat { get; set; }

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
          sb.Append("class TableRowFormat {\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  HeightRule: ").Append(this.HeightRule).Append("\n");
          sb.Append("  AllowBreakAcrossPages: ").Append(this.AllowBreakAcrossPages).Append("\n");
          sb.Append("  HeadingFormat: ").Append(this.HeadingFormat).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
