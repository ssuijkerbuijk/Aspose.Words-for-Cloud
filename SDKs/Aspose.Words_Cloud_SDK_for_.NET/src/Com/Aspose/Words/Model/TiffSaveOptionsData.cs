using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class TiffSaveOptionsData {
    public string TiffBinarizationMethod { get; set; }

    public string TiffCompression { get; set; }

    public int PageCount { get; set; }

    public string PixelFormat { get; set; }

    public string PaperColor { get; set; }

    public float Resolution { get; set; }

    public float Scale { get; set; }

    public float ImageBrightness { get; set; }

    public string ImageColorMode { get; set; }

    public float ImageContrast { get; set; }

    public bool UseHighQualityRendering { get; set; }

    public bool UseAntiAliasing { get; set; }

    public int PageIndex { get; set; }

    public MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

    public string NumeralFormat { get; set; }

    public string ColorMode { get; set; }

    public string SaveFormat { get; set; }

    public string FileName { get; set; }

    public string DmlRenderingMode { get; set; }

    public string DmlEffectsRenderingMode { get; set; }

    public bool ZipOutput { get; set; }

    public bool UpdateSdtContent { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TiffSaveOptionsData {\n");
      sb.Append("  TiffBinarizationMethod: ").Append(TiffBinarizationMethod).Append("\n");
      sb.Append("  TiffCompression: ").Append(TiffCompression).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  PixelFormat: ").Append(PixelFormat).Append("\n");
      sb.Append("  PaperColor: ").Append(PaperColor).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
      sb.Append("  Scale: ").Append(Scale).Append("\n");
      sb.Append("  ImageBrightness: ").Append(ImageBrightness).Append("\n");
      sb.Append("  ImageColorMode: ").Append(ImageColorMode).Append("\n");
      sb.Append("  ImageContrast: ").Append(ImageContrast).Append("\n");
      sb.Append("  UseHighQualityRendering: ").Append(UseHighQualityRendering).Append("\n");
      sb.Append("  UseAntiAliasing: ").Append(UseAntiAliasing).Append("\n");
      sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
      sb.Append("  MetafileRenderingOptions: ").Append(MetafileRenderingOptions).Append("\n");
      sb.Append("  NumeralFormat: ").Append(NumeralFormat).Append("\n");
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
