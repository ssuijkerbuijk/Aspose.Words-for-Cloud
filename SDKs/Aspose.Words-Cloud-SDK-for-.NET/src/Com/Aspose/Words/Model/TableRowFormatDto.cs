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
  public class TableRowFormatDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="TableRowFormatDto" /> class.
        /// </summary>
        /// <param name="Height">Height.</param>
        /// <param name="HeightRule">HeightRule.</param>
        /// <param name="AllowBreakAcrossPages">AllowBreakAcrossPages.</param>
        /// <param name="HeadingFormat">HeadingFormat.</param>
        /// <param name="Link">Link.</param>
        public TableRowFormatDto(double? Height = default(double?), HeightRuleEnum? HeightRule = default(HeightRuleEnum?), bool? AllowBreakAcrossPages = default(bool?), bool? HeadingFormat = default(bool?), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Height = Height;
                        this.HeightRule = HeightRule;
                        this.AllowBreakAcrossPages = AllowBreakAcrossPages;
                        this.HeadingFormat = HeadingFormat;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets HeightRule
        /// </summary>
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
        /// Gets or sets HeightRule
        /// </summary>
        public HeightRuleEnum? HeightRule { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>    
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets AllowBreakAcrossPages
        /// </summary>    
        public bool? AllowBreakAcrossPages { get; set; }

        /// <summary>
        /// Gets or sets HeadingFormat
        /// </summary>    
        public bool? HeadingFormat { get; set; }

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
          sb.Append("class TableRowFormatDto {\n");
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
