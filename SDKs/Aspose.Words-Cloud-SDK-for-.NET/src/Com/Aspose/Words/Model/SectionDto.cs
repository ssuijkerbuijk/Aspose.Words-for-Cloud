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
  public class SectionDto {
    
    /// <summary>
    /// Gets or Sets Paragraphs
    /// </summary>    
    public LinkElement Paragraphs { get; set; }

    
    /// <summary>
    /// Gets or Sets PageSetup
    /// </summary>    
    public LinkElement PageSetup { get; set; }

    
    /// <summary>
    /// Gets or Sets HeaderFooters
    /// </summary>    
    public LinkElement HeaderFooters { get; set; }

    
    /// <summary>
    /// Gets or Sets Tables
    /// </summary>    
    public LinkElement Tables { get; set; }

    
    /// <summary>
    /// Gets or Sets ChildNodes
    /// </summary>    
    public List<Object> ChildNodes { get; set; }

    
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
      sb.Append("class SectionDto {\n");
      
      sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
      
      sb.Append("  PageSetup: ").Append(PageSetup).Append("\n");
      
      sb.Append("  HeaderFooters: ").Append(HeaderFooters).Append("\n");
      
      sb.Append("  Tables: ").Append(Tables).Append("\n");
      
      sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
      
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
