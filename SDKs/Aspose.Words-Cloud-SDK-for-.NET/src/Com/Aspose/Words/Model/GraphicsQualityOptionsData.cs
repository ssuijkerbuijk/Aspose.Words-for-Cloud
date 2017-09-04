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
  public class GraphicsQualityOptionsData 
  {                       
        /// <summary>
        /// Gets or sets CompositingMode
        /// </summary>
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
        /// Gets or sets CompositingQuality
        /// </summary>
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
        /// Gets or sets InterpolationMode
        /// </summary>
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
        /// Gets or sets SmoothingMode
        /// </summary>
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
        /// Gets or sets TextRenderingHint
        /// </summary>
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
        /// Gets or sets CompositingMode
        /// </summary>
        public CompositingModeEnum? CompositingMode { get; set; }

        /// <summary>
        /// Gets or sets CompositingQuality
        /// </summary>
        public CompositingQualityEnum? CompositingQuality { get; set; }

        /// <summary>
        /// Gets or sets InterpolationMode
        /// </summary>
        public InterpolationModeEnum? InterpolationMode { get; set; }

        /// <summary>
        /// Gets or sets SmoothingMode
        /// </summary>
        public SmoothingModeEnum? SmoothingMode { get; set; }

        /// <summary>
        /// Gets or sets TextRenderingHint
        /// </summary>
        public TextRenderingHintEnum? TextRenderingHint { get; set; }

        /// <summary>
        /// Gets or sets StringFormat
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
          sb.Append("  CompositingMode: ").Append(CompositingMode).Append("\n");
          sb.Append("  CompositingQuality: ").Append(CompositingQuality).Append("\n");
          sb.Append("  InterpolationMode: ").Append(InterpolationMode).Append("\n");
          sb.Append("  SmoothingMode: ").Append(SmoothingMode).Append("\n");
          sb.Append("  StringFormat: ").Append(StringFormat).Append("\n");
          sb.Append("  TextRenderingHint: ").Append(TextRenderingHint).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
