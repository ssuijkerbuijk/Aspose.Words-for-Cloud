namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Class for document replace text request building.
  /// </summary>  
  public class ReplaceTextRequest 
  {                       
        /// <summary>
        /// Old text value (or regex pattern {Aspose.Words.Cloud.DTO.Replace.ReplaceTextRequest.IsOldValueRegex}) to replace.
        /// </summary>  
        public string OldValue { get; set; }

        /// <summary>
        /// New text value to replace by.
        /// </summary>  
        public string NewValue { get; set; }

        /// <summary>
        /// Flag, true means the search is case-sensitive; false means the search is not case-sensitive.
        /// </summary>  
        public bool? IsMatchCase { get; set; }

        /// <summary>
        /// Flag, means that only whole word matched are replaced.
        /// </summary>  
        public bool? IsMatchWholeWord { get; set; }

        /// <summary>
        /// Flag, means that {Aspose.Words.Cloud.DTO.Replace.ReplaceTextRequest.OldValue} contains regex expression.
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
          sb.Append("  OldValue: ").Append(this.OldValue).Append("\n");
          sb.Append("  NewValue: ").Append(this.NewValue).Append("\n");
          sb.Append("  IsMatchCase: ").Append(this.IsMatchCase).Append("\n");
          sb.Append("  IsMatchWholeWord: ").Append(this.IsMatchWholeWord).Append("\n");
          sb.Append("  IsOldValueRegex: ").Append(this.IsOldValueRegex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
