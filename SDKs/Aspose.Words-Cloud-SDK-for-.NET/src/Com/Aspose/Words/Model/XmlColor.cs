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
  public class XmlColor 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlColor" /> class.
        /// </summary>
        /// <param name="Web">Web.</param>
        /// <param name="Alpha">Alpha.</param>
        public XmlColor(string Web = default(string), int? Alpha = default(int?))
        {
                        this.Web = Web;
                        this.Alpha = Alpha;
        }

        /// <summary>
        /// Gets or sets Web
        /// </summary>    
        public string Web { get; set; }

        /// <summary>
        /// Gets or sets Alpha
        /// </summary>    
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
