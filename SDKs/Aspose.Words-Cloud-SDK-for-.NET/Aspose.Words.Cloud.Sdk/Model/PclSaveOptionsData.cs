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
  /// Container class for pcl save options
  /// </summary>  
  public class PclSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Name of the font that will be used if no expected font is found in printer and built-in fonts collections.
        /// </summary>  
        public string FalllbackFontName { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether or not complex transformed elements should be rasterized before saving to PCL document.  Default is true.
        /// </summary>  
        public bool? RasterizeTransformedElements { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PclSaveOptionsData {\n");
          sb.Append("  FalllbackFontName: ").Append(this.FalllbackFontName).Append("\n");
          sb.Append("  RasterizeTransformedElements: ").Append(this.RasterizeTransformedElements).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
