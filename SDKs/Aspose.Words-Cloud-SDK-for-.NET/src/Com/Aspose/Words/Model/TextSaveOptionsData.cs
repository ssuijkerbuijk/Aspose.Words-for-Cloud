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
  /// Container class for text save options.
  /// </summary>  
  public class TextSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the encoding to use when exporting in plain text format
        /// </summary>
        /// <value>Specifies the encoding to use when exporting in plain text format</value>    
        public string Encoding { get; set; }

        /// <summary>
        /// Specifies whether to output headers and footers when exporting in plain text format
        /// </summary>
        /// <value>Specifies whether to output headers and footers when exporting in plain text format</value>    
        public bool? ExportHeadersFooters { get; set; }

        /// <summary>
        /// Allows to specify whether the page breaks should be preserved during export.  The default value is false.
        /// </summary>
        /// <value>Allows to specify whether the page breaks should be preserved during export.  The default value is false.</value>    
        public bool? ForcePageBreaks { get; set; }

        /// <summary>
        /// Specifies the string to use as a paragraph break when exporting in plain text format
        /// </summary>
        /// <value>Specifies the string to use as a paragraph break when exporting in plain text format</value>    
        public string ParagraphBreak { get; set; }

        /// <summary>
        /// Specifies whether the program should attempt to preserve layout of tables when saving in the plain text format
        /// </summary>
        /// <value>Specifies whether the program should attempt to preserve layout of tables when saving in the plain text format</value>    
        public bool? PreserveTableLayout { get; set; }

        /// <summary>
        /// Specifies whether the program should simplify list labels in case of complex label formatting not being adequately represented by plain text
        /// </summary>
        /// <value>Specifies whether the program should simplify list labels in case of complex label formatting not being adequately represented by plain text</value>    
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
