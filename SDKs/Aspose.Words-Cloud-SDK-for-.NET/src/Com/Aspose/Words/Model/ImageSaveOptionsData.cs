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
  /// Container abstract class for image save options
  /// </summary>  
  public class ImageSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Brightness of image
        /// </summary>
        /// <value>Brightness of image</value>    
        public float? ImageBrightness { get; set; }

        /// <summary>
        /// Color mode of image
        /// </summary>
        /// <value>Color mode of image</value>    
        public string ImageColorMode { get; set; }

        /// <summary>
        /// Contrast of image
        /// </summary>
        /// <value>Contrast of image</value>    
        public float? ImageContrast { get; set; }

        /// <summary>
        /// Allows to specify additional System.Drawing.Graphics quality options.
        /// </summary>
        /// <value>Allows to specify additional System.Drawing.Graphics quality options.</value>    
        public GraphicsQualityOptionsData GraphicsQualityOptions { get; set; }

        /// <summary>
        /// Pixel format of image
        /// </summary>
        /// <value>Pixel format of image</value>    
        public string PixelFormat { get; set; }

        /// <summary>
        /// Background (paper) color of image
        /// </summary>
        /// <value>Background (paper) color of image</value>    
        public string PaperColor { get; set; }

        /// <summary>
        /// Sets both horizontal and vertical resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks>
        /// </summary>
        /// <value>Sets both horizontal and vertical resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks></value>    
        public float? Resolution { get; set; }

        /// <summary>
        /// Gets or sets the horizontal resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks>
        /// </summary>
        /// <value>Gets or sets the horizontal resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks></value>    
        public float? HorizontalResolution { get; set; }

        /// <summary>
        /// Gets or sets the vertical resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks>
        /// </summary>
        /// <value>Gets or sets the vertical resolution for the generated images, in dots per inch.  <remarks>  This property has effect only when saving to raster image formats.  The default value is 96.  </remarks></value>    
        public float? VerticalResolution { get; set; }

        /// <summary>
        /// Zoom factor of image
        /// </summary>
        /// <value>Zoom factor of image</value>    
        public float? Scale { get; set; }

        /// <summary>
        /// Determine whether or not to use high quality (i.e. slow) rendering algorithms
        /// </summary>
        /// <value>Determine whether or not to use high quality (i.e. slow) rendering algorithms</value>    
        public bool? UseHighQualityRendering { get; set; }

        /// <summary>
        /// Determine whether or not to use anti-aliasing for rendering
        /// </summary>
        /// <value>Determine whether or not to use anti-aliasing for rendering</value>    
        public bool? UseAntiAliasing { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether to use GDI+ or Aspose.Words metafile renderer when saving to EMF.
        /// </summary>
        /// <value>Gets or sets a value determining whether to use GDI+ or Aspose.Words metafile renderer when saving to EMF.</value>    
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
