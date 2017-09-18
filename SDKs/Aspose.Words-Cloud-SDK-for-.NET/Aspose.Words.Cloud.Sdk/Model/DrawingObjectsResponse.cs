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
  /// 
  /// </summary>  
  public class DrawingObjectsResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets DrawingObjects
        /// </summary>  
        public DrawingObjectCollection DrawingObjects { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingObjectsResponse {\n");
          sb.Append("  DrawingObjects: ").Append(this.DrawingObjects).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
