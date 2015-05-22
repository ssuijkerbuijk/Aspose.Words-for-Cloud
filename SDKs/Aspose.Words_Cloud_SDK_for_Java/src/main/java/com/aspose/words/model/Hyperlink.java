package com.aspose.words.model;

import com.aspose.words.model.Link;
public class Hyperlink {
  private String DisplayText = null;
  private String Value = null;
  private Link link = null;
  /**
	 * getDisplayText
	 * Gets String
	 * @return DisplayText
	 */
  public String getDisplayText() {
    return DisplayText;
  }

	/**
	 * setDisplayText
	 * Sets String
	 * @param DisplayText String
	 */
  public void setDisplayText(String DisplayText) {
    this.DisplayText = DisplayText;
  }

  /**
	 * getValue
	 * Gets String
	 * @return Value
	 */
  public String getValue() {
    return Value;
  }

	/**
	 * setValue
	 * Sets String
	 * @param Value String
	 */
  public void setValue(String Value) {
    this.Value = Value;
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
    sb.append("class Hyperlink {\n");
    sb.append("  DisplayText: ").append(DisplayText).append("\n");
    sb.append("  Value: ").append(Value).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

