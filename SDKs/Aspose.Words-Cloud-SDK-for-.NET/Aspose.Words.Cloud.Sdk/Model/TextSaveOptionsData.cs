namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Container class for text save options.
  /// </summary>  
  public class TextSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the encoding to use when exporting in plain text format
        /// </summary>  
        public string Encoding { get; set; }

        /// <summary>
        /// Specifies whether to output headers and footers when exporting in plain text format
        /// </summary>  
        public bool? ExportHeadersFooters { get; set; }

        /// <summary>
        /// Allows to specify whether the page breaks should be preserved during export.  The default value is false.
        /// </summary>  
        public bool? ForcePageBreaks { get; set; }

        /// <summary>
        /// Specifies the string to use as a paragraph break when exporting in plain text format
        /// </summary>  
        public string ParagraphBreak { get; set; }

        /// <summary>
        /// Specifies whether the program should attempt to preserve layout of tables when saving in the plain text format
        /// </summary>  
        public bool? PreserveTableLayout { get; set; }

        /// <summary>
        /// Specifies whether the program should simplify list labels in case of complex label formatting not being adequately represented by plain text
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
          sb.Append("  Encoding: ").Append(this.Encoding).Append("\n");
          sb.Append("  ExportHeadersFooters: ").Append(this.ExportHeadersFooters).Append("\n");
          sb.Append("  ForcePageBreaks: ").Append(this.ForcePageBreaks).Append("\n");
          sb.Append("  ParagraphBreak: ").Append(this.ParagraphBreak).Append("\n");
          sb.Append("  PreserveTableLayout: ").Append(this.PreserveTableLayout).Append("\n");
          sb.Append("  SimplifyListLabels: ").Append(this.SimplifyListLabels).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
