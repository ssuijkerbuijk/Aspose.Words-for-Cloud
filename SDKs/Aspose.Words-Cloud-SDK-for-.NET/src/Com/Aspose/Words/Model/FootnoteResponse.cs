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
  public class FootnoteResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Footnote
        /// </summary>    
        public Footnote Footnote { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FootnoteResponse {\n");
          sb.Append("  Footnote: ").Append(Footnote).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
