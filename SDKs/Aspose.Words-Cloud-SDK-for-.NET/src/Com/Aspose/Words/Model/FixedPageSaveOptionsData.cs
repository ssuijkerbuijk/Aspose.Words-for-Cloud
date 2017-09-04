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
  public class FixedPageSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets JpegQuality
        /// </summary>    
        public int? JpegQuality { get; set; }

        /// <summary>
        /// Gets or sets MetafileRenderingOptions
        /// </summary>    
        public MetafileRenderingOptionsData MetafileRenderingOptions { get; set; }

        /// <summary>
        /// Gets or sets NumeralFormat
        /// </summary>    
        public string NumeralFormat { get; set; }

        /// <summary>
        /// Gets or sets OptimizeOutput
        /// </summary>    
        public bool? OptimizeOutput { get; set; }

        /// <summary>
        /// Gets or sets PageCount
        /// </summary>    
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or sets PageIndex
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
          sb.Append("  JpegQuality: ").Append(JpegQuality).Append("\n");
          sb.Append("  MetafileRenderingOptions: ").Append(MetafileRenderingOptions).Append("\n");
          sb.Append("  NumeralFormat: ").Append(NumeralFormat).Append("\n");
          sb.Append("  OptimizeOutput: ").Append(OptimizeOutput).Append("\n");
          sb.Append("  PageCount: ").Append(PageCount).Append("\n");
          sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
