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
  /// container class for wml save options
  /// </summary>  
  public class WordMLSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>  
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WordMLSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
