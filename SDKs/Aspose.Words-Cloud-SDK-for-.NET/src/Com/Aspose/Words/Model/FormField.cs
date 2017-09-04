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
  public class FormField 
  {                       
        /// <summary>
        /// Gets or sets NodeId
        /// </summary>    
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>    
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Enabled
        /// </summary>    
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets StatusText
        /// </summary>    
        public string StatusText { get; set; }

        /// <summary>
        /// Gets or sets OwnStatus
        /// </summary>    
        public bool? OwnStatus { get; set; }

        /// <summary>
        /// Gets or sets HelpText
        /// </summary>    
        public string HelpText { get; set; }

        /// <summary>
        /// Gets or sets OwnHelp
        /// </summary>    
        public bool? OwnHelp { get; set; }

        /// <summary>
        /// Gets or sets CalculateOnExit
        /// </summary>    
        public bool? CalculateOnExit { get; set; }

        /// <summary>
        /// Gets or sets EntryMacro
        /// </summary>    
        public string EntryMacro { get; set; }

        /// <summary>
        /// Gets or sets ExitMacro
        /// </summary>    
        public string ExitMacro { get; set; }

        /// <summary>
        /// Gets or sets Link
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
