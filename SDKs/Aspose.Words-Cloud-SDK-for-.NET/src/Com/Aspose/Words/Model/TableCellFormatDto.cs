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
        /// Initializes a new instance of the <see cref="TableCellFormatDto" /> class.
        /// </summary>
        /// <param name="BottomPadding">BottomPadding.</param>
        /// <param name="FitText">FitText.</param>
        /// <param name="HorizontalMerge">HorizontalMerge.</param>
        /// <param name="LeftPadding">LeftPadding.</param>
        /// <param name="Orientation">Orientation.</param>
        /// <param name="PreferredWidth">PreferredWidth.</param>
        /// <param name="RightPadding">RightPadding.</param>
        /// <param name="TopPadding">TopPadding.</param>
        /// <param name="VerticalAlignment">VerticalAlignment.</param>
        /// <param name="VerticalMerge">VerticalMerge.</param>
        /// <param name="Width">Width.</param>
        /// <param name="WrapText">WrapText.</param>
        /// <param name="Link">Link.</param>
        public TableCellFormatDto(double? BottomPadding = default(double?), bool? FitText = default(bool?), HorizontalMergeEnum? HorizontalMerge = default(HorizontalMergeEnum?), double? LeftPadding = default(double?), OrientationEnum? Orientation = default(OrientationEnum?), PreferredWidthDto PreferredWidth = default(PreferredWidthDto), double? RightPadding = default(double?), double? TopPadding = default(double?), VerticalAlignmentEnum? VerticalAlignment = default(VerticalAlignmentEnum?), VerticalMergeEnum? VerticalMerge = default(VerticalMergeEnum?), double? Width = default(double?), bool? WrapText = default(bool?), WordsApiLink Link = default(WordsApiLink))
        {
                        this.BottomPadding = BottomPadding;
                        this.FitText = FitText;
                        this.HorizontalMerge = HorizontalMerge;
                        this.LeftPadding = LeftPadding;
                        this.Orientation = Orientation;
                        this.PreferredWidth = PreferredWidth;
                        this.RightPadding = RightPadding;
                        this.TopPadding = TopPadding;
                        this.VerticalAlignment = VerticalAlignment;
                        this.VerticalMerge = VerticalMerge;
                        this.Width = Width;
                        this.WrapText = WrapText;
                        this.Link = Link;
        }

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
