using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class Border {
    public string LineStyle { get; set; }

    public double LineWidth { get; set; }

    public Color Color { get; set; }

    public double DistanceFromText { get; set; }

    public bool Shadow { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Border {\n");
      sb.Append("  LineStyle: ").Append(LineStyle).Append("\n");
      sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  DistanceFromText: ").Append(DistanceFromText).Append("\n");
      sb.Append("  Shadow: ").Append(Shadow).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
