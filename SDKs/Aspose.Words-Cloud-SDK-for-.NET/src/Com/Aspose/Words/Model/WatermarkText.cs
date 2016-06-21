using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class WatermarkText {
    public string Text { get; set; }

    public double RotationAngle { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WatermarkText {\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
