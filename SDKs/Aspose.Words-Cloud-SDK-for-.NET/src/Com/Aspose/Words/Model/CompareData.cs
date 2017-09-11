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
  /// Container class for compare documents
  /// </summary>  
  public class CompareData 
  {                       
        /// <summary>
        /// Path to document to compare at the server.
        /// </summary>
        /// <value>Path to document to compare at the server.</value>    
        public string ComparingWithDocument { get; set; }

        /// <summary>
        /// Initials of the author to use for revisions.
        /// </summary>
        /// <value>Initials of the author to use for revisions.</value>    
        public string Author { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>
        /// <value>The date and time to use for revisions.</value>    
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CompareData {\n");
          sb.Append("  ComparingWithDocument: ").Append(ComparingWithDocument).Append("\n");
          sb.Append("  Author: ").Append(Author).Append("\n");
          sb.Append("  DateTime: ").Append(DateTime).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
