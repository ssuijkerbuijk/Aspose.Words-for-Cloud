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
  public class TextSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets Encoding
        /// </summary>    
        public string Encoding { get; set; }

        /// <summary>
        /// Gets or sets ExportHeadersFooters
        /// </summary>    
        public bool? ExportHeadersFooters { get; set; }

        /// <summary>
        /// Gets or sets ForcePageBreaks
        /// </summary>    
        public bool? ForcePageBreaks { get; set; }

        /// <summary>
        /// Gets or sets ParagraphBreak
        /// </summary>    
        public string ParagraphBreak { get; set; }

        /// <summary>
        /// Gets or sets PreserveTableLayout
        /// </summary>    
        public bool? PreserveTableLayout { get; set; }

        /// <summary>
        /// Gets or sets SimplifyListLabels
        /// </summary>    
        public bool? SimplifyListLabels { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TextSaveOptionsData {\n");
          sb.Append("  Encoding: ").Append(Encoding).Append("\n");
          sb.Append("  ExportHeadersFooters: ").Append(ExportHeadersFooters).Append("\n");
          sb.Append("  ForcePageBreaks: ").Append(ForcePageBreaks).Append("\n");
          sb.Append("  ParagraphBreak: ").Append(ParagraphBreak).Append("\n");
          sb.Append("  PreserveTableLayout: ").Append(PreserveTableLayout).Append("\n");
          sb.Append("  SimplifyListLabels: ").Append(SimplifyListLabels).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
