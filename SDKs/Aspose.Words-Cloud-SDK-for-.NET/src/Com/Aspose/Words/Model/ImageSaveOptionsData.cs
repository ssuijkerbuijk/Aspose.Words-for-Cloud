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
  public class ImageSaveOptionsData : FixedPageSaveOptionsData 
  {                       
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
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ImageSaveOptionsData {\n");
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
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
