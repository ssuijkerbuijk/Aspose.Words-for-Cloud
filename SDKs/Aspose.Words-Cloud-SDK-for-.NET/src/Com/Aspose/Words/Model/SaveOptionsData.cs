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
  public class SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets ColorMode
        /// </summary>    
        public string ColorMode { get; set; }

        /// <summary>
        /// Gets or sets SaveFormat
        /// </summary>    
        public string SaveFormat { get; set; }

        /// <summary>
        /// Gets or sets FileName
        /// </summary>    
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets DmlRenderingMode
        /// </summary>    
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets DmlEffectsRenderingMode
        /// </summary>    
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets ZipOutput
        /// </summary>    
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Gets or sets UpdateSdtContent
        /// </summary>    
        public bool? UpdateSdtContent { get; set; }

        /// <summary>
        /// Gets or sets UpdateFields
        /// </summary>    
        public bool? UpdateFields { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SaveOptionsData {\n");
          sb.Append("  ColorMode: ").Append(ColorMode).Append("\n");
          sb.Append("  SaveFormat: ").Append(SaveFormat).Append("\n");
          sb.Append("  FileName: ").Append(FileName).Append("\n");
          sb.Append("  DmlRenderingMode: ").Append(DmlRenderingMode).Append("\n");
          sb.Append("  DmlEffectsRenderingMode: ").Append(DmlEffectsRenderingMode).Append("\n");
          sb.Append("  ZipOutput: ").Append(ZipOutput).Append("\n");
          sb.Append("  UpdateSdtContent: ").Append(UpdateSdtContent).Append("\n");
          sb.Append("  UpdateFields: ").Append(UpdateFields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
