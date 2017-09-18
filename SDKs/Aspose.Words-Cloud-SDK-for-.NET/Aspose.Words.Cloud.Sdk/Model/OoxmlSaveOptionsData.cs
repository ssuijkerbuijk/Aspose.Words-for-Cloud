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
  /// container class for docx/docm/dotx/dotm/flatopc save options
  /// </summary>  
  public class OoxmlSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>  
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Specifies the OOXML version for the output document
        /// </summary>  
        public string Compliance { get; set; }

        /// <summary>
        /// Specifies a password to encrypt document using ECMA376 Standard encryption algorithm
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OoxmlSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
