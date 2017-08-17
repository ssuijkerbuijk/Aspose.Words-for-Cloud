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
  public class SaveResult 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveResult" /> class.
        /// </summary>
        /// <param name="SourceDocument">SourceDocument.</param>
        /// <param name="DestDocument">DestDocument.</param>
        /// <param name="AdditionalItems">AdditionalItems.</param>
        public SaveResult(FileLink SourceDocument = default(FileLink), FileLink DestDocument = default(FileLink), List<FileLink> AdditionalItems = default(List<FileLink>))
        {
                        this.SourceDocument = SourceDocument;
                        this.DestDocument = DestDocument;
                        this.AdditionalItems = AdditionalItems;
        }

        /// <summary>
        /// Gets or sets SourceDocument
        /// </summary>    
        public FileLink SourceDocument { get; set; }

        /// <summary>
        /// Gets or sets DestDocument
        /// </summary>    
        public FileLink DestDocument { get; set; }

        /// <summary>
        /// Gets or sets AdditionalItems
        /// </summary>    
        public List<FileLink> AdditionalItems { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveResult {\n");
          sb.Append("  SourceDocument: ").Append(SourceDocument).Append("\n");
          sb.Append("  DestDocument: ").Append(DestDocument).Append("\n");
          sb.Append("  AdditionalItems: ").Append(AdditionalItems).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
