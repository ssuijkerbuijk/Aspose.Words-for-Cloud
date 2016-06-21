package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class DrawingObjects {
  private List<LinkElement> List = new ArrayList<LinkElement>();
  private Link link = null;
  /**
	 * getList
	 * Gets List<LinkElement>
	 * @return List
	 */
  public List<LinkElement> getList() {
    return List;
  }

	/**
	 * setList
	 * Sets List<LinkElement>
	 * @param List List<LinkElement>
	 */
  public void setList(List<LinkElement> List) {
    this.List = List;
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
    sb.append("class DrawingObjects {\n");
    sb.append("  List: ").append(List).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

