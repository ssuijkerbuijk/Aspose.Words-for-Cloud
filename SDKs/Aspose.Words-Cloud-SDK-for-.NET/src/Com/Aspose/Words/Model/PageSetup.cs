using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Com.Aspose.Words.Model {
  public class PageSetup {
    public bool Bidi { get; set; }

    public bool BorderAlwaysInFront { get; set; }

    public string BorderAppliesTo { get; set; }

    public string BorderDistanceFrom { get; set; }

    public double BottomMargin { get; set; }

    public bool DifferentFirstPageHeaderFooter { get; set; }

    public int FirstPageTray { get; set; }

    public double FooterDistance { get; set; }

    public double Gutter { get; set; }

    public double HeaderDistance { get; set; }

    public double LeftMargin { get; set; }

    public int LineNumberCountBy { get; set; }

    public double LineNumberDistanceFromText { get; set; }

    public string LineNumberRestartMode { get; set; }

    public int LineStartingNumber { get; set; }

    public string Orientation { get; set; }

    public int OtherPagesTray { get; set; }

    public double PageHeight { get; set; }

    public string PageNumberStyle { get; set; }

    public int PageStartingNumber { get; set; }

    public double PageWidth { get; set; }

    public string PaperSize { get; set; }

    public bool RestartPageNumbering { get; set; }

    public double RightMargin { get; set; }

    public bool RtlGutter { get; set; }

    public string SectionStart { get; set; }

    public bool SuppressEndnotes { get; set; }

    public double TopMargin { get; set; }

    public string VerticalAlignment { get; set; }

    public Link link { get; set; }

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageSetup {\n");
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
      sb.Append("  link: ").Append(link).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  }
