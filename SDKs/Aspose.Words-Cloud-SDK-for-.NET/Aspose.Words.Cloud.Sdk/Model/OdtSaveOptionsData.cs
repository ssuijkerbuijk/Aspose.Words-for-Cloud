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
  /// container class for odt/ott save options
  /// </summary>  
  public class OdtSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>  
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Specifies whether export should correspond to ODT specification 1.1 strictly
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
          sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
          sb.Append("  IsStrictSchema11: ").Append(this.IsStrictSchema11).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
