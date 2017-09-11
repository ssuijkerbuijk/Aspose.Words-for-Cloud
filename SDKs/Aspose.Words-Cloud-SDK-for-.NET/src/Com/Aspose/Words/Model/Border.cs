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
  /// Represents a border of an object.
  /// </summary>  
  public class Border 
  {                       
        /// <summary>
        /// Gets or sets the border type.
        /// </summary>
        /// <value>Gets or sets the border type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BorderTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>            
            Left,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>            
            Horizontal,
            
            /// <summary>
            /// Enum Vertical for "Vertical"
            /// </summary>            
            Vertical,
            
            /// <summary>
            /// Enum DiagonalDown for "DiagonalDown"
            /// </summary>            
            DiagonalDown,
            
            /// <summary>
            /// Enum DiagonalUp for "DiagonalUp"
            /// </summary>            
            DiagonalUp
        }

        /// <summary>
        /// Gets or sets the border style.
        /// </summary>
        /// <value>Gets or sets the border style.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineStyleEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Single for "Single"
            /// </summary>            
            Single,
            
            /// <summary>
            /// Enum Thick for "Thick"
            /// </summary>            
            Thick,
            
            /// <summary>
            /// Enum Double for "Double"
            /// </summary>            
            Double,
            
            /// <summary>
            /// Enum Hairline for "Hairline"
            /// </summary>            
            Hairline,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>            
            Dot,
            
            /// <summary>
            /// Enum DashLargeGap for "DashLargeGap"
            /// </summary>            
            DashLargeGap,
            
            /// <summary>
            /// Enum DotDash for "DotDash"
            /// </summary>            
            DotDash,
            
            /// <summary>
            /// Enum DotDotDash for "DotDotDash"
            /// </summary>            
            DotDotDash,
            
            /// <summary>
            /// Enum Triple for "Triple"
            /// </summary>            
            Triple,
            
            /// <summary>
            /// Enum ThinThickSmallGap for "ThinThickSmallGap"
            /// </summary>            
            ThinThickSmallGap,
            
            /// <summary>
            /// Enum ThickThinSmallGap for "ThickThinSmallGap"
            /// </summary>            
            ThickThinSmallGap,
            
            /// <summary>
            /// Enum ThinThickThinSmallGap for "ThinThickThinSmallGap"
            /// </summary>            
            ThinThickThinSmallGap,
            
            /// <summary>
            /// Enum ThinThickMediumGap for "ThinThickMediumGap"
            /// </summary>            
            ThinThickMediumGap,
            
            /// <summary>
            /// Enum ThickThinMediumGap for "ThickThinMediumGap"
            /// </summary>            
            ThickThinMediumGap,
            
            /// <summary>
            /// Enum ThinThickThinMediumGap for "ThinThickThinMediumGap"
            /// </summary>            
            ThinThickThinMediumGap,
            
            /// <summary>
            /// Enum ThinThickLargeGap for "ThinThickLargeGap"
            /// </summary>            
            ThinThickLargeGap,
            
            /// <summary>
            /// Enum ThickThinLargeGap for "ThickThinLargeGap"
            /// </summary>            
            ThickThinLargeGap,
            
            /// <summary>
            /// Enum ThinThickThinLargeGap for "ThinThickThinLargeGap"
            /// </summary>            
            ThinThickThinLargeGap,
            
            /// <summary>
            /// Enum Wave for "Wave"
            /// </summary>            
            Wave,
            
            /// <summary>
            /// Enum DoubleWave for "DoubleWave"
            /// </summary>            
            DoubleWave,
            
            /// <summary>
            /// Enum DashSmallGap for "DashSmallGap"
            /// </summary>            
            DashSmallGap,
            
            /// <summary>
            /// Enum DashDotStroker for "DashDotStroker"
            /// </summary>            
            DashDotStroker,
            
            /// <summary>
            /// Enum Emboss3D for "Emboss3D"
            /// </summary>            
            Emboss3D,
            
            /// <summary>
            /// Enum Engrave3D for "Engrave3D"
            /// </summary>            
            Engrave3D,
            
            /// <summary>
            /// Enum Outset for "Outset"
            /// </summary>            
            Outset,
            
            /// <summary>
            /// Enum Inset for "Inset"
            /// </summary>            
            Inset
        }

        /// <summary>
        /// Gets or sets the border type.
        /// </summary>
        /// <value>Gets or sets the border type.</value>
        public BorderTypeEnum? BorderType { get; set; }

        /// <summary>
        /// Gets or sets the border style.
        /// </summary>
        /// <value>Gets or sets the border style.</value>
        public LineStyleEnum? LineStyle { get; set; }

        /// <summary>
        /// Gets or sets the border color.
        /// </summary>
        /// <value>Gets or sets the border color.</value>    
        public XmlColor Color { get; set; }

        /// <summary>
        /// Gets or sets distance of the border from text or from the page edge in points.
        /// </summary>
        /// <value>Gets or sets distance of the border from text or from the page edge in points.</value>    
        public double? DistanceFromText { get; set; }

        /// <summary>
        /// Gets or sets the border width in points.
        /// </summary>
        /// <value>Gets or sets the border width in points.</value>    
        public double? LineWidth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the border has a shadow.
        /// </summary>
        /// <value>Gets or sets a value indicating whether the border has a shadow.</value>    
        public bool? Shadow { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Border {\n");
          sb.Append("  BorderType: ").Append(BorderType).Append("\n");
          sb.Append("  Color: ").Append(Color).Append("\n");
          sb.Append("  DistanceFromText: ").Append(DistanceFromText).Append("\n");
          sb.Append("  LineStyle: ").Append(LineStyle).Append("\n");
          sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
          sb.Append("  Shadow: ").Append(Shadow).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
