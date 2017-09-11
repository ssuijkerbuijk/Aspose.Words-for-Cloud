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
  /// FormField dropdownlist element
  /// </summary>  
  public class FormFieldDropDown : FormField 
  {                       
        /// <summary>
        /// Gets or sets the index specifying the currently selected item in a dropdown form field.
        /// </summary>
        /// <value>Gets or sets the index specifying the currently selected item in a dropdown form field.</value>    
        public int? DropDownSelectedIndex { get; set; }

        /// <summary>
        /// Provides access to the items of a dropdown form field.
        /// </summary>
        /// <value>Provides access to the items of a dropdown form field.</value>    
        public List<string> DropDownItems { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormFieldDropDown {\n");
          sb.Append("  DropDownSelectedIndex: ").Append(DropDownSelectedIndex).Append("\n");
          sb.Append("  DropDownItems: ").Append(DropDownItems).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
