package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class Hyperlinks {
  private List<Hyperlink> HyperlinkList = new ArrayList<Hyperlink>();
  private Link link = null;
  /**
	 * getHyperlinkList
	 * Gets List<Hyperlink>
	 * @return HyperlinkList
	 */
  public List<Hyperlink> getHyperlinkList() {
    return HyperlinkList;
  }

	/**
	 * setHyperlinkList
	 * Sets List<Hyperlink>
	 * @param HyperlinkList List<Hyperlink>
	 */
  public void setHyperlinkList(List<Hyperlink> HyperlinkList) {
    this.HyperlinkList = HyperlinkList;
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
    sb.append("class Hyperlinks {\n");
    sb.append("  HyperlinkList: ").append(HyperlinkList).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

