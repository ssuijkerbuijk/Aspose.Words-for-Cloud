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
  public class XamlFixedSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets ResourcesFolder
        /// </summary>    
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Gets or sets ResourcesFolderAlias
        /// </summary>    
        public string ResourcesFolderAlias { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class XamlFixedSaveOptionsData {\n");
          sb.Append("  ResourcesFolder: ").Append(ResourcesFolder).Append("\n");
          sb.Append("  ResourcesFolderAlias: ").Append(ResourcesFolderAlias).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
