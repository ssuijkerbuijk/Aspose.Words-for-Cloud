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
  public class XamlFlowSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets ImagesFolder
        /// </summary>    
        public string ImagesFolder { get; set; }

        /// <summary>
        /// Gets or sets ImagesFolderAlias
        /// </summary>    
        public string ImagesFolderAlias { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class XamlFlowSaveOptionsData {\n");
          sb.Append("  ImagesFolder: ").Append(ImagesFolder).Append("\n");
          sb.Append("  ImagesFolderAlias: ").Append(ImagesFolderAlias).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
