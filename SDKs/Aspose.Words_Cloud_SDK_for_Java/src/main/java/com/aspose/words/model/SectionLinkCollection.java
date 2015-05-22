package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class SectionLinkCollection {
  private List<SectionLink> SectionLinkList = new ArrayList<SectionLink>();
  private Link link = null;
  /**
	 * getSectionLinkList
	 * Gets List<SectionLink>
	 * @return SectionLinkList
	 */
  public List<SectionLink> getSectionLinkList() {
    return SectionLinkList;
  }

	/**
	 * setSectionLinkList
	 * Sets List<SectionLink>
	 * @param SectionLinkList List<SectionLink>
	 */
  public void setSectionLinkList(List<SectionLink> SectionLinkList) {
    this.SectionLinkList = SectionLinkList;
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
    sb.append("class SectionLinkCollection {\n");
    sb.append("  SectionLinkList: ").append(SectionLinkList).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

