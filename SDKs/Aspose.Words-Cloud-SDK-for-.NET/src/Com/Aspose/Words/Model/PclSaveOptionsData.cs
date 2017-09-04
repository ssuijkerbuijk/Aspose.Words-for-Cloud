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
  public class PclSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets FalllbackFontName
        /// </summary>    
        public string FalllbackFontName { get; set; }

        /// <summary>
        /// Gets or sets RasterizeTransformedElements
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
          sb.Append("  FalllbackFontName: ").Append(FalllbackFontName).Append("\n");
          sb.Append("  RasterizeTransformedElements: ").Append(RasterizeTransformedElements).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
