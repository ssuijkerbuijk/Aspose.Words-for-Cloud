package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class DocumentProperties {
  private List<DocumentProperty> List = new ArrayList<DocumentProperty>();
  private Link link = null;
  /**
	 * getList
	 * Gets List<DocumentProperty>
	 * @return List
	 */
  public List<DocumentProperty> getList() {
    return List;
  }

	/**
	 * setList
	 * Sets List<DocumentProperty>
	 * @param List List<DocumentProperty>
	 */
  public void setList(List<DocumentProperty> List) {
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
    sb.append("class DocumentProperties {\n");
    sb.append("  List: ").append(List).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

