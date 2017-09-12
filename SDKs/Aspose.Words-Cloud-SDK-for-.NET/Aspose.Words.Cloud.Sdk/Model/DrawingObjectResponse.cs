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
  /// Response for \&quot;drawingObjects/n\&quot; resource.
  /// </summary>  
  public class DrawingObjectResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Drawing object.
        /// </summary>  
        public DrawingObject DrawingObject { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingObjectResponse {\n");
          sb.Append("  DrawingObject: ").Append(this.DrawingObject).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
