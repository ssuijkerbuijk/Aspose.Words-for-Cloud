using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// 
  /// </summary>  
  public class TiffSaveOptionsData 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="TiffSaveOptionsData" /> class.
        /// </summary>
        /// <param name="TiffBinarizationMethod">TiffBinarizationMethod.</param>
        /// <param name="TiffCompression">TiffCompression.</param>
        /// <param name="ImageBrightness">ImageBrightness.</param>
        /// <param name="ImageColorMode">ImageColorMode.</param>
        /// <param name="ImageContrast">ImageContrast.</param>
        /// <param name="GraphicsQualityOptions">GraphicsQualityOptions.</param>
        /// <param name="PixelFormat">PixelFormat.</param>
        /// <param name="PaperColor">PaperColor.</param>
        /// <param name="Resolution">Resolution.</param>
        /// <param name="HorizontalResolution">HorizontalResolution.</param>
        /// <param name="VerticalResolution">VerticalResolution.</param>
        /// <param name="Scale">Scale.</param>
        /// <param name="UseHighQualityRendering">UseHighQualityRendering.</param>
        /// <param name="UseAntiAliasing">UseAntiAliasing.</param>
        /// <param name="UseGdiEmfRenderer">UseGdiEmfRenderer.</param>
        /// <param name="JpegQuality">JpegQuality.</param>
        /// <param name="MetafileRenderingOptions">MetafileRenderingOptions.</param>
        /// <param name="NumeralFormat">NumeralFormat.</param>
        /// <param name="OptimizeOutput">OptimizeOutput.</param>
        /// <param name="PageCount">PageCount.</param>
        /// <param name="PageIndex">PageIndex.</param>
        /// <param name="ColorMode">ColorMode.</param>
        /// <param name="SaveFormat">SaveFormat.</param>
        /// <param name="FileName">FileName.</param>
        /// <param name="DmlRenderingMode">DmlRenderingMode.</param>
        /// <param name="DmlEffectsRenderingMode">DmlEffectsRenderingMode.</param>
        /// <param name="ZipOutput">ZipOutput.</param>
        /// <param name="UpdateSdtContent">UpdateSdtContent.</param>
        /// <param name="UpdateFields">UpdateFields.</param>
        public TiffSaveOptionsData(string TiffBinarizationMethod = default(string), string TiffCompression = default(string), float? ImageBrightness = default(float?), string ImageColorMode = default(string), float? ImageContrast = default(float?), GraphicsQualityOptionsData GraphicsQualityOptions = default(GraphicsQualityOptionsData), string PixelFormat = default(string), string PaperColor = default(string), float? Resolution = default(float?), float? HorizontalResolution = default(float?), float? VerticalResolution = default(float?), float? Scale = default(float?), bool? UseHighQualityRendering = default(bool?), bool? UseAntiAliasing = default(bool?), bool? UseGdiEmfRenderer = default(bool?), int? JpegQuality = default(int?), MetafileRenderingOptionsData MetafileRenderingOptions = default(MetafileRenderingOptionsData), string NumeralFormat = default(string), bool? OptimizeOutput = default(bool?), int? PageCount = default(int?), int? PageIndex = default(int?), string ColorMode = default(string), string SaveFormat = default(string), string FileName = default(string), string DmlRenderingMode = default(string), string DmlEffectsRenderingMode = default(string), bool? ZipOutput = default(bool?), bool? UpdateSdtContent = default(bool?), bool? UpdateFields = default(bool?))
        {
                        this.TiffBinarizationMethod = TiffBinarizationMethod;
                        this.TiffCompression = TiffCompression;
                        this.ImageBrightness = ImageBrightness;
                        this.ImageColorMode = ImageColorMode;
                        this.ImageContrast = ImageContrast;
                        this.GraphicsQualityOptions = GraphicsQualityOptions;
                        this.PixelFormat = PixelFormat;
                        this.PaperColor = PaperColor;
                        this.Resolution = Resolution;
                        this.HorizontalResolution = HorizontalResolution;
                        this.VerticalResolution = VerticalResolution;
                        this.Scale = Scale;
                        this.UseHighQualityRendering = UseHighQualityRendering;
                        this.UseAntiAliasing = UseAntiAliasing;
                        this.UseGdiEmfRenderer = UseGdiEmfRenderer;
                        this.JpegQuality = JpegQuality;
                        this.MetafileRenderingOptions = MetafileRenderingOptions;
                        this.NumeralFormat = NumeralFormat;
                        this.OptimizeOutput = OptimizeOutput;
                        this.PageCount = PageCount;
                        this.PageIndex = PageIndex;
                        this.ColorMode = ColorMode;
                        this.SaveFormat = SaveFormat;
                        this.FileName = FileName;
                        this.DmlRenderingMode = DmlRenderingMode;
                        this.DmlEffectsRenderingMode = DmlEffectsRenderingMode;
                        this.ZipOutput = ZipOutput;
                        this.UpdateSdtContent = UpdateSdtContent;
                        this.UpdateFields = UpdateFields;
        }

        /// <summary>
        /// Gets or sets TiffBinarizationMethod
        /// </summary>    
        public string TiffBinarizationMethod { get; set; }

        /// <summary>
        /// Gets or sets TiffCompression
        /// </summary>    
        public string TiffCompression { get; set; }

        /// <summary>
        /// Gets or sets ImageBrightness
        /// </summary>    
        public float? ImageBrightness { get; set; }

        /// <summary>
        /// Gets or sets ImageColorMode
        /// </summary>    
        public string ImageColorMode { get; set; }

        /// <summary>
        /// Gets or sets ImageContrast
        /// </summary>    
        public float? ImageContrast { get; set; }

        /// <summary>
        /// Gets or sets GraphicsQualityOptions
        /// </summary>    
        public GraphicsQualityOptionsData GraphicsQualityOptions { get; set; }

        /// <summary>
        /// Gets or sets PixelFormat
        /// </summary>    
        public string PixelFormat { get; set; }

        /// <summary>
        /// Gets or sets PaperColor
        /// </summary>    
        public string PaperColor { get; set; }

        /// <summary>
        /// Gets or sets Resolution
        /// </summary>    
        public float? Resolution { get; set; }

        /// <summary>
        /// Gets or sets HorizontalResolution
        /// </summary>    
        public float? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets VerticalResolution
        /// </summary>    
        public float? VerticalResolution { get; set; }

        /// <summary>
        /// Gets or sets Scale
        /// </summary>    
        public float? Scale { get; set; }

        /// <summary>
        /// Gets or sets UseHighQualityRendering
        /// </summary>    
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Gets or sets UseAntiAliasing
        /// </summary>    
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Gets or sets UseGdiEmfRenderer
        /// </summary>    
        public bool? UseGdiEmfRenderer { get; set; }

        /// <summary>
        /// Gets or sets JpegQuality
        /// </summary>    
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets MetafileRenderingOptions
        /// </summary>    
        public MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

        /// <summary>
        /// Gets or sets NumeralFormat
        /// </summary>    
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Gets or sets OptimizeOutput
        /// </summary>    
        public bool? OptimizeOutput { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>    
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets PageIndex
        /// </summary>    
        public int? PageIndex { get; set; }

        /// <summary>
        /// Gets or sets ColorMode
        /// </summary>    
        public string ColorMode { get; set; }

        /// <summary>
        /// Gets or sets SaveFormat
        /// </summary>    
        public string SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets FileName
        /// </summary>    
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets DmlRenderingMode
        /// </summary>    
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets DmlEffectsRenderingMode
        /// </summary>    
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets ZipOutput
        /// </summary>    
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Gets or sets UpdateSdtContent
        /// </summary>    
        public bool? UpdateSdtContent { get; set; }

        /// <summary>
        /// Gets or sets UpdateFields
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
