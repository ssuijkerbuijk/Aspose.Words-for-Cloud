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
  public class SectionDto 
  {                       
        /// <summary>
        /// Gets or sets Paragraphs
        /// </summary>    
        public LinkElement Paragraphs { get; set; }

        /// <summary>
        /// Gets or sets PageSetup
        /// </summary>    
        public LinkElement PageSetup { get; set; }

        /// <summary>
        /// Gets or sets HeaderFooters
        /// </summary>    
        public LinkElement HeaderFooters { get; set; }

        /// <summary>
        /// Gets or sets Tables
        /// </summary>    
        public LinkElement Tables { get; set; }

        /// <summary>
        /// Gets or sets ChildNodes
        /// </summary>    
        public List<Object> ChildNodes { get; set; }

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
          sb.Append("class SectionDto {\n");
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
