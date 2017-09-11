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
  /// FormField text input element
  /// </summary>  
  public class FormFieldTextInput : FormField 
  {                       
        /// <summary>
        /// Gets or sets the type of a text form field.
        /// </summary>
        /// <value>Gets or sets the type of a text form field.</value>
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
        /// Gets or sets the type of a text form field.
        /// </summary>
        /// <value>Gets or sets the type of a text form field.</value>
        public TextInputTypeEnum? TextInputType { get; set; }

        /// <summary>
        /// Returns or sets the text formatting for a text form field.
        /// </summary>
        /// <value>Returns or sets the text formatting for a text form field.</value>    
        public string TextInputFormat { get; set; }

        /// <summary>
        /// Gets or sets the default string or a calculation expression of a text form field.
        /// </summary>
        /// <value>Gets or sets the default string or a calculation expression of a text form field.</value>    
        public string TextInputDefault { get; set; }

        /// <summary>
        /// Maximum length for the text field. Zero when the length is not limited.
        /// </summary>
        /// <value>Maximum length for the text field. Zero when the length is not limited.</value>    
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
