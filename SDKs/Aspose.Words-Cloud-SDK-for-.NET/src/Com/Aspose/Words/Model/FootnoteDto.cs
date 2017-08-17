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
  public class FootnoteDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="FootnoteDto" /> class.
        /// </summary>
        /// <param name="Position">Position.</param>
        /// <param name="FootnoteType">FootnoteType.</param>
        /// <param name="ReferenceMark">ReferenceMark.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Content">Content.</param>
        /// <param name="NodeId">NodeId.</param>
        /// <param name="Link">Link.</param>
        public FootnoteDto(DocumentPositionDto Position = default(DocumentPositionDto), FootnoteTypeEnum? FootnoteType = default(FootnoteTypeEnum?), string ReferenceMark = default(string), string Text = default(string), StoryChildNodes Content = default(StoryChildNodes), string NodeId = default(string), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Position = Position;
                        this.FootnoteType = FootnoteType;
                        this.ReferenceMark = ReferenceMark;
                        this.Text = Text;
                        this.Content = Content;
                        this.NodeId = NodeId;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets FootnoteType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FootnoteTypeEnum
        {
            
            /// <summary>
            /// Enum Footnote for "Footnote"
            /// </summary>            
            Footnote,
            
            /// <summary>
            /// Enum Endnote for "Endnote"
            /// </summary>            
            Endnote
        }

        /// <summary>
        /// Gets or sets FootnoteType
        /// </summary>
        public FootnoteTypeEnum? FootnoteType { get; set; }

        /// <summary>
        /// Gets or sets Position
        /// </summary>    
        public DocumentPositionDto Position { get; set; }

        /// <summary>
        /// Gets or sets ReferenceMark
        /// </summary>    
        public string ReferenceMark { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>    
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets Content
        /// </summary>    
        public StoryChildNodes Content { get; set; }

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
          sb.Append("class FootnoteDto {\n");
          sb.Append("  Position: ").Append(Position).Append("\n");
          sb.Append("  FootnoteType: ").Append(FootnoteType).Append("\n");
          sb.Append("  ReferenceMark: ").Append(ReferenceMark).Append("\n");
          sb.Append("  Text: ").Append(Text).Append("\n");
          sb.Append("  Content: ").Append(Content).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
