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
  public class PreferredWidthDto 
  {                       
        /// <summary>
        /// Gets or sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Auto for "Auto"
            /// </summary>            
            Auto,
            
            /// <summary>
            /// Enum Percent for "Percent"
            /// </summary>            
            Percent,
            
            /// <summary>
            /// Enum Points for "Points"
            /// </summary>            
            Points
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets Value
        /// </summary>    
        public double? Value { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PreferredWidthDto {\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Value: ").Append(Value).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
