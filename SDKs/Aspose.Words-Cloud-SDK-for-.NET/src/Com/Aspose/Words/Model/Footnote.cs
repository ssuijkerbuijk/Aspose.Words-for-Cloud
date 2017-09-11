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
  /// Footnote.
  /// </summary>  
  public class Footnote 
  {                       
        /// <summary>
        /// Returns a value that specifies whether this is a footnote or endnote.
        /// </summary>
        /// <value>Returns a value that specifies whether this is a footnote or endnote.</value>
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
        /// Returns a value that specifies whether this is a footnote or endnote.
        /// </summary>
        /// <value>Returns a value that specifies whether this is a footnote or endnote.</value>
        public FootnoteTypeEnum? FootnoteType { get; set; }

        /// <summary>
        /// Link to comment range start node.
        /// </summary>
        /// <value>Link to comment range start node.</value>    
        public DocumentPosition Position { get; set; }

        /// <summary>
        /// Gets/sets custom reference mark to be used for this footnote.  Default value is {System.String.Empty}, meaning auto-numbered footnotes are used.
        /// </summary>
        /// <value>Gets/sets custom reference mark to be used for this footnote.  Default value is {System.String.Empty}, meaning auto-numbered footnotes are used.</value>    
        public string ReferenceMark { get; set; }

        /// <summary>
        /// This is a convenience property that allows to easily get or set text of the footnote.
        /// </summary>
        /// <value>This is a convenience property that allows to easily get or set text of the footnote.</value>    
        public string Text { get; set; }

        /// <summary>
        /// Content of footnote.
        /// </summary>
        /// <value>Content of footnote.</value>    
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>    
        public string NodeId { get; set; }

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
          sb.Append("class Footnote {\n");
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
