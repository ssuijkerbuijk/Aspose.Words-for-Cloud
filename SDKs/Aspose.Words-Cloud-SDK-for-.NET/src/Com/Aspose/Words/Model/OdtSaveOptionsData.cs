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
  public class OdtSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets PrettyFormat
        /// </summary>    
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Gets or sets IsStrictSchema11
        /// </summary>    
        public bool? IsStrictSchema11 { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OdtSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(PrettyFormat).Append("\n");
          sb.Append("  IsStrictSchema11: ").Append(IsStrictSchema11).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
