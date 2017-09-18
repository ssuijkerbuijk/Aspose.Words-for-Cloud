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
  /// container class for individual bookmarks outline level
  /// </summary>  
  public class BookmarksOutlineLevelData 
  {                       
        /// <summary>
        /// Specify the bookmark's name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Specify the bookmark's level
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
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(this.BookmarksOutlineLevel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
