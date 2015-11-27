using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class Font {
    public bool AllCaps { get; set; }

    public bool Bidi { get; set; }

    public bool Bold { get; set; }

    public bool BoldBi { get; set; }

    public Border Border { get; set; }

    public Color Color { get; set; }

    public bool ComplexScript { get; set; }

    public bool DoubleStrikeThrough { get; set; }

    public bool Emboss { get; set; }

    public bool Engrave { get; set; }

    public bool Hidden { get; set; }

    public Color HighlightColor { get; set; }

    public bool Italic { get; set; }

    public bool ItalicBi { get; set; }

    public double Kerning { get; set; }

    public int LocaleId { get; set; }

    public int LocaleIdBi { get; set; }

    public int LocaleIdFarEast { get; set; }

    public string Name { get; set; }

    public string NameAscii { get; set; }

    public string NameBi { get; set; }

    public string NameFarEast { get; set; }

    public string NameOther { get; set; }

    public bool NoProofing { get; set; }

    public bool Outline { get; set; }

    public double Position { get; set; }

    public int Scaling { get; set; }

    public bool Shadow { get; set; }

    public double Size { get; set; }

    public double SizeBi { get; set; }

    public bool SmallCaps { get; set; }

    public double Spacing { get; set; }

    public bool StrikeThrough { get; set; }

    public String StyleIdentifier { get; set; }

    public string StyleName { get; set; }

    public bool Subscript { get; set; }

    public bool Superscript { get; set; }

    public string TextEffect { get; set; }

    public string Underline { get; set; }

    public Color UnderlineColor { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Font {\n");
      sb.Append("  AllCaps: ").Append(AllCaps).Append("\n");
      sb.Append("  Bidi: ").Append(Bidi).Append("\n");
      sb.Append("  Bold: ").Append(Bold).Append("\n");
      sb.Append("  BoldBi: ").Append(BoldBi).Append("\n");
      sb.Append("  Border: ").Append(Border).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  ComplexScript: ").Append(ComplexScript).Append("\n");
      sb.Append("  DoubleStrikeThrough: ").Append(DoubleStrikeThrough).Append("\n");
      sb.Append("  Emboss: ").Append(Emboss).Append("\n");
      sb.Append("  Engrave: ").Append(Engrave).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  HighlightColor: ").Append(HighlightColor).Append("\n");
      sb.Append("  Italic: ").Append(Italic).Append("\n");
      sb.Append("  ItalicBi: ").Append(ItalicBi).Append("\n");
      sb.Append("  Kerning: ").Append(Kerning).Append("\n");
      sb.Append("  LocaleId: ").Append(LocaleId).Append("\n");
      sb.Append("  LocaleIdBi: ").Append(LocaleIdBi).Append("\n");
      sb.Append("  LocaleIdFarEast: ").Append(LocaleIdFarEast).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NameAscii: ").Append(NameAscii).Append("\n");
      sb.Append("  NameBi: ").Append(NameBi).Append("\n");
      sb.Append("  NameFarEast: ").Append(NameFarEast).Append("\n");
      sb.Append("  NameOther: ").Append(NameOther).Append("\n");
      sb.Append("  NoProofing: ").Append(NoProofing).Append("\n");
      sb.Append("  Outline: ").Append(Outline).Append("\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  Scaling: ").Append(Scaling).Append("\n");
      sb.Append("  Shadow: ").Append(Shadow).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
      sb.Append("  SizeBi: ").Append(SizeBi).Append("\n");
      sb.Append("  SmallCaps: ").Append(SmallCaps).Append("\n");
      sb.Append("  Spacing: ").Append(Spacing).Append("\n");
      sb.Append("  StrikeThrough: ").Append(StrikeThrough).Append("\n");
      sb.Append("  StyleIdentifier: ").Append(StyleIdentifier).Append("\n");
      sb.Append("  StyleName: ").Append(StyleName).Append("\n");
      sb.Append("  Subscript: ").Append(Subscript).Append("\n");
      sb.Append("  Superscript: ").Append(Superscript).Append("\n");
      sb.Append("  TextEffect: ").Append(TextEffect).Append("\n");
      sb.Append("  Underline: ").Append(Underline).Append("\n");
      sb.Append("  UnderlineColor: ").Append(UnderlineColor).Append("\n");
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
