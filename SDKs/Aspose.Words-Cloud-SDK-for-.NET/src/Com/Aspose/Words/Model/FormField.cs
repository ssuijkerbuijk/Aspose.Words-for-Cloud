using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class FormField {
    public string Name { get; set; }

    public bool Enabled { get; set; }

    public string StatusText { get; set; }

    public bool OwnStatus { get; set; }

    public string HelpText { get; set; }

    public bool OwnHelp { get; set; }

    public bool CalculateOnExit { get; set; }

    public string EntryMacro { get; set; }

    public string ExitMacro { get; set; }

    public string NodeId { get; set; }

    public Link link { get; set; }

    public string TextInputFormat { get; set; }

    public string TextInputType { get; set; }

    public string TextInputDefault { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormField {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  StatusText: ").Append(StatusText).Append("\n");
      sb.Append("  OwnStatus: ").Append(OwnStatus).Append("\n");
      sb.Append("  HelpText: ").Append(HelpText).Append("\n");
      sb.Append("  OwnHelp: ").Append(OwnHelp).Append("\n");
      sb.Append("  CalculateOnExit: ").Append(CalculateOnExit).Append("\n");
      sb.Append("  EntryMacro: ").Append(EntryMacro).Append("\n");
      sb.Append("  ExitMacro: ").Append(ExitMacro).Append("\n");
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
