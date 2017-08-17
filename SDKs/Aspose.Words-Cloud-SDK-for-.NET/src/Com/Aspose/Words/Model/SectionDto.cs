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
        /// Initializes a new instance of the <see cref="SectionDto" /> class.
        /// </summary>
        /// <param name="Paragraphs">Paragraphs.</param>
        /// <param name="PageSetup">PageSetup.</param>
        /// <param name="HeaderFooters">HeaderFooters.</param>
        /// <param name="Tables">Tables.</param>
        /// <param name="ChildNodes">ChildNodes.</param>
        /// <param name="Link">Link.</param>
        public SectionDto(LinkElement Paragraphs = default(LinkElement), LinkElement PageSetup = default(LinkElement), LinkElement HeaderFooters = default(LinkElement), LinkElement Tables = default(LinkElement), List<Object> ChildNodes = default(List<Object>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Paragraphs = Paragraphs;
                        this.PageSetup = PageSetup;
                        this.HeaderFooters = HeaderFooters;
                        this.Tables = Tables;
                        this.ChildNodes = ChildNodes;
                        this.Link = Link;
        }

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
