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
  /// Section element
  /// </summary>  
  public class HeaderFooter 
  {                       
        /// <summary>
        /// Paragraph&#39;s text
        /// </summary>
        /// <value>Paragraph&#39;s text</value>
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
        /// Paragraph&#39;s text
        /// </summary>
        /// <value>Paragraph&#39;s text</value>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Link to Paragraphs resource
        /// </summary>
        /// <value>Link to Paragraphs resource</value>    
        public LinkElement Paragraphs { get; set; }

        /// <summary>
        /// Link to DrawingObjects resource
        /// </summary>
        /// <value>Link to DrawingObjects resource</value>    
        public LinkElement DrawingObjects { get; set; }

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
          sb.Append("class HeaderFooter {\n");
          sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
          sb.Append("  DrawingObjects: ").Append(DrawingObjects).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
