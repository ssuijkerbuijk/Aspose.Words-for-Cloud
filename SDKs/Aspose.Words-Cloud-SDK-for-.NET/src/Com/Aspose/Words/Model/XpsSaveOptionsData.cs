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
  public class XpsSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets BookmarksOutlineLevel
        /// </summary>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets HeadingsOutlineLevels
        /// </summary>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets OutlineOptions
        /// </summary>    
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets UseBookFoldPrintingSettings
        /// </summary>    
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
