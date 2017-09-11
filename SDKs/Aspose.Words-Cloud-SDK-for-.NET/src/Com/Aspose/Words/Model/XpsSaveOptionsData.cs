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
  /// Container class for xps save options.
  /// </summary>  
  public class XpsSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the level in the XPS document outline at which to display Word bookmarks.
        /// </summary>
        /// <value>Specifies the level in the XPS document outline at which to display Word bookmarks.</value>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the XPS document outline.
        /// </summary>
        /// <value>Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the XPS document outline.</value>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Allows to specify outline options
        /// </summary>
        /// <value>Allows to specify outline options</value>    
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Determines whether the document should be saved using a booklet printing layout
        /// </summary>
        /// <value>Determines whether the document should be saved using a booklet printing layout</value>    
        public bool? UseBookFoldPrintingSettings { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class XpsSaveOptionsData {\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(BookmarksOutlineLevel).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(HeadingsOutlineLevels).Append("\n");
          sb.Append("  OutlineOptions: ").Append(OutlineOptions).Append("\n");
          sb.Append("  UseBookFoldPrintingSettings: ").Append(UseBookFoldPrintingSettings).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
