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
  public class SearchResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// Gets or sets SearchingPattern
        /// </summary>    
        public string SearchingPattern { get; set; }

        /// <summary>
        /// Gets or sets SearchResults
        /// </summary>    
        public SearchResultsCollection SearchResults { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchResponse {\n");
          sb.Append("  SearchingPattern: ").Append(SearchingPattern).Append("\n");
          sb.Append("  SearchResults: ").Append(SearchResults).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
