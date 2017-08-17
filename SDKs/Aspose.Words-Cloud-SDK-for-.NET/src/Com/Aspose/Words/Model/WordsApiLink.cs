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
  public class WordsApiLink 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="WordsApiLink" /> class.
        /// </summary>
        /// <param name="Href">Href.</param>
        /// <param name="Rel">Rel.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Title">Title.</param>
        public WordsApiLink(string Href = default(string), string Rel = default(string), string Type = default(string), string Title = default(string))
        {
                        this.Href = Href;
                        this.Rel = Rel;
                        this.Type = Type;
                        this.Title = Title;
        }

        /// <summary>
        /// Gets or sets Href
        /// </summary>    
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets Rel
        /// </summary>    
        public string Rel { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>    
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Title
        /// </summary>    
        public string Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WordsApiLink {\n");
          sb.Append("  Href: ").Append(Href).Append("\n");
          sb.Append("  Rel: ").Append(Rel).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Title: ").Append(Title).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
