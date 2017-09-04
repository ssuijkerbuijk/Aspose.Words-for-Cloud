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
  public class BookmarksOutlineLevelData 
  {                       
        /// <summary>
        /// Gets or sets Name
        /// </summary>    
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets BookmarksOutlineLevel
        /// </summary>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BookmarksOutlineLevelData {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(BookmarksOutlineLevel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
