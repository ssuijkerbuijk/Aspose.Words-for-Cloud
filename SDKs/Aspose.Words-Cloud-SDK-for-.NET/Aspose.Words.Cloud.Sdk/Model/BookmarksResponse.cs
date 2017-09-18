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
  /// 
  /// </summary>  
  public class BookmarksResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets Bookmarks
        /// </summary>  
        public Bookmarks Bookmarks { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BookmarksResponse {\n");
          sb.Append("  Bookmarks: ").Append(this.Bookmarks).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
