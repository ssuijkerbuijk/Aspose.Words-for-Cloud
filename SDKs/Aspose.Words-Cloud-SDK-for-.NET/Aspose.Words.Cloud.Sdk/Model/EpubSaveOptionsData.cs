namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Container class for epub save options.
  /// </summary>  
  public class EpubSaveOptionsData : HtmlSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the maximum level of headings populated to the navigation map when exporting
        /// </summary>  
        public int? EpubNavigationMapLevel { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class EpubSaveOptionsData {\n");
          sb.Append("  EpubNavigationMapLevel: ").Append(this.EpubNavigationMapLevel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
