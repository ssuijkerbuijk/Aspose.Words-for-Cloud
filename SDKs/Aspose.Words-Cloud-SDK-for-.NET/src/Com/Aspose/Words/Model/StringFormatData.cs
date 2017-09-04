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
  public class StringFormatData 
  {                       
        /// <summary>
        /// Gets or sets Alignment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlignmentEnum
        {
            
            /// <summary>
            /// Enum Near for "Near"
            /// </summary>            
            Near,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Far for "Far"
            /// </summary>            
            Far
        }

        /// <summary>
        /// Gets or sets FormatFlags
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatFlagsEnum
        {
            
            /// <summary>
            /// Enum DirectionRightToLeft for "DirectionRightToLeft"
            /// </summary>            
            DirectionRightToLeft,
            
            /// <summary>
            /// Enum DirectionVertical for "DirectionVertical"
            /// </summary>            
            DirectionVertical,
            
            /// <summary>
            /// Enum FitBlackBox for "FitBlackBox"
            /// </summary>            
            FitBlackBox,
            
            /// <summary>
            /// Enum DisplayFormatControl for "DisplayFormatControl"
            /// </summary>            
            DisplayFormatControl,
            
            /// <summary>
            /// Enum NoFontFallback for "NoFontFallback"
            /// </summary>            
            NoFontFallback,
            
            /// <summary>
            /// Enum MeasureTrailingSpaces for "MeasureTrailingSpaces"
            /// </summary>            
            MeasureTrailingSpaces,
            
            /// <summary>
            /// Enum NoWrap for "NoWrap"
            /// </summary>            
            NoWrap,
            
            /// <summary>
            /// Enum LineLimit for "LineLimit"
            /// </summary>            
            LineLimit,
            
            /// <summary>
            /// Enum NoClip for "NoClip"
            /// </summary>            
            NoClip
        }

        /// <summary>
        /// Gets or sets HotkeyPrefix
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HotkeyPrefixEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Show for "Show"
            /// </summary>            
            Show,
            
            /// <summary>
            /// Enum Hide for "Hide"
            /// </summary>            
            Hide
        }

        /// <summary>
        /// Gets or sets LineAlignment
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LineAlignmentEnum
        {
            
            /// <summary>
            /// Enum Near for "Near"
            /// </summary>            
            Near,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Far for "Far"
            /// </summary>            
            Far
        }

        /// <summary>
        /// Gets or sets Trimming
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TrimmingEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Character for "Character"
            /// </summary>            
            Character,
            
            /// <summary>
            /// Enum Word for "Word"
            /// </summary>            
            Word,
            
            /// <summary>
            /// Enum EllipsisCharacter for "EllipsisCharacter"
            /// </summary>            
            EllipsisCharacter,
            
            /// <summary>
            /// Enum EllipsisWord for "EllipsisWord"
            /// </summary>            
            EllipsisWord,
            
            /// <summary>
            /// Enum EllipsisPath for "EllipsisPath"
            /// </summary>            
            EllipsisPath
        }

        /// <summary>
        /// Gets or sets Alignment
        /// </summary>
        public AlignmentEnum? Alignment { get; set; }

        /// <summary>
        /// Gets or sets FormatFlags
        /// </summary>
        public FormatFlagsEnum? FormatFlags { get; set; }

        /// <summary>
        /// Gets or sets HotkeyPrefix
        /// </summary>
        public HotkeyPrefixEnum? HotkeyPrefix { get; set; }

        /// <summary>
        /// Gets or sets LineAlignment
        /// </summary>
        public LineAlignmentEnum? LineAlignment { get; set; }

        /// <summary>
        /// Gets or sets Trimming
        /// </summary>
        public TrimmingEnum? Trimming { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class StringFormatData {\n");
          sb.Append("  Alignment: ").Append(Alignment).Append("\n");
          sb.Append("  FormatFlags: ").Append(FormatFlags).Append("\n");
          sb.Append("  HotkeyPrefix: ").Append(HotkeyPrefix).Append("\n");
          sb.Append("  LineAlignment: ").Append(LineAlignment).Append("\n");
          sb.Append("  Trimming: ").Append(Trimming).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
