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
  public class ReplaceTextRequest 
  {                       
        /// <summary>
        /// Gets or sets OldValue
        /// </summary>    
        public string OldValue { get; set; }

        /// <summary>
        /// Gets or sets NewValue
        /// </summary>    
        public string NewValue { get; set; }

        /// <summary>
        /// Gets or sets IsMatchCase
        /// </summary>    
        public bool? IsMatchCase { get; set; }

        /// <summary>
        /// Gets or sets IsMatchWholeWord
        /// </summary>    
        public bool? IsMatchWholeWord { get; set; }

        /// <summary>
        /// Gets or sets IsOldValueRegex
        /// </summary>    
        public bool? IsOldValueRegex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ReplaceTextRequest {\n");
          sb.Append("  OldValue: ").Append(OldValue).Append("\n");
          sb.Append("  NewValue: ").Append(NewValue).Append("\n");
          sb.Append("  IsMatchCase: ").Append(IsMatchCase).Append("\n");
          sb.Append("  IsMatchWholeWord: ").Append(IsMatchWholeWord).Append("\n");
          sb.Append("  IsOldValueRegex: ").Append(IsOldValueRegex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
