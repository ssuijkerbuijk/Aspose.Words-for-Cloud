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
  public class OfficeMathObjectDto {
    
    /// <summary>
    /// Gets or Sets Content
    /// </summary>    
    public StoryChildNodes Content { get; set; }

    
    /// <summary>
    /// Gets or Sets DisplayType
    /// </summary>    
    public string DisplayType { get; set; }

    
    /// <summary>
    /// Gets or Sets Justification
    /// </summary>    
    public string Justification { get; set; }

    
    /// <summary>
    /// Gets or Sets MathObjectType
    /// </summary>    
    public string MathObjectType { get; set; }

    
    /// <summary>
    /// Gets or Sets NodeId
    /// </summary>    
    public string NodeId { get; set; }

    
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
      sb.Append("class OfficeMathObjectDto {\n");
      
      sb.Append("  Content: ").Append(Content).Append("\n");
      
      sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
      
      sb.Append("  Justification: ").Append(Justification).Append("\n");
      
      sb.Append("  MathObjectType: ").Append(MathObjectType).Append("\n");
      
      sb.Append("  NodeId: ").Append(NodeId).Append("\n");
      
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
