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
  public class Section 
  {                       
        /// <summary>
        /// Link to Paragraphs resource
        /// </summary>
        /// <value>Link to Paragraphs resource</value>    
        public LinkElement Paragraphs { get; set; }

        /// <summary>
        /// Link to PageSetup resource
        /// </summary>
        /// <value>Link to PageSetup resource</value>    
        public LinkElement PageSetup { get; set; }

        /// <summary>
        /// Link to HeaderFooters resource
        /// </summary>
        /// <value>Link to HeaderFooters resource</value>    
        public LinkElement HeaderFooters { get; set; }

        /// <summary>
        /// Link to Tables resource
        /// </summary>
        /// <value>Link to Tables resource</value>    
        public LinkElement Tables { get; set; }

        /// <summary>
        /// Child nodes.
        /// </summary>
        /// <value>Child nodes.</value>    
        public List<Object> ChildNodes { get; set; }

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
          sb.Append("class Section {\n");
          sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
          sb.Append("  PageSetup: ").Append(PageSetup).Append("\n");
          sb.Append("  HeaderFooters: ").Append(HeaderFooters).Append("\n");
          sb.Append("  Tables: ").Append(Tables).Append("\n");
          sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
