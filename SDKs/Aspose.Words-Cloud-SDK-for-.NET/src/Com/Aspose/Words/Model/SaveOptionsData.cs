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
  /// base container class for save options data
  /// </summary>  
  public class SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets a value determining how colors are rendered.  { Normal | Grayscale}
        /// </summary>
        /// <value>Gets or sets a value determining how colors are rendered.  { Normal | Grayscale}</value>    
        public string ColorMode { get; set; }

        /// <summary>
        /// format of save
        /// </summary>
        /// <value>format of save</value>    
        public string SaveFormat { get; set; }

        /// <summary>
        /// name of destination file
        /// </summary>
        /// <value>name of destination file</value>    
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets a value determining how DrawingML shapes are rendered.  { Fallback | DrawingML }
        /// </summary>
        /// <value>Gets or sets a value determining how DrawingML shapes are rendered.  { Fallback | DrawingML }</value>    
        public string DmlRenderingMode { get; set; }

        /// <summary>
        /// Gets or sets a value determining how DrawingML effects are rendered.  { Simplified | None | Fine }
        /// </summary>
        /// <value>Gets or sets a value determining how DrawingML effects are rendered.  { Simplified | None | Fine }</value>    
        public string DmlEffectsRenderingMode { get; set; }

        /// <summary>
        /// Controls zip output or not.  Default value is false.
        /// </summary>
        /// <value>Controls zip output or not.  Default value is false.</value>    
        public bool? ZipOutput { get; set; }

        /// <summary>
        /// Gets or sets value determining whether content of {Aspose.Words.Markup.StructuredDocumentTag} is updated before saving.
        /// </summary>
        /// <value>Gets or sets value determining whether content of {Aspose.Words.Markup.StructuredDocumentTag} is updated before saving.</value>    
        public bool? UpdateSdtContent { get; set; }

        /// <summary>
        /// Gets or sets a value determining if fields should be updated before saving the document to a fixed page format.  Default value for this property is <b>true</b>
        /// </summary>
        /// <value>Gets or sets a value determining if fields should be updated before saving the document to a fixed page format.  Default value for this property is <b>true</b></value>    
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
