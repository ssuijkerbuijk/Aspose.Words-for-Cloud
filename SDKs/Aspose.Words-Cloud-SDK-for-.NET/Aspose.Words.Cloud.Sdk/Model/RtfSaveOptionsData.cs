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
  /// container class for rtf save options
  /// </summary>  
  public class RtfSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies whether or not use pretty formats output
        /// </summary>  
        public bool? PrettyFormat { get; set; }

        /// <summary>
        /// Allows to make output RTF documents smaller in size, but if they contain RTL (right-to-left) text, it will not be displayed correctly
        /// </summary>  
        public bool? ExportCompactSize { get; set; }

        /// <summary>
        /// Specifies whether the keywords for \"old readers\" are written to RTF or not
        /// </summary>  
        public bool? ExportImagesForOldReaders { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RtfSaveOptionsData {\n");
          sb.Append("  PrettyFormat: ").Append(this.PrettyFormat).Append("\n");
          sb.Append("  ExportCompactSize: ").Append(this.ExportCompactSize).Append("\n");
          sb.Append("  ExportImagesForOldReaders: ").Append(this.ExportImagesForOldReaders).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
