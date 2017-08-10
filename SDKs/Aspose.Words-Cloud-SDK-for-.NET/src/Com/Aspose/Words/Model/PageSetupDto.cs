using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace Com.Aspose.Words.Model {

  /// <summary>
  /// 
  /// </summary>  
  public class PageSetupDto {
    
    /// <summary>
    /// Gets or Sets Bidi
    /// </summary>    
    public bool? Bidi { get; set; }

    
    /// <summary>
    /// Gets or Sets BorderAlwaysInFront
    /// </summary>    
    public bool? BorderAlwaysInFront { get; set; }

    
    /// <summary>
    /// Gets or Sets BorderAppliesTo
    /// </summary>    
    public string BorderAppliesTo { get; set; }

    
    /// <summary>
    /// Gets or Sets BorderDistanceFrom
    /// </summary>    
    public string BorderDistanceFrom { get; set; }

    
    /// <summary>
    /// Gets or Sets BottomMargin
    /// </summary>    
    public double? BottomMargin { get; set; }

    
    /// <summary>
    /// Gets or Sets DifferentFirstPageHeaderFooter
    /// </summary>    
    public bool? DifferentFirstPageHeaderFooter { get; set; }

    
    /// <summary>
    /// Gets or Sets FirstPageTray
    /// </summary>    
    public int? FirstPageTray { get; set; }

    
    /// <summary>
    /// Gets or Sets FooterDistance
    /// </summary>    
    public double? FooterDistance { get; set; }

    
    /// <summary>
    /// Gets or Sets Gutter
    /// </summary>    
    public double? Gutter { get; set; }

    
    /// <summary>
    /// Gets or Sets HeaderDistance
    /// </summary>    
    public double? HeaderDistance { get; set; }

    
    /// <summary>
    /// Gets or Sets LeftMargin
    /// </summary>    
    public double? LeftMargin { get; set; }

    
    /// <summary>
    /// Gets or Sets LineNumberCountBy
    /// </summary>    
    public int? LineNumberCountBy { get; set; }

    
    /// <summary>
    /// Gets or Sets LineNumberDistanceFromText
    /// </summary>    
    public double? LineNumberDistanceFromText { get; set; }

    
    /// <summary>
    /// Gets or Sets LineNumberRestartMode
    /// </summary>    
    public string LineNumberRestartMode { get; set; }

    
    /// <summary>
    /// Gets or Sets LineStartingNumber
    /// </summary>    
    public int? LineStartingNumber { get; set; }

    
    /// <summary>
    /// Gets or Sets Orientation
    /// </summary>    
    public string Orientation { get; set; }

    
    /// <summary>
    /// Gets or Sets OtherPagesTray
    /// </summary>    
    public int? OtherPagesTray { get; set; }

    
    /// <summary>
    /// Gets or Sets PageHeight
    /// </summary>    
    public double? PageHeight { get; set; }

    
    /// <summary>
    /// Gets or Sets PageNumberStyle
    /// </summary>    
    public string PageNumberStyle { get; set; }

    
    /// <summary>
    /// Gets or Sets PageStartingNumber
    /// </summary>    
    public int? PageStartingNumber { get; set; }

    
    /// <summary>
    /// Gets or Sets PageWidth
    /// </summary>    
    public double? PageWidth { get; set; }

    
    /// <summary>
    /// Gets or Sets PaperSize
    /// </summary>    
    public string PaperSize { get; set; }

    
    /// <summary>
    /// Gets or Sets RestartPageNumbering
    /// </summary>    
    public bool? RestartPageNumbering { get; set; }

    
    /// <summary>
    /// Gets or Sets RightMargin
    /// </summary>    
    public double? RightMargin { get; set; }

    
    /// <summary>
    /// Gets or Sets RtlGutter
    /// </summary>    
    public bool? RtlGutter { get; set; }

    
    /// <summary>
    /// Gets or Sets SectionStart
    /// </summary>    
    public string SectionStart { get; set; }

    
    /// <summary>
    /// Gets or Sets SuppressEndnotes
    /// </summary>    
    public bool? SuppressEndnotes { get; set; }

    
    /// <summary>
    /// Gets or Sets TopMargin
    /// </summary>    
    public double? TopMargin { get; set; }

    
    /// <summary>
    /// Gets or Sets VerticalAlignment
    /// </summary>    
    public string VerticalAlignment { get; set; }

    
    /// <summary>
    /// Gets or Sets Link
    /// </summary>    
    public WordsApiLink Link { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageSetupDto {\n");
      
      sb.Append("  Bidi: ").Append(Bidi).Append("\n");
      
      sb.Append("  BorderAlwaysInFront: ").Append(BorderAlwaysInFront).Append("\n");
      
      sb.Append("  BorderAppliesTo: ").Append(BorderAppliesTo).Append("\n");
      
      sb.Append("  BorderDistanceFrom: ").Append(BorderDistanceFrom).Append("\n");
      
      sb.Append("  BottomMargin: ").Append(BottomMargin).Append("\n");
      
      sb.Append("  DifferentFirstPageHeaderFooter: ").Append(DifferentFirstPageHeaderFooter).Append("\n");
      
      sb.Append("  FirstPageTray: ").Append(FirstPageTray).Append("\n");
      
      sb.Append("  FooterDistance: ").Append(FooterDistance).Append("\n");
      
      sb.Append("  Gutter: ").Append(Gutter).Append("\n");
      
      sb.Append("  HeaderDistance: ").Append(HeaderDistance).Append("\n");
      
      sb.Append("  LeftMargin: ").Append(LeftMargin).Append("\n");
      
      sb.Append("  LineNumberCountBy: ").Append(LineNumberCountBy).Append("\n");
      
      sb.Append("  LineNumberDistanceFromText: ").Append(LineNumberDistanceFromText).Append("\n");
      
      sb.Append("  LineNumberRestartMode: ").Append(LineNumberRestartMode).Append("\n");
      
      sb.Append("  LineStartingNumber: ").Append(LineStartingNumber).Append("\n");
      
      sb.Append("  Orientation: ").Append(Orientation).Append("\n");
      
      sb.Append("  OtherPagesTray: ").Append(OtherPagesTray).Append("\n");
      
      sb.Append("  PageHeight: ").Append(PageHeight).Append("\n");
      
      sb.Append("  PageNumberStyle: ").Append(PageNumberStyle).Append("\n");
      
      sb.Append("  PageStartingNumber: ").Append(PageStartingNumber).Append("\n");
      
      sb.Append("  PageWidth: ").Append(PageWidth).Append("\n");
      
      sb.Append("  PaperSize: ").Append(PaperSize).Append("\n");
      
      sb.Append("  RestartPageNumbering: ").Append(RestartPageNumbering).Append("\n");
      
      sb.Append("  RightMargin: ").Append(RightMargin).Append("\n");
      
      sb.Append("  RtlGutter: ").Append(RtlGutter).Append("\n");
      
      sb.Append("  SectionStart: ").Append(SectionStart).Append("\n");
      
      sb.Append("  SuppressEndnotes: ").Append(SuppressEndnotes).Append("\n");
      
      sb.Append("  TopMargin: ").Append(TopMargin).Append("\n");
      
      sb.Append("  VerticalAlignment: ").Append(VerticalAlignment).Append("\n");
      
      sb.Append("  Link: ").Append(Link).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}


}
