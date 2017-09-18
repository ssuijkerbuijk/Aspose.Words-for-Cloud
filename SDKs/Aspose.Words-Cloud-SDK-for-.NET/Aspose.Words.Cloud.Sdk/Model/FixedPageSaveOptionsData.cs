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
  /// Contains common options that can be specified when saving a document into fixed page formats (PDF, XPS, SWF, images etc).
  /// </summary>  
  public class FixedPageSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Determines the quality of the JPEG images inside PDF document.
        /// </summary>  
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Allows to specify metafile rendering options.
        /// </summary>  
        public MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

        /// <summary>
        /// Indicates the symbol set that is used to represent numbers while rendering to fixed page formats
        /// </summary>  
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Flag indicates whether it is required to optimize output of XPS.   If this flag is set redundant nested canvases and empty canvases are removed, also neighbor glyphs with the same formatting are concatenated.   Note: The accuracy of the content display may be affected if this property is set to true.  Default is false.
        /// </summary>  
        public bool? OptimizeOutput { get; set; }

        /// <summary>
        /// Determines number of pages to render
        /// </summary>  
        public int? PageCount { get; set; }

        /// <summary>
        /// Determines 0-based index of the first page to render
        /// </summary>  
        public int? PageIndex { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FixedPageSaveOptionsData {\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  MetafileRenderingOptions: ").Append(this.MetafileRenderingOptions).Append("\n");
          sb.Append("  NumeralFormat: ").Append(this.NumeralFormat).Append("\n");
          sb.Append("  OptimizeOutput: ").Append(this.OptimizeOutput).Append("\n");
          sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
          sb.Append("  PageIndex: ").Append(this.PageIndex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
