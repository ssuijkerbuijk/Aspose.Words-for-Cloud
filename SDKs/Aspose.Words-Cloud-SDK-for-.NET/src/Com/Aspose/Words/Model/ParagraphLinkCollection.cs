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
  public class ParagraphLinkCollection 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphLinkCollection" /> class.
        /// </summary>
        /// <param name="ParagraphLinkList">ParagraphLinkList.</param>
        /// <param name="Link">Link.</param>
        public ParagraphLinkCollection(List<ParagraphLink> ParagraphLinkList = default(List<ParagraphLink>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.ParagraphLinkList = ParagraphLinkList;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets ParagraphLinkList
        /// </summary>    
        public List<ParagraphLink> ParagraphLinkList { get; set; }

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
          sb.Append("class ParagraphLinkCollection {\n");
          sb.Append("  ParagraphLinkList: ").Append(ParagraphLinkList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
