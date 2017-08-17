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
  public class PageNumber 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="PageNumber" /> class.
        /// </summary>
        /// <param name="Format">Format.</param>
        /// <param name="Alignment">Alignment.</param>
        /// <param name="IsTop">IsTop.</param>
        /// <param name="SetPageNumberOnFirstPage">SetPageNumberOnFirstPage.</param>
        public PageNumber(string Format = default(string), string Alignment = default(string), bool? IsTop = default(bool?), bool? SetPageNumberOnFirstPage = default(bool?))
        {
                        this.Format = Format;
                        this.Alignment = Alignment;
                        this.IsTop = IsTop;
                        this.SetPageNumberOnFirstPage = SetPageNumberOnFirstPage;
        }

        /// <summary>
        /// Gets or sets Format
        /// </summary>    
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets Alignment
        /// </summary>    
        public string Alignment { get; set; }

        /// <summary>
        /// Gets or sets IsTop
        /// </summary>    
        public bool? IsTop { get; set; }

        /// <summary>
        /// Gets or sets SetPageNumberOnFirstPage
        /// </summary>    
        public bool? SetPageNumberOnFirstPage { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PageNumber {\n");
          sb.Append("  Format: ").Append(Format).Append("\n");
          sb.Append("  Alignment: ").Append(Alignment).Append("\n");
          sb.Append("  IsTop: ").Append(IsTop).Append("\n");
          sb.Append("  SetPageNumberOnFirstPage: ").Append(SetPageNumberOnFirstPage).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
