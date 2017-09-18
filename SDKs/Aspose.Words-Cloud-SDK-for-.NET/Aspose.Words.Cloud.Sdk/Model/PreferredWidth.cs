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
  /// Preferred width.
  /// </summary>  
  public class PreferredWidth 
  {                       
        /// <summary>
        /// Gets the unit of measure used for this preferred width value.
        /// </summary>
        /// <value>Gets the unit of measure used for this preferred width value.</value>
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
        /// Gets the unit of measure used for this preferred width value.
        /// </summary>
        /// <value>Gets the unit of measure used for this preferred width value.</value>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets the preferred width value. The unit of measure is specified in the {Aspose.Words.Cloud.DTO.DocumentElements.Tables.PreferredWidthDto.Type} property.
        /// </summary>  
        public double? Value { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PreferredWidth {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Value: ").Append(this.Value).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
