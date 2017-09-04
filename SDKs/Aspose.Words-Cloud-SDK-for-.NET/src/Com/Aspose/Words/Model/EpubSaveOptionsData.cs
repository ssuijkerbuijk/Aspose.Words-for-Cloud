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
  /// 
  /// </summary>  
  public class EpubSaveOptionsData : HtmlSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets EpubNavigationMapLevel
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
          sb.Append("  EpubNavigationMapLevel: ").Append(EpubNavigationMapLevel).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
