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
  /// Utility class for {System.Drawing.Color} serialization
  /// </summary>  
  public class XmlColor 
  {                       
        /// <summary>
        /// HTML string color representation
        /// </summary>
        /// <value>HTML string color representation</value>    
        public string Web { get; set; }

        /// <summary>
        /// Alpha component of color structure
        /// </summary>
        /// <value>Alpha component of color structure</value>    
        public int? Alpha { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class XmlColor {\n");
          sb.Append("  Web: ").Append(Web).Append("\n");
          sb.Append("  Alpha: ").Append(Alpha).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
