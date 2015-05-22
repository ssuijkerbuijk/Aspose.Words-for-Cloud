package com.aspose.words.model;

public class PageNumber {
  private String Format = null;
  private String Alignment = null;
  private Boolean IsTop = null;
  private Boolean SetPageNumberOnFirstPage = null;
  /**
	 * getFormat
	 * Gets String
	 * @return Format
	 */
  public String getFormat() {
    return Format;
  }

	/**
	 * setFormat
	 * Sets String
	 * @param Format String
	 */
  public void setFormat(String Format) {
    this.Format = Format;
  }

  /**
	 * getAlignment
	 * Gets String
	 * @return Alignment
	 */
  public String getAlignment() {
    return Alignment;
  }

	/**
	 * setAlignment
	 * Sets String
	 * @param Alignment String
	 */
  public void setAlignment(String Alignment) {
    this.Alignment = Alignment;
  }

  /**
	 * getIsTop
	 * Gets Boolean
	 * @return IsTop
	 */
  public Boolean getIsTop() {
    return IsTop;
  }

	/**
	 * setIsTop
	 * Sets Boolean
	 * @param IsTop Boolean
	 */
  public void setIsTop(Boolean IsTop) {
    this.IsTop = IsTop;
  }

  /**
	 * getSetPageNumberOnFirstPage
	 * Gets Boolean
	 * @return SetPageNumberOnFirstPage
	 */
  public Boolean getSetPageNumberOnFirstPage() {
    return SetPageNumberOnFirstPage;
  }

	/**
	 * setSetPageNumberOnFirstPage
	 * Sets Boolean
	 * @param SetPageNumberOnFirstPage Boolean
	 */
  public void setSetPageNumberOnFirstPage(Boolean SetPageNumberOnFirstPage) {
    this.SetPageNumberOnFirstPage = SetPageNumberOnFirstPage;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PageNumber {\n");
    sb.append("  Format: ").append(Format).append("\n");
    sb.append("  Alignment: ").append(Alignment).append("\n");
    sb.append("  IsTop: ").append(IsTop).append("\n");
    sb.append("  SetPageNumberOnFirstPage: ").append(SetPageNumberOnFirstPage).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

