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
  public class DrawingObject 
  {                       
        /// <summary>
        /// Gets or sets RelativeHorizontalPosition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeHorizontalPositionEnum
        {
            
            /// <summary>
            /// Enum Margin for "Margin"
            /// </summary>            
            Margin,
            
            /// <summary>
            /// Enum Page for "Page"
            /// </summary>            
            Page,
            
            /// <summary>
            /// Enum Column for "Column"
            /// </summary>            
            Column,
            
            /// <summary>
            /// Enum Character for "Character"
            /// </summary>            
            Character,
            
            /// <summary>
            /// Enum LeftMargin for "LeftMargin"
            /// </summary>            
            LeftMargin,
            
            /// <summary>
            /// Enum RightMargin for "RightMargin"
            /// </summary>            
            RightMargin,
            
            /// <summary>
            /// Enum InsideMargin for "InsideMargin"
            /// </summary>            
            InsideMargin,
            
            /// <summary>
            /// Enum OutsideMargin for "OutsideMargin"
            /// </summary>            
            OutsideMargin,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default
        }

        /// <summary>
        /// Gets or sets RelativeVerticalPosition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelativeVerticalPositionEnum
        {
            
            /// <summary>
            /// Enum Margin for "Margin"
            /// </summary>            
            Margin,
            
            /// <summary>
            /// Enum Page for "Page"
            /// </summary>            
            Page,
            
            /// <summary>
            /// Enum Paragraph for "Paragraph"
            /// </summary>            
            Paragraph,
            
            /// <summary>
            /// Enum Line for "Line"
            /// </summary>            
            Line,
            
            /// <summary>
            /// Enum TopMargin for "TopMargin"
            /// </summary>            
            TopMargin,
            
            /// <summary>
            /// Enum BottomMargin for "BottomMargin"
            /// </summary>            
            BottomMargin,
            
            /// <summary>
            /// Enum InsideMargin for "InsideMargin"
            /// </summary>            
            InsideMargin,
            
            /// <summary>
            /// Enum OutsideMargin for "OutsideMargin"
            /// </summary>            
            OutsideMargin,
            
            /// <summary>
            /// Enum TableDefault for "TableDefault"
            /// </summary>            
            TableDefault,
            
            /// <summary>
            /// Enum TextFrameDefault for "TextFrameDefault"
            /// </summary>            
            TextFrameDefault
        }

        /// <summary>
        /// Gets or sets WrapType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WrapTypeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline,
            
            /// <summary>
            /// Enum TopBottom for "TopBottom"
            /// </summary>            
            TopBottom,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>            
            Square,
            
            /// <summary>
            /// Enum Tight for "Tight"
            /// </summary>            
            Tight,
            
            /// <summary>
            /// Enum Through for "Through"
            /// </summary>            
            Through
        }

        /// <summary>
        /// Gets or sets RelativeHorizontalPosition
        /// </summary>
        public RelativeHorizontalPositionEnum? RelativeHorizontalPosition { get; set; }

        /// <summary>
        /// Gets or sets RelativeVerticalPosition
        /// </summary>
        public RelativeVerticalPositionEnum? RelativeVerticalPosition { get; set; }

        /// <summary>
        /// Gets or sets WrapType
        /// </summary>
        public WrapTypeEnum? WrapType { get; set; }

        /// <summary>
        /// Gets or sets RenderLinks
        /// </summary>    
        public List<WordsApiLink> RenderLinks { get; set; }

        /// <summary>
        /// Gets or sets Width
        /// </summary>    
        public double? Width { get; set; }

        /// <summary>
        /// Gets or sets Height
        /// </summary>    
        public double? Height { get; set; }

        /// <summary>
        /// Gets or sets OleDataLink
        /// </summary>    
        public WordsApiLink OleDataLink { get; set; }

        /// <summary>
        /// Gets or sets ImageDataLink
        /// </summary>    
        public WordsApiLink ImageDataLink { get; set; }

        /// <summary>
        /// Gets or sets Left
        /// </summary>    
        public double? Left { get; set; }

        /// <summary>
        /// Gets or sets Top
        /// </summary>    
        public double? Top { get; set; }

        /// <summary>
        /// Gets or sets NodeId
        /// </summary>    
        public string NodeId { get; set; }

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
          sb.Append("class DrawingObject {\n");
          sb.Append("  RenderLinks: ").Append(RenderLinks).Append("\n");
          sb.Append("  Width: ").Append(Width).Append("\n");
          sb.Append("  Height: ").Append(Height).Append("\n");
          sb.Append("  OleDataLink: ").Append(OleDataLink).Append("\n");
          sb.Append("  ImageDataLink: ").Append(ImageDataLink).Append("\n");
          sb.Append("  RelativeHorizontalPosition: ").Append(RelativeHorizontalPosition).Append("\n");
          sb.Append("  Left: ").Append(Left).Append("\n");
          sb.Append("  RelativeVerticalPosition: ").Append(RelativeVerticalPosition).Append("\n");
          sb.Append("  Top: ").Append(Top).Append("\n");
          sb.Append("  WrapType: ").Append(WrapType).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
