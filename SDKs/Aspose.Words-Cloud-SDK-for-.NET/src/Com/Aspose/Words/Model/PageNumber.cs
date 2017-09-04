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
