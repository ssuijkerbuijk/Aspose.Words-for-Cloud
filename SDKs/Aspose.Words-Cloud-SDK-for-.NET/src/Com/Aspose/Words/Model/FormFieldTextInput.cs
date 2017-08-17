using System.Text;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class FormFieldTextInput : FormField 
  {
    /// <summary>
    /// Gets or Sets TextInputFormat
    /// </summary>    
    public string TextInputFormat { get; set; }

    /// <summary>
    /// Gets or Sets TextInputType
    /// </summary>    
    public string TextInputType { get; set; }

    /// <summary>
    /// Gets or Sets TextInputDefault
    /// </summary>    
    public string TextInputDefault { get; set; }

    /// <summary>
    /// Gets or Sets MaxLength
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
      sb.Append("  TextInputFormat: ").Append(TextInputFormat).Append("\n");
      sb.Append("  TextInputType: ").Append(TextInputType).Append("\n");
      sb.Append("  TextInputDefault: ").Append(TextInputDefault).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
