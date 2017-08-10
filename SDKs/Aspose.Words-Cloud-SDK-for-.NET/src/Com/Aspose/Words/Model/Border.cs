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
  public class Border {
    
    /// <summary>
    /// Gets or Sets BorderType
    /// </summary>    
    public string BorderType { get; set; }

    
    /// <summary>
    /// Gets or Sets Color
    /// </summary>    
    public XmlColor Color { get; set; }

    
    /// <summary>
    /// Gets or Sets DistanceFromText
    /// </summary>    
    public double? DistanceFromText { get; set; }

    
    /// <summary>
    /// Gets or Sets LineStyle
    /// </summary>    
    public string LineStyle { get; set; }

    
    /// <summary>
    /// Gets or Sets LineWidth
    /// </summary>    
    public double? LineWidth { get; set; }

    
    /// <summary>
    /// Gets or Sets Shadow
    /// </summary>    
    public bool? Shadow { get; set; }

    
    /// <summary>
    /// Gets or Sets Link
    /// </summary>    
    public WordsApiLink Link { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Border {\n");
      
      sb.Append("  BorderType: ").Append(BorderType).Append("\n");
      
      sb.Append("  Color: ").Append(Color).Append("\n");
      
      sb.Append("  DistanceFromText: ").Append(DistanceFromText).Append("\n");
      
      sb.Append("  LineStyle: ").Append(LineStyle).Append("\n");
      
      sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
      
      sb.Append("  Shadow: ").Append(Shadow).Append("\n");
      
      sb.Append("  Link: ").Append(Link).Append("\n");
      
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
