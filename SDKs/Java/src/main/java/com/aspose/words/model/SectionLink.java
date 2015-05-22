package com.aspose.words.model;

import com.aspose.words.model.Link;
public class SectionLink {
  private Link link = null;
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
    sb.append("class SectionLink {\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

