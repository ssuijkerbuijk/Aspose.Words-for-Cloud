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
  public class FormFieldTextInput : FormField 
  {                       
        /// <summary>
        /// Gets or sets TextInputType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextInputTypeEnum
        {
            
            /// <summary>
            /// Enum Regular for "Regular"
            /// </summary>            
            Regular,
            
            /// <summary>
            /// Enum Number for "Number"
            /// </summary>            
            Number,
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>            
            Date,
            
            /// <summary>
            /// Enum CurrentDate for "CurrentDate"
            /// </summary>            
            CurrentDate,
            
            /// <summary>
            /// Enum CurrentTime for "CurrentTime"
            /// </summary>            
            CurrentTime,
            
            /// <summary>
            /// Enum Calculated for "Calculated"
            /// </summary>            
            Calculated
        }

        /// <summary>
        /// Gets or sets TextInputType
        /// </summary>
        public TextInputTypeEnum? TextInputType { get; set; }

        /// <summary>
        /// Gets or sets TextInputFormat
        /// </summary>    
        public string TextInputFormat { get; set; }

        /// <summary>
        /// Gets or sets TextInputDefault
        /// </summary>    
        public string TextInputDefault { get; set; }

        /// <summary>
        /// Gets or sets MaxLength
        /// </summary>    
        public int? MaxLength { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormFieldTextInput {\n");
          sb.Append("  TextInputFormat: ").Append(TextInputFormat).Append("\n");
          sb.Append("  TextInputType: ").Append(TextInputType).Append("\n");
          sb.Append("  TextInputDefault: ").Append(TextInputDefault).Append("\n");
          sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
