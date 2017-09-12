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
  /// FromField
  /// </summary>  
  public class FormField 
  {                       
        /// <summary>
        /// Node id
        /// </summary>  
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets the form field name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// True if a form field is enabled.
        /// </summary>  
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns or sets the text that's displayed in the status bar when a form field has the focus.
        /// </summary>  
        public string StatusText { get; set; }

        /// <summary>
        /// Specifies the source of the text that's displayed in the status bar when a form field has the focus.
        /// </summary>  
        public bool? OwnStatus { get; set; }

        /// <summary>
        /// Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1.
        /// </summary>  
        public string HelpText { get; set; }

        /// <summary>
        /// Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.
        /// </summary>  
        public bool? OwnHelp { get; set; }

        /// <summary>
        /// True if references to the specified form field are automatically updated whenever the field is exited.
        /// </summary>  
        public bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Returns or sets an entry macro name for the form field.
        /// </summary>  
        public string EntryMacro { get; set; }

        /// <summary>
        /// Returns or sets an exit macro name for the form field.
        /// </summary>  
        public string ExitMacro { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FormField {\n");
          sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Enabled: ").Append(this.Enabled).Append("\n");
          sb.Append("  StatusText: ").Append(this.StatusText).Append("\n");
          sb.Append("  OwnStatus: ").Append(this.OwnStatus).Append("\n");
          sb.Append("  HelpText: ").Append(this.HelpText).Append("\n");
          sb.Append("  OwnHelp: ").Append(this.OwnHelp).Append("\n");
          sb.Append("  CalculateOnExit: ").Append(this.CalculateOnExit).Append("\n");
          sb.Append("  EntryMacro: ").Append(this.EntryMacro).Append("\n");
          sb.Append("  ExitMacro: ").Append(this.ExitMacro).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
