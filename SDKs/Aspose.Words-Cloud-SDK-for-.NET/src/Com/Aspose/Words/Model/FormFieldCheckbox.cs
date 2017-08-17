using System.Text;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class FormFieldCheckbox : FormField 
  {        
    /// <summary>
    /// Gets or Sets IsCheckBoxExactSize
    /// </summary>    
    public bool? IsCheckBoxExactSize { get; set; }

    /// <summary>
    /// Gets or Sets CheckBoxSize
    /// </summary>    
    public double? CheckBoxSize { get; set; }

    /// <summary>
    /// Gets or Sets _Checked
    /// </summary>    
    public bool? Checked { get; set; }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class FormFieldCheckbox {\n");
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
      sb.Append("  IsCheckBoxExactSize: ").Append(IsCheckBoxExactSize).Append("\n");
      sb.Append("  CheckBoxSize: ").Append(CheckBoxSize).Append("\n");
      sb.Append("  _Checked: ").Append(this.Checked).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
