package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class FieldNames {
  private List<String> Names = new ArrayList<String>();
  private Link link = null;
  /**
	 * getNames
	 * Gets List<String>
	 * @return Names
	 */
  public List<String> getNames() {
    return Names;
  }

	/**
	 * setNames
	 * Sets List<String>
	 * @param Names List<String>
	 */
  public void setNames(List<String> Names) {
    this.Names = Names;
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
    sb.append("class FieldNames {\n");
    sb.append("  Names: ").append(Names).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

