namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Container class for compare documents
  /// </summary>  
  public class CompareData 
  {                       
        /// <summary>
        /// Path to document to compare at the server.
        /// </summary>  
        public string ComparingWithDocument { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.
        /// </summary>  
        public string Author { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CompareData {\n");
          sb.Append("  ComparingWithDocument: ").Append(this.ComparingWithDocument).Append("\n");
          sb.Append("  Author: ").Append(this.Author).Append("\n");
          sb.Append("  DateTime: ").Append(this.DateTime).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
