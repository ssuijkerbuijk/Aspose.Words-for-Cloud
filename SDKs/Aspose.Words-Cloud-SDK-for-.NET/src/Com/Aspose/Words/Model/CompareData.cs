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
  public class CompareData 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="CompareData" /> class.
        /// </summary>
        /// <param name="ComparingWithDocument">ComparingWithDocument.</param>
        /// <param name="Author">Author.</param>
        /// <param name="DateTime">DateTime.</param>
        public CompareData(string ComparingWithDocument = default(string), string Author = default(string), DateTime? DateTime = default(DateTime?))
        {
                        this.ComparingWithDocument = ComparingWithDocument;
                        this.Author = Author;
                        this.DateTime = DateTime;
        }

        /// <summary>
        /// Gets or sets ComparingWithDocument
        /// </summary>    
        public string ComparingWithDocument { get; set; }

        /// <summary>
        /// Gets or sets Author
        /// </summary>    
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets DateTime
        /// </summary>    
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CompareData {\n");
          sb.Append("  ComparingWithDocument: ").Append(ComparingWithDocument).Append("\n");
          sb.Append("  Author: ").Append(Author).Append("\n");
          sb.Append("  DateTime: ").Append(DateTime).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
