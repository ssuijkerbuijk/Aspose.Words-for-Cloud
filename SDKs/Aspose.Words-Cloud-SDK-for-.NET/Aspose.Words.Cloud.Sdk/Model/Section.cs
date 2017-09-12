namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Section element
  /// </summary>  
  public class Section 
  {                       
        /// <summary>
        /// Link to Paragraphs resource
        /// </summary>  
        public LinkElement Paragraphs { get; set; }

        /// <summary>
        /// Link to PageSetup resource
        /// </summary>  
        public LinkElement PageSetup { get; set; }

        /// <summary>
        /// Link to HeaderFooters resource
        /// </summary>  
        public LinkElement HeaderFooters { get; set; }

        /// <summary>
        /// Link to Tables resource
        /// </summary>  
        public LinkElement Tables { get; set; }

        /// <summary>
        /// Child nodes.
        /// </summary>  
        public List<Object> ChildNodes { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>  
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Section {\n");
          sb.Append("  Paragraphs: ").Append(this.Paragraphs).Append("\n");
          sb.Append("  PageSetup: ").Append(this.PageSetup).Append("\n");
          sb.Append("  HeaderFooters: ").Append(this.HeaderFooters).Append("\n");
          sb.Append("  Tables: ").Append(this.Tables).Append("\n");
          sb.Append("  ChildNodes: ").Append(this.ChildNodes).Append("\n");
          sb.Append("  Link: ").Append(this.Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
