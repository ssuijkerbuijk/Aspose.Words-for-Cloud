package com.aspose.words.model;

import com.aspose.words.model.Link;
public class DocumentProperty {
  private String Name = null;
  private String Value = null;
  private Boolean BuiltIn = null;
  private Link link = null;
  /**
	 * getName
	 * Gets String
	 * @return Name
	 */
  public String getName() {
    return Name;
  }

	/**
	 * setName
	 * Sets String
	 * @param Name String
	 */
  public void setName(String Name) {
    this.Name = Name;
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
	 * getBuiltIn
	 * Gets Boolean
	 * @return BuiltIn
	 */
  public Boolean getBuiltIn() {
    return BuiltIn;
  }

	/**
	 * setBuiltIn
	 * Sets Boolean
	 * @param BuiltIn Boolean
	 */
  public void setBuiltIn(Boolean BuiltIn) {
    this.BuiltIn = BuiltIn;
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
    sb.append("class DocumentProperty {\n");
    sb.append("  Name: ").append(Name).append("\n");
    sb.append("  Value: ").append(Value).append("\n");
    sb.append("  BuiltIn: ").append(BuiltIn).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

