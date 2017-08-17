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
  public class FieldNames 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldNames" /> class.
        /// </summary>
        /// <param name="Names">Names.</param>
        /// <param name="Link">Link.</param>
        public FieldNames(List<string> Names = default(List<string>), WordsApiLink Link = default(WordsApiLink))
        {
                        this.Names = Names;
                        this.Link = Link;
        }

        /// <summary>
        /// Gets or sets Names
        /// </summary>    
        public List<string> Names { get; set; }

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
          sb.Append("class FieldNames {\n");
          sb.Append("  Names: ").Append(Names).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
