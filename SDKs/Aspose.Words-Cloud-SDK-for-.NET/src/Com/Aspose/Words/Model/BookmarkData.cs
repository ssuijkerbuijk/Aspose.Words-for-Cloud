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
  public class BookmarkData {
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>    
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Text
    /// </summary>    
    public string Text { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BookmarkData {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Text: ").Append(Text).Append("\n");
      
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
