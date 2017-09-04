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
  public class OutlineOptionsData 
  {                       
        /// <summary>
        /// Gets or sets BookmarksOutlineLevels
        /// </summary>    
        public List<BookmarksOutlineLevelData> BookmarksOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets DefaultBookmarksOutlineLevel
        /// </summary>    
        public int? DefaultBookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets ExpandedOutlineLevels
        /// </summary>    
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets HeadingsOutlineLevels
        /// </summary>    
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
