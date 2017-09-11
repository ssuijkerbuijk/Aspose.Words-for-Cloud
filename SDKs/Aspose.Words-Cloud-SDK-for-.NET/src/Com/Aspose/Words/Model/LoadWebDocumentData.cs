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
  /// Contains data for load web document
  /// </summary>  
  public class LoadWebDocumentData 
  {                       
        /// <summary>
        /// Web document url
        /// </summary>
        /// <value>Web document url</value>    
        public string LoadingDocumentUrl { get; set; }

        /// <summary>
        /// Save options
        /// </summary>
        /// <value>Save options</value>    
        public SaveOptionsData SaveOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class LoadWebDocumentData {\n");
          sb.Append("  LoadingDocumentUrl: ").Append(LoadingDocumentUrl).Append("\n");
          sb.Append("  SaveOptions: ").Append(SaveOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
