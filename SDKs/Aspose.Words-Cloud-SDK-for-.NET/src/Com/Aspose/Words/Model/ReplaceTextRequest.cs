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
  /// Class for document replace text request building.
  /// </summary>  
  public class ReplaceTextRequest 
  {                       
        /// <summary>
        /// Old text value (or regex pattern {Aspose.Words.Cloud.DTO.Replace.ReplaceTextRequest.IsOldValueRegex}) to replace.
        /// </summary>
        /// <value>Old text value (or regex pattern {Aspose.Words.Cloud.DTO.Replace.ReplaceTextRequest.IsOldValueRegex}) to replace.</value>    
        public string OldValue { get; set; }

        /// <summary>
        /// New text value to replace by.
        /// </summary>
        /// <value>New text value to replace by.</value>    
        public string NewValue { get; set; }

        /// <summary>
        /// Flag, true means the search is case-sensitive; false means the search is not case-sensitive.
        /// </summary>
        /// <value>Flag, true means the search is case-sensitive; false means the search is not case-sensitive.</value>    
        public bool? IsMatchCase { get; set; }

        /// <summary>
        /// Flag, means that only whole word matched are replaced.
        /// </summary>
        /// <value>Flag, means that only whole word matched are replaced.</value>    
        public bool? IsMatchWholeWord { get; set; }

        /// <summary>
        /// Flag, means that {Aspose.Words.Cloud.DTO.Replace.ReplaceTextRequest.OldValue} contains regex expression.
        /// </summary>
        /// <value>Flag, means that {Aspose.Words.Cloud.DTO.Replace.ReplaceTextRequest.OldValue} contains regex expression.</value>    
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
