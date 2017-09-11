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
  /// Response for \&quot;drawingObjects/n\&quot; resource.
  /// </summary>  
  public class DrawingObjectResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Drawing object.
        /// </summary>
        /// <value>Drawing object.</value>    
        public DrawingObject DrawingObject { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingObjectResponse {\n");
          sb.Append("  DrawingObject: ").Append(DrawingObject).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
