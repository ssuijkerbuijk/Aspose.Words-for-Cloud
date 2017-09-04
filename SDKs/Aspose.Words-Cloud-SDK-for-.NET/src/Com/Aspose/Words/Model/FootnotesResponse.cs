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
  public class FootnotesResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Footnotes
        /// </summary>    
        public FootnoteCollectionDto Footnotes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FootnotesResponse {\n");
          sb.Append("  Footnotes: ").Append(Footnotes).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
