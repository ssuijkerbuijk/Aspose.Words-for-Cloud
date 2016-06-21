package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class SplitDocumentResult {
  private Link SourceDocument = null;
  private List<Link> Pages = new ArrayList<Link>();
  private Link ZippedPages = null;
  /**
	 * getSourceDocument
	 * Gets Link
	 * @return SourceDocument
	 */
  public Link getSourceDocument() {
    return SourceDocument;
  }

	/**
	 * setSourceDocument
	 * Sets Link
	 * @param SourceDocument Link
	 */
  public void setSourceDocument(Link SourceDocument) {
    this.SourceDocument = SourceDocument;
  }

  /**
	 * getPages
	 * Gets List<Link>
	 * @return Pages
	 */
  public List<Link> getPages() {
    return Pages;
  }

	/**
	 * setPages
	 * Sets List<Link>
	 * @param Pages List<Link>
	 */
  public void setPages(List<Link> Pages) {
    this.Pages = Pages;
  }

  /**
	 * getZippedPages
	 * Gets Link
	 * @return ZippedPages
	 */
  public Link getZippedPages() {
    return ZippedPages;
  }

	/**
	 * setZippedPages
	 * Sets Link
	 * @param ZippedPages Link
	 */
  public void setZippedPages(Link ZippedPages) {
    this.ZippedPages = ZippedPages;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class SplitDocumentResult {\n");
    sb.append("  SourceDocument: ").append(SourceDocument).append("\n");
    sb.append("  Pages: ").append(Pages).append("\n");
    sb.append("  ZippedPages: ").append(ZippedPages).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

