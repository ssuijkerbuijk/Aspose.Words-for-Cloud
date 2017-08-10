using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace Com.Aspose.Words.Model {

  /// <summary>
  /// 
  /// </summary>  
  public class GraphicsQualityOptionsData {
    
    /// <summary>
    /// Gets or Sets CompositingMode
    /// </summary>    
    public string CompositingMode { get; set; }

    
    /// <summary>
    /// Gets or Sets CompositingQuality
    /// </summary>    
    public string CompositingQuality { get; set; }

    
    /// <summary>
    /// Gets or Sets InterpolationMode
    /// </summary>    
    public string InterpolationMode { get; set; }

    
    /// <summary>
    /// Gets or Sets SmoothingMode
    /// </summary>    
    public string SmoothingMode { get; set; }

    
    /// <summary>
    /// Gets or Sets StringFormat
    /// </summary>    
    public StringFormatData StringFormat { get; set; }

    
    /// <summary>
    /// Gets or Sets TextRenderingHint
    /// </summary>    
    public string TextRenderingHint { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GraphicsQualityOptionsData {\n");
      
      sb.Append("  CompositingMode: ").Append(CompositingMode).Append("\n");
      
      sb.Append("  CompositingQuality: ").Append(CompositingQuality).Append("\n");
      
      sb.Append("  InterpolationMode: ").Append(InterpolationMode).Append("\n");
      
      sb.Append("  SmoothingMode: ").Append(SmoothingMode).Append("\n");
      
      sb.Append("  StringFormat: ").Append(StringFormat).Append("\n");
      
      sb.Append("  TextRenderingHint: ").Append(TextRenderingHint).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}


}
