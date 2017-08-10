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
  public class FileLink {
    
    /// <summary>
    /// Gets or Sets Href
    /// </summary>    
    public string Href { get; set; }

    
    /// <summary>
    /// Gets or Sets Rel
    /// </summary>    
    public string Rel { get; set; }

    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>    
    public string Type { get; set; }

    
    /// <summary>
    /// Gets or Sets Title
    /// </summary>    
    public string Title { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileLink {\n");
      
      sb.Append("  Href: ").Append(Href).Append("\n");
      
      sb.Append("  Rel: ").Append(Rel).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Title: ").Append(Title).Append("\n");
      
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
