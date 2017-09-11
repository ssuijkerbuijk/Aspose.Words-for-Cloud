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
  /// Represents all formatting for a table row.
  /// </summary>  
  public class TableCellFormat 
  {                       
        /// <summary>
        /// Specifies how the cell is merged horizontally with other cells in the row.
        /// </summary>
        /// <value>Specifies how the cell is merged horizontally with other cells in the row.</value>
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
        /// Returns or sets the orientation of text in a table cell.
        /// </summary>
        /// <value>Returns or sets the orientation of text in a table cell.</value>
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
        /// Returns or sets the vertical alignment of text in the cell.
        /// </summary>
        /// <value>Returns or sets the vertical alignment of text in the cell.</value>
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
        /// Specifies how the cell is merged with other cells vertically.
        /// </summary>
        /// <value>Specifies how the cell is merged with other cells vertically.</value>
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
        /// Specifies how the cell is merged horizontally with other cells in the row.
        /// </summary>
        /// <value>Specifies how the cell is merged horizontally with other cells in the row.</value>
        public HorizontalMergeEnum? HorizontalMerge { get; set; }

        /// <summary>
        /// Returns or sets the orientation of text in a table cell.
        /// </summary>
        /// <value>Returns or sets the orientation of text in a table cell.</value>
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        /// Returns or sets the vertical alignment of text in the cell.
        /// </summary>
        /// <value>Returns or sets the vertical alignment of text in the cell.</value>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Specifies how the cell is merged with other cells vertically.
        /// </summary>
        /// <value>Specifies how the cell is merged with other cells vertically.</value>
        public VerticalMergeEnum? VerticalMerge { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add below the contents of cell.
        /// </summary>
        /// <value>Returns or sets the amount of space (in points) to add below the contents of cell.</value>    
        public double? BottomPadding { get; set; }

        /// <summary>
        /// If true, fits text in the cell, compressing each paragraph to the width of the cell.
        /// </summary>
        /// <value>If true, fits text in the cell, compressing each paragraph to the width of the cell.</value>    
        public bool? FitText { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add to the left of the contents of cell.
        /// </summary>
        /// <value>Returns or sets the amount of space (in points) to add to the left of the contents of cell.</value>    
        public double? LeftPadding { get; set; }

        /// <summary>
        /// Returns or sets the preferred width of the cell.
        /// </summary>
        /// <value>Returns or sets the preferred width of the cell.</value>    
        public PreferredWidth PreferredWidth { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add to the right of the contents of cell.
        /// </summary>
        /// <value>Returns or sets the amount of space (in points) to add to the right of the contents of cell.</value>    
        public double? RightPadding { get; set; }

        /// <summary>
        /// Returns or sets the amount of space (in points) to add above the contents of cell.
        /// </summary>
        /// <value>Returns or sets the amount of space (in points) to add above the contents of cell.</value>    
        public double? TopPadding { get; set; }

        /// <summary>
        /// Gets the width of the cell in points.
        /// </summary>
        /// <value>Gets the width of the cell in points.</value>    
        public double? Width { get; set; }

        /// <summary>
        /// If true, wrap text for the cell.
        /// </summary>
        /// <value>If true, wrap text for the cell.</value>    
        public bool? WrapText { get; set; }

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
          sb.Append("class TableCellFormat {\n");
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
