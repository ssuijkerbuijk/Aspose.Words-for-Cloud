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
  public class Hyperlinks 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperlinks" /> class.
        /// </summary>
        /// <param name="HyperlinkList">HyperlinkList.</param>
        /// <param name="Link">Link.</param>
        public Hyperlinks(List<Hyperlink> HyperlinkList = default(List<Hyperlink>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.HyperlinkList = HyperlinkList;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets HyperlinkList
        /// </summary>    
        public List<Hyperlink> HyperlinkList { get; set; }

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
          sb.Append("class Hyperlinks {\n");
          sb.Append("  HyperlinkList: ").Append(HyperlinkList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
