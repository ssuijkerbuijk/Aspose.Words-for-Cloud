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
  /// container class for outline options
  /// </summary>  
  public class OutlineOptionsData 
  {                       
        /// <summary>
        /// Allows to specify individual bookmarks outline level
        /// </summary>
        /// <value>Allows to specify individual bookmarks outline level</value>    
        public List<BookmarksOutlineLevelData> BookmarksOutlineLevels { get; set; }

        /// <summary>
        /// Specifies the default level in the document outline at which to display Word bookmarks
        /// </summary>
        /// <value>Specifies the default level in the document outline at which to display Word bookmarks</value>    
        public int? DefaultBookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies how many levels in the document outline to show expanded when the file is viewed
        /// </summary>
        /// <value>Specifies how many levels in the document outline to show expanded when the file is viewed</value>    
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the document outline
        /// </summary>
        /// <value>Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the document outline</value>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OutlineOptionsData {\n");
          sb.Append("  BookmarksOutlineLevels: ").Append(BookmarksOutlineLevels).Append("\n");
          sb.Append("  DefaultBookmarksOutlineLevel: ").Append(DefaultBookmarksOutlineLevel).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(ExpandedOutlineLevels).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(HeadingsOutlineLevels).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
