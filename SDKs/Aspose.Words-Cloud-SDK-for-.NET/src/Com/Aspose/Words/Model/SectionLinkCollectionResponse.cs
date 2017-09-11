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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/sections
  /// </summary>  
  public class SectionLinkCollectionResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Collection of sections
        /// </summary>
        /// <value>Collection of sections</value>    
        public SectionLinkCollection Sections { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SectionLinkCollectionResponse {\n");
          sb.Append("  Sections: ").Append(Sections).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
