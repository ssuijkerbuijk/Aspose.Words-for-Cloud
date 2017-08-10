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
  public class DrawingObjectDto {
    
    /// <summary>
    /// Gets or Sets RenderLinks
    /// </summary>    
    public List<WordsApiLink> RenderLinks { get; set; }

    
    /// <summary>
    /// Gets or Sets Width
    /// </summary>    
    public double? Width { get; set; }

    
    /// <summary>
    /// Gets or Sets Height
    /// </summary>    
    public double? Height { get; set; }

    
    /// <summary>
    /// Gets or Sets OleDataLink
    /// </summary>    
    public WordsApiLink OleDataLink { get; set; }

    
    /// <summary>
    /// Gets or Sets ImageDataLink
    /// </summary>    
    public WordsApiLink ImageDataLink { get; set; }

    
    /// <summary>
    /// Gets or Sets RelativeHorizontalPosition
    /// </summary>    
    public string RelativeHorizontalPosition { get; set; }

    
    /// <summary>
    /// Gets or Sets Left
    /// </summary>    
    public double? Left { get; set; }

    
    /// <summary>
    /// Gets or Sets RelativeVerticalPosition
    /// </summary>    
    public string RelativeVerticalPosition { get; set; }

    
    /// <summary>
    /// Gets or Sets Top
    /// </summary>    
    public double? Top { get; set; }

    
    /// <summary>
    /// Gets or Sets WrapType
    /// </summary>    
    public string WrapType { get; set; }

    
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
      sb.Append("class DrawingObjectDto {\n");
      
      sb.Append("  RenderLinks: ").Append(RenderLinks).Append("\n");
      
      sb.Append("  Width: ").Append(Width).Append("\n");
      
      sb.Append("  Height: ").Append(Height).Append("\n");
      
      sb.Append("  OleDataLink: ").Append(OleDataLink).Append("\n");
      
      sb.Append("  ImageDataLink: ").Append(ImageDataLink).Append("\n");
      
      sb.Append("  RelativeHorizontalPosition: ").Append(RelativeHorizontalPosition).Append("\n");
      
      sb.Append("  Left: ").Append(Left).Append("\n");
      
      sb.Append("  RelativeVerticalPosition: ").Append(RelativeVerticalPosition).Append("\n");
      
      sb.Append("  Top: ").Append(Top).Append("\n");
      
      sb.Append("  WrapType: ").Append(WrapType).Append("\n");
      
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
