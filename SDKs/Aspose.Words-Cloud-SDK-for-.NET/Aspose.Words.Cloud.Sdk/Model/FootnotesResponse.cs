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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/footnotes
  /// </summary>  
  public class FootnotesResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Collection of footnotes.
        /// </summary>  
        public FootnoteCollection Footnotes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FootnotesResponse {\n");
          sb.Append("  Footnotes: ").Append(this.Footnotes).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
