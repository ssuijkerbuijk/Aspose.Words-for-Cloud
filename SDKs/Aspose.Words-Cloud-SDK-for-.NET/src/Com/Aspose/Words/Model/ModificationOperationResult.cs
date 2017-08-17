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
  public class ModificationOperationResult 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="ModificationOperationResult" /> class.
        /// </summary>
        /// <param name="Source">Source.</param>
        /// <param name="Dest">Dest.</param>
        public ModificationOperationResult(FileLink Source = default(FileLink), FileLink Dest = default(FileLink))
        {
                        this.Source = Source;
                        this.Dest = Dest;
        }

        /// <summary>
        /// Gets or sets Source
        /// </summary>    
        public FileLink Source { get; set; }

        /// <summary>
        /// Gets or sets Dest
        /// </summary>    
        public FileLink Dest { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ModificationOperationResult {\n");
          sb.Append("  Source: ").Append(Source).Append("\n");
          sb.Append("  Dest: ").Append(Dest).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
