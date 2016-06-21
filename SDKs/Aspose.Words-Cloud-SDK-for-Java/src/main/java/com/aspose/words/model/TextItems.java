package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class TextItems {
  private List<TextItem> List = new ArrayList<TextItem>();
  private Link link = null;
  /**
	 * getList
	 * Gets List<TextItem>
	 * @return List
	 */
  public List<TextItem> getList() {
    return List;
  }

	/**
	 * setList
	 * Sets List<TextItem>
	 * @param List List<TextItem>
	 */
  public void setList(List<TextItem> List) {
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
    sb.append("class TextItems {\n");
    sb.append("  List: ").append(List).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

