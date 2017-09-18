namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// container class for outline options
  /// </summary>  
  public class OutlineOptionsData 
  {                       
        /// <summary>
        /// Allows to specify individual bookmarks outline level
        /// </summary>  
        public List<BookmarksOutlineLevelData> BookmarksOutlineLevels { get; set; }

        /// <summary>
        /// Specifies the default level in the document outline at which to display Word bookmarks
        /// </summary>  
        public int? DefaultBookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies how many levels in the document outline to show expanded when the file is viewed
        /// </summary>  
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the document outline
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
          sb.Append("  BookmarksOutlineLevels: ").Append(this.BookmarksOutlineLevels).Append("\n");
          sb.Append("  DefaultBookmarksOutlineLevel: ").Append(this.DefaultBookmarksOutlineLevel).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(this.ExpandedOutlineLevels).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(this.HeadingsOutlineLevels).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
