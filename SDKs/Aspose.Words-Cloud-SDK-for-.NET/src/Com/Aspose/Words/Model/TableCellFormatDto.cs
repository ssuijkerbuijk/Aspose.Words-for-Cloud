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
  public class TableCellFormatDto 
  {                       
        /// <summary>
        /// Gets or sets HorizontalMerge
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalMergeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum First for "First"
            /// </summary>            
            First,
            
            /// <summary>
            /// Enum Previous for "Previous"
            /// </summary>            
            Previous
        }

        /// <summary>
        /// Gets or sets Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            
            /// <summary>
            /// Enum Horizontal for "Horizontal"
            /// </summary>            
            Horizontal,
            
            /// <summary>
            /// Enum Downward for "Downward"
            /// </summary>            
            Downward,
            
            /// <summary>
            /// Enum Upward for "Upward"
            /// </summary>            
            Upward,
            
            /// <summary>
            /// Enum HorizontalRotatedFarEast for "HorizontalRotatedFarEast"
            /// </summary>            
            HorizontalRotatedFarEast,
            
            /// <summary>
            /// Enum VerticalFarEast for "VerticalFarEast"
            /// </summary>            
            VerticalFarEast,
            
            /// <summary>
            /// Enum VerticalRotatedFarEast for "VerticalRotatedFarEast"
            /// </summary>            
            VerticalRotatedFarEast
        }

        /// <summary>
        /// Gets or sets VerticalAlignment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        {
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom
        }

        /// <summary>
        /// Gets or sets VerticalMerge
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalMergeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum First for "First"
            /// </summary>            
            First,
            
            /// <summary>
            /// Enum Previous for "Previous"
            /// </summary>            
            Previous
        }

        /// <summary>
        /// Gets or sets HorizontalMerge
        /// </summary>
        public HorizontalMergeEnum? HorizontalMerge { get; set; }

        /// <summary>
        /// Gets or sets Orientation
        /// </summary>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Gets or sets VerticalAlignment
        /// </summary>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets VerticalMerge
        /// </summary>
        public VerticalMergeEnum? VerticalMerge { get; set; }

        /// <summary>
        /// Gets or sets BottomPadding
        /// </summary>    
        public double? BottomPadding { get; set; }

        /// <summary>
        /// Gets or sets FitText
        /// </summary>    
        public bool? FitText { get; set; }

        /// <summary>
        /// Gets or sets LeftPadding
        /// </summary>    
        public double? LeftPadding { get; set; }

        /// <summary>
        /// Gets or sets PreferredWidth
        /// </summary>    
        public PreferredWidthDto PreferredWidth { get; set; }

        /// <summary>
        /// Gets or sets RightPadding
        /// </summary>    
        public double? RightPadding { get; set; }

        /// <summary>
        /// Gets or sets TopPadding
        /// </summary>    
        public double? TopPadding { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>    
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets WrapText
        /// </summary>    
        public bool? WrapText { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TableCellFormatDto {\n");
          sb.Append("  BottomPadding: ").Append(BottomPadding).Append("\n");
          sb.Append("  FitText: ").Append(FitText).Append("\n");
          sb.Append("  HorizontalMerge: ").Append(HorizontalMerge).Append("\n");
          sb.Append("  LeftPadding: ").Append(LeftPadding).Append("\n");
          sb.Append("  Orientation: ").Append(Orientation).Append("\n");
          sb.Append("  PreferredWidth: ").Append(PreferredWidth).Append("\n");
          sb.Append("  RightPadding: ").Append(RightPadding).Append("\n");
          sb.Append("  TopPadding: ").Append(TopPadding).Append("\n");
          sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
          sb.Append("  VerticalMerge: ").Append(VerticalMerge).Append("\n");
          sb.Append("  Width: ").Append(Width).Append("\n");
          sb.Append("  WrapText: ").Append(WrapText).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
