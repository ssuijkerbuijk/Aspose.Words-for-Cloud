namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Container abstract class for image save options
  /// </summary>  
  public class ImageSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Brightness of image
        /// </summary>  
        public float? ImageBrightness { get; set; }

        /// <summary>
        /// Color mode of image
        /// </summary>  
        public string ImageColorMode { get; set; }

        /// <summary>
        /// Contrast of image
        /// </summary>  
        public float? ImageContrast { get; set; }

        /// <summary>
        /// Allows to specify additional System.Drawing.Graphics quality options.
        /// </summary>  
        public GraphicsQualityOptionsData GraphicsQualityOptions { get; set; }

        /// <summary>
        /// Pixel format of image
        /// </summary>  
        public string PixelFormat { get; set; }

        /// <summary>
        /// Background (paper) color of image
        /// </summary>  
        public string PaperColor { get; set; }

        /// <summary>
        /// Sets both horizontal and vertical resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks>
        /// </summary>  
        public float? Resolution { get; set; }

        /// <summary>
        /// Gets or sets the horizontal resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks>
        /// </summary>  
        public float? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets the vertical resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks>
        /// </summary>  
        public float? VerticalResolution { get; set; }

        /// <summary>
        /// Zoom factor of image
        /// </summary>  
        public float? Scale { get; set; }

        /// <summary>
        /// Determine whether or not to use high quality (i.e. slow) rendering algorithms
        /// </summary>  
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Determine whether or not to use anti-aliasing for rendering
        /// </summary>  
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether to use GDI+ or Aspose.Words metafile renderer when saving to EMF.
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
          sb.Append("  ImageBrightness: ").Append(this.ImageBrightness).Append("\n");
          sb.Append("  ImageColorMode: ").Append(this.ImageColorMode).Append("\n");
          sb.Append("  ImageContrast: ").Append(this.ImageContrast).Append("\n");
          sb.Append("  GraphicsQualityOptions: ").Append(this.GraphicsQualityOptions).Append("\n");
          sb.Append("  PixelFormat: ").Append(this.PixelFormat).Append("\n");
          sb.Append("  PaperColor: ").Append(this.PaperColor).Append("\n");
          sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
          sb.Append("  HorizontalResolution: ").Append(this.HorizontalResolution).Append("\n");
          sb.Append("  VerticalResolution: ").Append(this.VerticalResolution).Append("\n");
          sb.Append("  Scale: ").Append(this.Scale).Append("\n");
          sb.Append("  UseHighQualityRendering: ").Append(this.UseHighQualityRendering).Append("\n");
          sb.Append("  UseAntiAliasing: ").Append(this.UseAntiAliasing).Append("\n");
          sb.Append("  UseGdiEmfRenderer: ").Append(this.UseGdiEmfRenderer).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
