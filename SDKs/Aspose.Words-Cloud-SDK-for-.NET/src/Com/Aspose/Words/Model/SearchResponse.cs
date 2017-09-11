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
  /// This resonse should be returned by the service when handling:  GET http://api.aspose.com/v1.1/words/Test.doc/search
  /// </summary>  
  public class SearchResponse : SaaSposeResponse 
  {                       
        /// <summary>
        /// A regular expression pattern used to find matches.
        /// </summary>
        /// <value>A regular expression pattern used to find matches.</value>    
        public string SearchingPattern { get; set; }

        /// <summary>
        /// Collection of search results.
        /// </summary>
        /// <value>Collection of search results.</value>    
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
