using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class TiffSaveOptionsData {
    /// <summary>
    /// Gets or Sets TiffBinarizationMethod
    /// </summary>    
    public string TiffBinarizationMethod { get; set; }

    /// <summary>
    /// Gets or Sets TiffCompression
    /// </summary>    
    public string TiffCompression { get; set; }

    /// <summary>
    /// Gets or Sets ImageBrightness
    /// </summary>    
    public float? ImageBrightness { get; set; }

    /// <summary>
    /// Gets or Sets ImageColorMode
    /// </summary>    
    public string ImageColorMode { get; set; }

    /// <summary>
    /// Gets or Sets ImageContrast
    /// </summary>    
    public float? ImageContrast { get; set; }

    /// <summary>
    /// Gets or Sets GraphicsQualityOptions
    /// </summary>    
    public GraphicsQualityOptionsData GraphicsQualityOptions { get; set; }

    /// <summary>
    /// Gets or Sets PixelFormat
    /// </summary>    
    public string PixelFormat { get; set; }

    /// <summary>
    /// Gets or Sets PaperColor
    /// </summary>    
    public string PaperColor { get; set; }

    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>    
    public float? Resolution { get; set; }

    /// <summary>
    /// Gets or Sets HorizontalResolution
    /// </summary>    
    public float? HorizontalResolution { get; set; }

    /// <summary>
    /// Gets or Sets VerticalResolution
    /// </summary>    
    public float? VerticalResolution { get; set; }

    /// <summary>
    /// Gets or Sets Scale
    /// </summary>    
    public float? Scale { get; set; }

    /// <summary>
    /// Gets or Sets UseHighQualityRendering
    /// </summary>    
    public bool? UseHighQualityRendering { get; set; }

    /// <summary>
    /// Gets or Sets UseAntiAliasing
    /// </summary>    
    public bool? UseAntiAliasing { get; set; }

    /// <summary>
    /// Gets or Sets UseGdiEmfRenderer
    /// </summary>    
    public bool? UseGdiEmfRenderer { get; set; }

    /// <summary>
    /// Gets or Sets JpegQuality
    /// </summary>    
    public int? JpegQuality { get; set; }

    /// <summary>
    /// Gets or Sets MetafileRenderingOptions
    /// </summary>    
    public MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

    /// <summary>
    /// Gets or Sets NumeralFormat
    /// </summary>    
    public string NumeralFormat { get; set; }

    /// <summary>
    /// Gets or Sets OptimizeOutput
    /// </summary>    
    public bool? OptimizeOutput { get; set; }

    /// <summary>
    /// Gets or Sets PageCount
    /// </summary>    
    public int? PageCount { get; set; }

    /// <summary>
    /// Gets or Sets PageIndex
    /// </summary>    
    public int? PageIndex { get; set; }

    /// <summary>
    /// Gets or Sets ColorMode
    /// </summary>    
    public string ColorMode { get; set; }

    /// <summary>
    /// Gets or Sets SaveFormat
    /// </summary>    
    public string SaveFormat { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>    
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets DmlRenderingMode
    /// </summary>    
    public string DmlRenderingMode { get; set; }

    /// <summary>
    /// Gets or Sets DmlEffectsRenderingMode
    /// </summary>    
    public string DmlEffectsRenderingMode { get; set; }

    /// <summary>
    /// Gets or Sets ZipOutput
    /// </summary>    
    public bool? ZipOutput { get; set; }

    /// <summary>
    /// Gets or Sets UpdateSdtContent
    /// </summary>    
    public bool? UpdateSdtContent { get; set; }

    /// <summary>
    /// Gets or Sets UpdateFields
    /// </summary>    
    public bool? UpdateFields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class TiffSaveOptionsData {\n");
      sb.Append("  TiffBinarizationMethod: ").Append(TiffBinarizationMethod).Append("\n");
      sb.Append("  TiffCompression: ").Append(TiffCompression).Append("\n");
      sb.Append("  ImageBrightness: ").Append(ImageBrightness).Append("\n");
      sb.Append("  ImageColorMode: ").Append(ImageColorMode).Append("\n");
      sb.Append("  ImageContrast: ").Append(ImageContrast).Append("\n");
      sb.Append("  GraphicsQualityOptions: ").Append(GraphicsQualityOptions).Append("\n");
      sb.Append("  PixelFormat: ").Append(PixelFormat).Append("\n");
      sb.Append("  PaperColor: ").Append(PaperColor).Append("\n");
      sb.Append("  Resolution: ").Append(Resolution).Append("\n");
      sb.Append("  HorizontalResolution: ").Append(HorizontalResolution).Append("\n");
      sb.Append("  VerticalResolution: ").Append(VerticalResolution).Append("\n");
      sb.Append("  Scale: ").Append(Scale).Append("\n");
      sb.Append("  UseHighQualityRendering: ").Append(UseHighQualityRendering).Append("\n");
      sb.Append("  UseAntiAliasing: ").Append(UseAntiAliasing).Append("\n");
      sb.Append("  UseGdiEmfRenderer: ").Append(UseGdiEmfRenderer).Append("\n");
      sb.Append("  JpegQuality: ").Append(JpegQuality).Append("\n");
      sb.Append("  MetafileRenderingOptions: ").Append(MetafileRenderingOptions).Append("\n");
      sb.Append("  NumeralFormat: ").Append(NumeralFormat).Append("\n");
      sb.Append("  OptimizeOutput: ").Append(OptimizeOutput).Append("\n");
      sb.Append("  PageCount: ").Append(PageCount).Append("\n");
      sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
      sb.Append("  ColorMode: ").Append(ColorMode).Append("\n");
      sb.Append("  SaveFormat: ").Append(SaveFormat).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  DmlRenderingMode: ").Append(DmlRenderingMode).Append("\n");
      sb.Append("  DmlEffectsRenderingMode: ").Append(DmlEffectsRenderingMode).Append("\n");
      sb.Append("  ZipOutput: ").Append(ZipOutput).Append("\n");
      sb.Append("  UpdateSdtContent: ").Append(UpdateSdtContent).Append("\n");
      sb.Append("  UpdateFields: ").Append(UpdateFields).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
}
