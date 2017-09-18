namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// container class for xaml fixed save options
  /// </summary>  
  public class XamlFixedSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Specifies the physical folder where resources (images and fonts) are saved when exporting a document to fixed page Xaml format.  Default is null.
        /// </summary>  
        public string ResourcesFolder { get; set; }

        /// <summary>
        /// Specifies the name of the folder used to construct image URIs written into an fixed page Xaml document.  Default is null.
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
          sb.Append("  ResourcesFolder: ").Append(this.ResourcesFolder).Append("\n");
          sb.Append("  ResourcesFolderAlias: ").Append(this.ResourcesFolderAlias).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
