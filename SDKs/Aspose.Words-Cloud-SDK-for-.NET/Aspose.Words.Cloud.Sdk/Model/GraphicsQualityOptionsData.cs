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
  /// Allows to specify additional System.Drawing.Graphics quality options.
  /// </summary>  
  public class GraphicsQualityOptionsData 
  {                       
        /// <summary>
        /// Gets or sets a value that specifies how composited images are drawn to this Graphics.
        /// </summary>
        /// <value>Gets or sets a value that specifies how composited images are drawn to this Graphics.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompositingModeEnum
        {
            
            /// <summary>
            /// Enum SourceOver for "SourceOver"
            /// </summary>            
            SourceOver,
            
            /// <summary>
            /// Enum SourceCopy for "SourceCopy"
            /// </summary>            
            SourceCopy
        }

        /// <summary>
        /// Gets or sets the rendering quality of composited images drawn to this Graphics.
        /// </summary>
        /// <value>Gets or sets the rendering quality of composited images drawn to this Graphics.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompositingQualityEnum
        {
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>            
            Invalid,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>            
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>            
            HighQuality,
            
            /// <summary>
            /// Enum GammaCorrected for "GammaCorrected"
            /// </summary>            
            GammaCorrected,
            
            /// <summary>
            /// Enum AssumeLinear for "AssumeLinear"
            /// </summary>            
            AssumeLinear
        }

        /// <summary>
        /// Gets or sets the interpolation mode associated with this Graphics.
        /// </summary>
        /// <value>Gets or sets the interpolation mode associated with this Graphics.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InterpolationModeEnum
        {
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>            
            Invalid,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum Low for "Low"
            /// </summary>            
            Low,
            
            /// <summary>
            /// Enum High for "High"
            /// </summary>            
            High,
            
            /// <summary>
            /// Enum Bilinear for "Bilinear"
            /// </summary>            
            Bilinear,
            
            /// <summary>
            /// Enum Bicubic for "Bicubic"
            /// </summary>            
            Bicubic,
            
            /// <summary>
            /// Enum NearestNeighbor for "NearestNeighbor"
            /// </summary>            
            NearestNeighbor,
            
            /// <summary>
            /// Enum HighQualityBilinear for "HighQualityBilinear"
            /// </summary>            
            HighQualityBilinear,
            
            /// <summary>
            /// Enum HighQualityBicubic for "HighQualityBicubic"
            /// </summary>            
            HighQualityBicubic
        }

        /// <summary>
        /// Gets or sets the rendering quality for this Graphics.
        /// </summary>
        /// <value>Gets or sets the rendering quality for this Graphics.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SmoothingModeEnum
        {
            
            /// <summary>
            /// Enum Invalid for "Invalid"
            /// </summary>            
            Invalid,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum HighSpeed for "HighSpeed"
            /// </summary>            
            HighSpeed,
            
            /// <summary>
            /// Enum HighQuality for "HighQuality"
            /// </summary>            
            HighQuality,
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum AntiAlias for "AntiAlias"
            /// </summary>            
            AntiAlias
        }

        /// <summary>
        /// Gets or sets the rendering mode for text associated with this Graphics.
        /// </summary>
        /// <value>Gets or sets the rendering mode for text associated with this Graphics.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextRenderingHintEnum
        {
            
            /// <summary>
            /// Enum SystemDefault for "SystemDefault"
            /// </summary>            
            SystemDefault,
            
            /// <summary>
            /// Enum SingleBitPerPixelGridFit for "SingleBitPerPixelGridFit"
            /// </summary>            
            SingleBitPerPixelGridFit,
            
            /// <summary>
            /// Enum SingleBitPerPixel for "SingleBitPerPixel"
            /// </summary>            
            SingleBitPerPixel,
            
            /// <summary>
            /// Enum AntiAliasGridFit for "AntiAliasGridFit"
            /// </summary>            
            AntiAliasGridFit,
            
            /// <summary>
            /// Enum AntiAlias for "AntiAlias"
            /// </summary>            
            AntiAlias,
            
            /// <summary>
            /// Enum ClearTypeGridFit for "ClearTypeGridFit"
            /// </summary>            
            ClearTypeGridFit
        }

        /// <summary>
        /// Gets or sets a value that specifies how composited images are drawn to this Graphics.
        /// </summary>
        /// <value>Gets or sets a value that specifies how composited images are drawn to this Graphics.</value>
        public CompositingModeEnum? CompositingMode { get; set; }

        /// <summary>
        /// Gets or sets the rendering quality of composited images drawn to this Graphics.
        /// </summary>
        /// <value>Gets or sets the rendering quality of composited images drawn to this Graphics.</value>
        public CompositingQualityEnum? CompositingQuality { get; set; }

        /// <summary>
        /// Gets or sets the interpolation mode associated with this Graphics.
        /// </summary>
        /// <value>Gets or sets the interpolation mode associated with this Graphics.</value>
        public InterpolationModeEnum? InterpolationMode { get; set; }

        /// <summary>
        /// Gets or sets the rendering quality for this Graphics.
        /// </summary>
        /// <value>Gets or sets the rendering quality for this Graphics.</value>
        public SmoothingModeEnum? SmoothingMode { get; set; }

        /// <summary>
        /// Gets or sets the rendering mode for text associated with this Graphics.
        /// </summary>
        /// <value>Gets or sets the rendering mode for text associated with this Graphics.</value>
        public TextRenderingHintEnum? TextRenderingHint { get; set; }

        /// <summary>
        /// Gets or sets text layout information (such as alignment, orientation and tab stops) display manipulations (such as ellipsis insertion and national digit substitution) and OpenType features.
        /// </summary>  
        public StringFormatData StringFormat { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class GraphicsQualityOptionsData {\n");
          sb.Append("  CompositingMode: ").Append(this.CompositingMode).Append("\n");
          sb.Append("  CompositingQuality: ").Append(this.CompositingQuality).Append("\n");
          sb.Append("  InterpolationMode: ").Append(this.InterpolationMode).Append("\n");
          sb.Append("  SmoothingMode: ").Append(this.SmoothingMode).Append("\n");
          sb.Append("  StringFormat: ").Append(this.StringFormat).Append("\n");
          sb.Append("  TextRenderingHint: ").Append(this.TextRenderingHint).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
