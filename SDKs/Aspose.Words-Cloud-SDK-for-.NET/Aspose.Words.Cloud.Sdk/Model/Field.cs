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
  /// Field
  /// </summary>  
  public class Field 
  {                       
        /// <summary>
        /// Field result
        /// </summary>  
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets LCID of the field.
        /// </summary>  
        public string LocaleId { get; set; }

        /// <summary>
        /// Field code
        /// </summary>  
        public string FieldCode { get; set; }

        /// <summary>
        /// Node id
        /// </summary>  
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Field {\n");
          sb.Append("  Result: ").Append(this.Result).Append("\n");
          sb.Append("  LocaleId: ").Append(this.LocaleId).Append("\n");
          sb.Append("  FieldCode: ").Append(this.FieldCode).Append("\n");
          sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
