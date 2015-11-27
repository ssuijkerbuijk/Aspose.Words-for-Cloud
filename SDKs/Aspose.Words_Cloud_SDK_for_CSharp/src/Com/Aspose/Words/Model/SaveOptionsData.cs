using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class SaveOptionsData {
    public string ColorMode { get; set; }

    public string SaveFormat { get; set; }

    public string FileName { get; set; }

    public string DmlRenderingMode { get; set; }

    public string DmlEffectsRenderingMode { get; set; }

    public bool ZipOutput { get; set; }

    public bool UpdateSdtContent { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaveOptionsData {\n");
      sb.Append("  ColorMode: ").Append(ColorMode).Append("\n");
      sb.Append("  SaveFormat: ").Append(SaveFormat).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  DmlRenderingMode: ").Append(DmlRenderingMode).Append("\n");
      sb.Append("  DmlEffectsRenderingMode: ").Append(DmlEffectsRenderingMode).Append("\n");
      sb.Append("  ZipOutput: ").Append(ZipOutput).Append("\n");
      sb.Append("  UpdateSdtContent: ").Append(UpdateSdtContent).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
