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
  /// FromField
  /// </summary>  
  public class FormField 
  {                       
        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>    
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the form field name.
        /// </summary>
        /// <value>Gets or sets the form field name.</value>    
        public string Name { get; set; }

        /// <summary>
        /// True if a form field is enabled.
        /// </summary>
        /// <value>True if a form field is enabled.</value>    
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns or sets the text that's displayed in the status bar when a form field has the focus.
        /// </summary>
        /// <value>Returns or sets the text that's displayed in the status bar when a form field has the focus.</value>    
        public string StatusText { get; set; }

        /// <summary>
        /// Specifies the source of the text that's displayed in the status bar when a form field has the focus.
        /// </summary>
        /// <value>Specifies the source of the text that's displayed in the status bar when a form field has the focus.</value>    
        public bool? OwnStatus { get; set; }

        /// <summary>
        /// Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1.
        /// </summary>
        /// <value>Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1.</value>    
        public string HelpText { get; set; }

        /// <summary>
        /// Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.
        /// </summary>
        /// <value>Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.</value>    
        public bool? OwnHelp { get; set; }

        /// <summary>
        /// True if references to the specified form field are automatically updated whenever the field is exited.
        /// </summary>
        /// <value>True if references to the specified form field are automatically updated whenever the field is exited.</value>    
        public bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Returns or sets an entry macro name for the form field.
        /// </summary>
        /// <value>Returns or sets an entry macro name for the form field.</value>    
        public string EntryMacro { get; set; }

        /// <summary>
        /// Returns or sets an exit macro name for the form field.
        /// </summary>
        /// <value>Returns or sets an exit macro name for the form field.</value>    
        public string ExitMacro { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormField {\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Enabled: ").Append(Enabled).Append("\n");
          sb.Append("  StatusText: ").Append(StatusText).Append("\n");
          sb.Append("  OwnStatus: ").Append(OwnStatus).Append("\n");
          sb.Append("  HelpText: ").Append(HelpText).Append("\n");
          sb.Append("  OwnHelp: ").Append(OwnHelp).Append("\n");
          sb.Append("  CalculateOnExit: ").Append(CalculateOnExit).Append("\n");
          sb.Append("  EntryMacro: ").Append(EntryMacro).Append("\n");
          sb.Append("  ExitMacro: ").Append(ExitMacro).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
