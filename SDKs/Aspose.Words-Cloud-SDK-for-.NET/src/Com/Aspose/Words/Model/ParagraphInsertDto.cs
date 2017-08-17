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
  public class ParagraphInsertDto 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphInsertDto" /> class.
        /// </summary>
        /// <param name="Text">Text.</param>
        public ParagraphInsertDto(string Text = default(string))
        {
                        this.Text = Text;
        }

        /// <summary>
        /// Gets or sets Text
        /// </summary>    
        public string Text { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ParagraphInsertDto {\n");
          sb.Append("  Text: ").Append(Text).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
