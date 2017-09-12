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
  /// container class for xaml flow save options
  /// </summary>  
  public class XamlFlowSaveOptionsData : SaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the physical folder where images are saved when exporting
        /// </summary>  
        public string ImagesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct image URIs
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
          sb.Append("  ImagesFolder: ").Append(this.ImagesFolder).Append("\n");
          sb.Append("  ImagesFolderAlias: ").Append(this.ImagesFolderAlias).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
