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
  /// Class is used for insert page number request building.
  /// </summary>  
  public class PageNumber 
  {                       
        /// <summary>
        /// Page number format, e.g. \"{PAGE} of {NUMPAGES}\".
        /// </summary>
        /// <value>Page number format, e.g. \"{PAGE} of {NUMPAGES}\".</value>    
        public string Format { get; set; }

        /// <summary>
        /// Text alignment, possible values are left, right, center or justify.
        /// </summary>
        /// <value>Text alignment, possible values are left, right, center or justify.</value>    
        public string Alignment { get; set; }

        /// <summary>
        /// If true the page number is added at the top of the page, else at the bottom.
        /// </summary>
        /// <value>If true the page number is added at the top of the page, else at the bottom.</value>    
        public bool? IsTop { get; set; }

        /// <summary>
        /// If true the page number is added on first page too.
        /// </summary>
        /// <value>If true the page number is added on first page too.</value>    
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
