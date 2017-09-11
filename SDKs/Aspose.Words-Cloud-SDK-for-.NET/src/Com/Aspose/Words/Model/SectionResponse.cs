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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/sections/{0}
  /// </summary>  
  public class SectionResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Section
        /// </summary>
        /// <value>Section</value>    
        public Section Section { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SectionResponse {\n");
          sb.Append("  Section: ").Append(Section).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
