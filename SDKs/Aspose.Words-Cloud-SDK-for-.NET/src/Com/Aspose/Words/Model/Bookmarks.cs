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
  public class Bookmarks 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmarks" /> class.
        /// </summary>
        /// <param name="BookmarkList">BookmarkList.</param>
        /// <param name="Link">Link.</param>
        public Bookmarks(List<Bookmark> BookmarkList = default(List<Bookmark>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.BookmarkList = BookmarkList;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets BookmarkList
        /// </summary>    
        public List<Bookmark> BookmarkList { get; set; }

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
          sb.Append("class Bookmarks {\n");
          sb.Append("  BookmarkList: ").Append(BookmarkList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
