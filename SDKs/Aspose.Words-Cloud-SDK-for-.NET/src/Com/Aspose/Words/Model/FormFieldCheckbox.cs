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
  /// FormField checkbox element
  /// </summary>  
  public class FormFieldCheckbox : FormField 
  {                       
        /// <summary>
        /// Gets or sets the boolean value that indicates whether the size of the textbox is automatic or specified explicitly.
        /// </summary>
        /// <value>Gets or sets the boolean value that indicates whether the size of the textbox is automatic or specified explicitly.</value>    
        public bool? IsCheckBoxExactSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the checkbox in points. Has effect only when {Aspose.Words.Cloud.DTO.DocumentElements.FormFields.FormFieldCheckbox.IsCheckBoxExactSize} is true.
        /// </summary>
        /// <value>Gets or sets the size of the checkbox in points. Has effect only when {Aspose.Words.Cloud.DTO.DocumentElements.FormFields.FormFieldCheckbox.IsCheckBoxExactSize} is true.</value>    
        public double? CheckBoxSize { get; set; }

        /// <summary>
        /// Gets or sets the checked status of the check box form field.
        /// </summary>
        /// <value>Gets or sets the checked status of the check box form field.</value>    
        public bool? _Checked { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormFieldCheckbox {\n");
          sb.Append("  IsCheckBoxExactSize: ").Append(IsCheckBoxExactSize).Append("\n");
          sb.Append("  CheckBoxSize: ").Append(CheckBoxSize).Append("\n");
          sb.Append("  _Checked: ").Append(_Checked).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
