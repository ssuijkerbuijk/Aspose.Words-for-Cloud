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
  /// container class for docx/docm/dotx/dotm/flatopc save options
  /// </summary>  
  public class OoxmlSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>
        /// <value>Specifies whether or not use pretty formats output</value>    
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Specifies the OOXML version for the output document
        /// </summary>
        /// <value>Specifies the OOXML version for the output document</value>    
        public string Compliance { get; set; }

        /// <summary>
        /// Specifies a password to encrypt document using ECMA376 Standard encryption algorithm
        /// </summary>
        /// <value>Specifies a password to encrypt document using ECMA376 Standard encryption algorithm</value>    
        public string Password { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OoxmlSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(PrettyFormat).Append("\n");
          sb.Append("  Compliance: ").Append(Compliance).Append("\n");
          sb.Append("  Password: ").Append(Password).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
