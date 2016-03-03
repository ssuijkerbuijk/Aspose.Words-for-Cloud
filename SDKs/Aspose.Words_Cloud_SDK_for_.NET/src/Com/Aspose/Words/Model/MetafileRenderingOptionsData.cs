using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class MetafileRenderingOptionsData {
    public string EmfPlusDualRenderingMode { get; set; }

    public string RenderingMode { get; set; }

    public bool UseEmfEmbeddedToWmf { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetafileRenderingOptionsData {\n");
      sb.Append("  EmfPlusDualRenderingMode: ").Append(EmfPlusDualRenderingMode).Append("\n");
      sb.Append("  RenderingMode: ").Append(RenderingMode).Append("\n");
      sb.Append("  UseEmfEmbeddedToWmf: ").Append(UseEmfEmbeddedToWmf).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
