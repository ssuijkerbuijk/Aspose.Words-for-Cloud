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
  public class SwfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Gets or sets AllowReadMode
        /// </summary>    
        public bool? AllowReadMode { get; set; }

        /// <summary>
        /// Gets or sets BookmarksOutlineLevel
        /// </summary>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets Compressed
        /// </summary>    
        public bool? Compressed { get; set; }

        /// <summary>
        /// Gets or sets EnableContextMenu
        /// </summary>    
        public bool? EnableContextMenu { get; set; }

        /// <summary>
        /// Gets or sets ExpandedOutlineLevels
        /// </summary>    
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets HeadingsOutlineLevels
        /// </summary>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Gets or sets LeftPaneControlFlags
        /// </summary>    
        public string LeftPaneControlFlags { get; set; }

        /// <summary>
        /// Gets or sets LogoImageBytes
        /// </summary>    
        public string LogoImageBytes { get; set; }

        /// <summary>
        /// Gets or sets LogoLink
        /// </summary>    
        public string LogoLink { get; set; }

        /// <summary>
        /// Gets or sets OutlineOptions
        /// </summary>    
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Gets or sets ShowBottomPane
        /// </summary>    
        public bool? ShowBottomPane { get; set; }

        /// <summary>
        /// Gets or sets ShowFullScreen
        /// </summary>    
        public bool? ShowFullScreen { get; set; }

        /// <summary>
        /// Gets or sets ShowLeftPane
        /// </summary>    
        public bool? ShowLeftPane { get; set; }

        /// <summary>
        /// Gets or sets ShowPageBorder
        /// </summary>    
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Gets or sets ShowPageStepper
        /// </summary>    
        public bool? ShowPageStepper { get; set; }

        /// <summary>
        /// Gets or sets ShowSearch
        /// </summary>    
        public bool? ShowSearch { get; set; }

        /// <summary>
        /// Gets or sets ShowTopPane
        /// </summary>    
        public bool? ShowTopPane { get; set; }

        /// <summary>
        /// Gets or sets StartOpenLeftPane
        /// </summary>    
        public bool? StartOpenLeftPane { get; set; }

        /// <summary>
        /// Gets or sets ToolTipsFontName
        /// </summary>    
        public string ToolTipsFontName { get; set; }

        /// <summary>
        /// Gets or sets TopPaneControlFlags
        /// </summary>    
        public string TopPaneControlFlags { get; set; }

        /// <summary>
        /// Gets or sets ViewerIncluded
        /// </summary>    
        public bool? ViewerIncluded { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SwfSaveOptionsData {\n");
          sb.Append("  AllowReadMode: ").Append(AllowReadMode).Append("\n");
          sb.Append("  BookmarksOutlineLevel: ").Append(BookmarksOutlineLevel).Append("\n");
          sb.Append("  Compressed: ").Append(Compressed).Append("\n");
          sb.Append("  EnableContextMenu: ").Append(EnableContextMenu).Append("\n");
          sb.Append("  ExpandedOutlineLevels: ").Append(ExpandedOutlineLevels).Append("\n");
          sb.Append("  HeadingsOutlineLevels: ").Append(HeadingsOutlineLevels).Append("\n");
          sb.Append("  LeftPaneControlFlags: ").Append(LeftPaneControlFlags).Append("\n");
          sb.Append("  LogoImageBytes: ").Append(LogoImageBytes).Append("\n");
          sb.Append("  LogoLink: ").Append(LogoLink).Append("\n");
          sb.Append("  OutlineOptions: ").Append(OutlineOptions).Append("\n");
          sb.Append("  ShowBottomPane: ").Append(ShowBottomPane).Append("\n");
          sb.Append("  ShowFullScreen: ").Append(ShowFullScreen).Append("\n");
          sb.Append("  ShowLeftPane: ").Append(ShowLeftPane).Append("\n");
          sb.Append("  ShowPageBorder: ").Append(ShowPageBorder).Append("\n");
          sb.Append("  ShowPageStepper: ").Append(ShowPageStepper).Append("\n");
          sb.Append("  ShowSearch: ").Append(ShowSearch).Append("\n");
          sb.Append("  ShowTopPane: ").Append(ShowTopPane).Append("\n");
          sb.Append("  StartOpenLeftPane: ").Append(StartOpenLeftPane).Append("\n");
          sb.Append("  ToolTipsFontName: ").Append(ToolTipsFontName).Append("\n");
          sb.Append("  TopPaneControlFlags: ").Append(TopPaneControlFlags).Append("\n");
          sb.Append("  ViewerIncluded: ").Append(ViewerIncluded).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
