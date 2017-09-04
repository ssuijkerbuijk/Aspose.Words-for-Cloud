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
  public class FormFieldsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets FormFields
        /// </summary>    
        public FormFieldCollectionDto FormFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormFieldsResponse {\n");
          sb.Append("  FormFields: ").Append(FormFields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
