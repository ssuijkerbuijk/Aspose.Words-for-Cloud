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
  /// container class for ps save options
  /// </summary>  
  public class PsSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Determines whether the document should be saved using a booklet printing layout
        /// </summary>  
        public bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PsSaveOptionsData {\n");
          sb.Append("  UseBookFoldPrintingSettings: ").Append(this.UseBookFoldPrintingSettings).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
