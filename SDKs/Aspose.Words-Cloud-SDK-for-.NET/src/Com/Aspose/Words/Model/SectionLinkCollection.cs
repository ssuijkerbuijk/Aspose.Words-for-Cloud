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
  public class SectionLinkCollection 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionLinkCollection" /> class.
        /// </summary>
        /// <param name="SectionLinkList">SectionLinkList.</param>
        /// <param name="Link">Link.</param>
        public SectionLinkCollection(List<SectionLink> SectionLinkList = default(List<SectionLink>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.SectionLinkList = SectionLinkList;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets SectionLinkList
        /// </summary>    
        public List<SectionLink> SectionLinkList { get; set; }

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
          sb.Append("class SectionLinkCollection {\n");
          sb.Append("  SectionLinkList: ").Append(SectionLinkList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
