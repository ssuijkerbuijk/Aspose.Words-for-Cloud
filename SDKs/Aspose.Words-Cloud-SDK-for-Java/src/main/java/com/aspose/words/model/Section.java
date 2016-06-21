package com.aspose.words.model;

import com.aspose.words.model.Link;
import com.aspose.words.model.LinkElement;
public class Section {
  private LinkElement Paragraphs = null;
  private LinkElement PageSetup = null;
  private Link link = null;
  /**
	 * getParagraphs
	 * Gets LinkElement
	 * @return Paragraphs
	 */
  public LinkElement getParagraphs() {
    return Paragraphs;
  }

	/**
	 * setParagraphs
	 * Sets LinkElement
	 * @param Paragraphs LinkElement
	 */
  public void setParagraphs(LinkElement Paragraphs) {
    this.Paragraphs = Paragraphs;
  }

  /**
	 * getPageSetup
	 * Gets LinkElement
	 * @return PageSetup
	 */
  public LinkElement getPageSetup() {
    return PageSetup;
  }

	/**
	 * setPageSetup
	 * Sets LinkElement
	 * @param PageSetup LinkElement
	 */
  public void setPageSetup(LinkElement PageSetup) {
    this.PageSetup = PageSetup;
  }

  /**
	 * getLink
	 * Gets Link
	 * @return link
	 */
  public Link getLink() {
    return link;
  }

	/**
	 * setLink
	 * Sets Link
	 * @param link Link
	 */
  public void setLink(Link link) {
    this.link = link;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Section {\n");
    sb.append("  Paragraphs: ").append(Paragraphs).append("\n");
    sb.append("  PageSetup: ").append(PageSetup).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

