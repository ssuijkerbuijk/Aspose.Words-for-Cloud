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
  public class SearchResultsCollection 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultsCollection" /> class.
        /// </summary>
        /// <param name="ResultsList">ResultsList.</param>
        /// <param name="Link">Link.</param>
        public SearchResultsCollection(List<SearchResult> ResultsList = default(List<SearchResult>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.ResultsList = ResultsList;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets ResultsList
        /// </summary>    
        public List<SearchResult> ResultsList { get; set; }

        /// <summary>
        /// Gets or sets Link
        /// </summary>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SearchResultsCollection {\n");
          sb.Append("  ResultsList: ").Append(ResultsList).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
