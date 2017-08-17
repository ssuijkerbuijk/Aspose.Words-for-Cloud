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
  public class HeaderFooterDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderFooterDto" /> class.
        /// </summary>
        /// <param name="Paragraphs">Paragraphs.</param>
        /// <param name="DrawingObjects">DrawingObjects.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Link">Link.</param>
        public HeaderFooterDto(LinkElement Paragraphs = default(LinkElement), LinkElement DrawingObjects = default(LinkElement), TypeEnum? Type = default(TypeEnum?), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Paragraphs = Paragraphs;
                        this.DrawingObjects = DrawingObjects;
                        this.Type = Type;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum HeaderEven for "HeaderEven"
            /// </summary>            
            HeaderEven,
            
            /// <summary>
            /// Enum HeaderPrimary for "HeaderPrimary"
            /// </summary>            
            HeaderPrimary,
            
            /// <summary>
            /// Enum FooterEven for "FooterEven"
            /// </summary>            
            FooterEven,
            
            /// <summary>
            /// Enum FooterPrimary for "FooterPrimary"
            /// </summary>            
            FooterPrimary,
            
            /// <summary>
            /// Enum HeaderFirst for "HeaderFirst"
            /// </summary>            
            HeaderFirst,
            
            /// <summary>
            /// Enum FooterFirst for "FooterFirst"
            /// </summary>            
            FooterFirst
        }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets Paragraphs
        /// </summary>    
        public LinkElement Paragraphs { get; set; }

        /// <summary>
        /// Gets or sets DrawingObjects
        /// </summary>    
        public LinkElement DrawingObjects { get; set; }

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
          sb.Append("class HeaderFooterDto {\n");
          sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
          sb.Append("  DrawingObjects: ").Append(DrawingObjects).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
