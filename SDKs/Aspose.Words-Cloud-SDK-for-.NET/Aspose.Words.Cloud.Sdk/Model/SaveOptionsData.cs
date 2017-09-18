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
  /// base container class for save options data
  /// </summary>  
  public class SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets a value determining how colors are rendered.  { Normal | Grayscale}
        /// </summary>  
        public string ColorMode { get; set; }

        /// <summary>
        /// format of save
        /// </summary>  
        public string SaveFormat { get; set; }

        /// <summary>
        /// name of destination file
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value determining how DrawingML shapes are rendered.  { Fallback | DrawingML }
        /// </summary>  
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining how DrawingML effects are rendered.  { Simplified | None | Fine }
        /// </summary>  
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Controls zip output or not.  Default value is false.
        /// </summary>  
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Gets or sets value determining whether content of {Aspose.Words.Markup.StructuredDocumentTag} is updated before saving.
        /// </summary>  
        public bool? UpdateSdtContent { get; set; }

        /// <summary>
        /// Gets or sets a value determining if fields should be updated before saving the document to a fixed page format.  Default value for this property is <b>true</b>
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
          sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
          sb.Append("  SaveFormat: ").Append(this.SaveFormat).Append("\n");
          sb.Append("  FileName: ").Append(this.FileName).Append("\n");
          sb.Append("  DmlRenderingMode: ").Append(this.DmlRenderingMode).Append("\n");
          sb.Append("  DmlEffectsRenderingMode: ").Append(this.DmlEffectsRenderingMode).Append("\n");
          sb.Append("  ZipOutput: ").Append(this.ZipOutput).Append("\n");
          sb.Append("  UpdateSdtContent: ").Append(this.UpdateSdtContent).Append("\n");
          sb.Append("  UpdateFields: ").Append(this.UpdateFields).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
