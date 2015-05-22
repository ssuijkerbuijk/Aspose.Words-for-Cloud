package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class ParagraphLinkCollection {
  private List<ParagraphLink> ParagraphLinkList = new ArrayList<ParagraphLink>();
  private Link link = null;
  /**
	 * getParagraphLinkList
	 * Gets List<ParagraphLink>
	 * @return ParagraphLinkList
	 */
  public List<ParagraphLink> getParagraphLinkList() {
    return ParagraphLinkList;
  }

	/**
	 * setParagraphLinkList
	 * Sets List<ParagraphLink>
	 * @param ParagraphLinkList List<ParagraphLink>
	 */
  public void setParagraphLinkList(List<ParagraphLink> ParagraphLinkList) {
    this.ParagraphLinkList = ParagraphLinkList;
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
    sb.append("class ParagraphLinkCollection {\n");
    sb.append("  ParagraphLinkList: ").append(ParagraphLinkList).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

