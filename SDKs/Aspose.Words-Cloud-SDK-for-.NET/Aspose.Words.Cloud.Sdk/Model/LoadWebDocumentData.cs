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
  /// Contains data for load web document
  /// </summary>  
  public class LoadWebDocumentData 
  {                       
        /// <summary>
        /// Web document url
        /// </summary>  
        public string LoadingDocumentUrl { get; set; }

        /// <summary>
        /// Save options
        /// </summary>  
        public SaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LoadWebDocumentData {\n");
          sb.Append("  LoadingDocumentUrl: ").Append(this.LoadingDocumentUrl).Append("\n");
          sb.Append("  SaveOptions: ").Append(this.SaveOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
