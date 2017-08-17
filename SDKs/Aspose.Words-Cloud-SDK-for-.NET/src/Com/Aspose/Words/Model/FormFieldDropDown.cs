using System.Text;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class FormFieldDropDown : FormField 
  {    
    /// <summary>
    /// Gets or Sets DropDownSelectedIndex
    /// </summary>    
    public int? DropDownSelectedIndex { get; set; }

    /// <summary>
    /// Gets or Sets DropDownItems
    /// </summary>    
    public List<string> DropDownItems { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class FormFieldDropDown {\n");
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
      sb.Append("  FormFieldType: ").Append(FormFieldType).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  DropDownSelectedIndex: ").Append(DropDownSelectedIndex).Append("\n");
      sb.Append("  DropDownItems: ").Append(DropDownItems).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
