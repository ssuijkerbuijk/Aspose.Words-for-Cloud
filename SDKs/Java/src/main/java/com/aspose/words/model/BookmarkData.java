package com.aspose.words.model;

public class BookmarkData {
  private String Name = null;
  private String Text = null;
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
	 * getText
	 * Gets String
	 * @return Text
	 */
  public String getText() {
    return Text;
  }

	/**
	 * setText
	 * Sets String
	 * @param Text String
	 */
  public void setText(String Text) {
    this.Text = Text;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class BookmarkData {\n");
    sb.append("  Name: ").append(Name).append("\n");
    sb.append("  Text: ").append(Text).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

