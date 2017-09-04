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
  public class FormFieldCheckbox : FormField 
  {                       
        /// <summary>
        /// Gets or sets IsCheckBoxExactSize
        /// </summary>    
        public bool? IsCheckBoxExactSize { get; set; }

        /// <summary>
        /// Gets or sets CheckBoxSize
        /// </summary>    
        public double? CheckBoxSize { get; set; }

        /// <summary>
        /// Gets or sets _Checked
        /// </summary>    
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
