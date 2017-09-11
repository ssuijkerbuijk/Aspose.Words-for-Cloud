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
  /// container class for swf save options
  /// </summary>  
  public class SwfSaveOptionsData : FixedPageSaveOptionsData 
  {                       
        /// <summary>
        /// Allows to enable read mode
        /// </summary>
        /// <value>Allows to enable read mode</value>    
        public bool? AllowReadMode { get; set; }

        /// <summary>
        /// Specifies the level in the SWF document outline at which to display Word bookmarks
        /// </summary>
        /// <value>Specifies the level in the SWF document outline at which to display Word bookmarks</value>    
        public int? BookmarksOutlineLevel { get; set; }

        /// <summary>
        /// Specifies whether the generated SWF document should be compressed or not
        /// </summary>
        /// <value>Specifies whether the generated SWF document should be compressed or not</value>    
        public bool? Compressed { get; set; }

        /// <summary>
        /// Enable/disable context menu
        /// </summary>
        /// <value>Enable/disable context menu</value>    
        public bool? EnableContextMenu { get; set; }

        /// <summary>
        /// Specifies how many levels in the SWF document outline to show expanded when the SWF file is viewed
        /// </summary>
        /// <value>Specifies how many levels in the SWF document outline to show expanded when the SWF file is viewed</value>    
        public int? ExpandedOutlineLevels { get; set; }

        /// <summary>
        /// Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the SWF document outline
        /// </summary>
        /// <value>Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the SWF document outline</value>    
        public int? HeadingsOutlineLevels { get; set; }

        /// <summary>
        /// Control flags used to configure appearance of left panel of SWF viewer
        /// </summary>
        /// <value>Control flags used to configure appearance of left panel of SWF viewer</value>    
        public string LeftPaneControlFlags { get; set; }

        /// <summary>
        /// Image that will be displayed as logo in the top right corner of the viewer as string in base64 format
        /// </summary>
        /// <value>Image that will be displayed as logo in the top right corner of the viewer as string in base64 format</value>    
        public string LogoImageBytes { get; set; }

        /// <summary>
        /// Specifies the full hyperlink address for a logo
        /// </summary>
        /// <value>Specifies the full hyperlink address for a logo</value>    
        public string LogoLink { get; set; }

        /// <summary>
        /// Allows to specify outline options
        /// </summary>
        /// <value>Allows to specify outline options</value>    
        public OutlineOptionsData OutlineOptions { get; set; }

        /// <summary>
        /// Show/hide bottom pane
        /// </summary>
        /// <value>Show/hide bottom pane</value>    
        public bool? ShowBottomPane { get; set; }

        /// <summary>
        /// Show/hide fullscreen button
        /// </summary>
        /// <value>Show/hide fullscreen button</value>    
        public bool? ShowFullScreen { get; set; }

        /// <summary>
        /// Show/hide left pane
        /// </summary>
        /// <value>Show/hide left pane</value>    
        public bool? ShowLeftPane { get; set; }

        /// <summary>
        /// Specifies whether border around pages should be shown
        /// </summary>
        /// <value>Specifies whether border around pages should be shown</value>    
        public bool? ShowPageBorder { get; set; }

        /// <summary>
        /// Show/hide page stepper
        /// </summary>
        /// <value>Show/hide page stepper</value>    
        public bool? ShowPageStepper { get; set; }

        /// <summary>
        /// Show/hide search section
        /// </summary>
        /// <value>Show/hide search section</value>    
        public bool? ShowSearch { get; set; }

        /// <summary>
        /// Show/hide whole top pane
        /// </summary>
        /// <value>Show/hide whole top pane</value>    
        public bool? ShowTopPane { get; set; }

        /// <summary>
        /// Start with opened left pane
        /// </summary>
        /// <value>Start with opened left pane</value>    
        public bool? StartOpenLeftPane { get; set; }

        /// <summary>
        /// Specifies a font used for tooltips in SWF viewer
        /// </summary>
        /// <value>Specifies a font used for tooltips in SWF viewer</value>    
        public string ToolTipsFontName { get; set; }

        /// <summary>
        /// Control flags used to configure appearance of top panel of SWF viewer
        /// </summary>
        /// <value>Control flags used to configure appearance of top panel of SWF viewer</value>    
        public string TopPaneControlFlags { get; set; }

        /// <summary>
        /// Specifies whether the generated SWF document should include the integrated document viewer or not
        /// </summary>
        /// <value>Specifies whether the generated SWF document should include the integrated document viewer or not</value>    
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
