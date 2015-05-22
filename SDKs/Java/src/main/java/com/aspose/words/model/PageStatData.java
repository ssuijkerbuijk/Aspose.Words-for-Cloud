package com.aspose.words.model;

public class PageStatData {
  private Integer PageNumber = null;
  private Integer WordCount = null;
  private Integer ParagraphCount = null;
  /**
	 * getPageNumber
	 * Gets Integer
	 * @return PageNumber
	 */
  public Integer getPageNumber() {
    return PageNumber;
  }

	/**
	 * setPageNumber
	 * Sets Integer
	 * @param PageNumber Integer
	 */
  public void setPageNumber(Integer PageNumber) {
    this.PageNumber = PageNumber;
  }

  /**
	 * getWordCount
	 * Gets Integer
	 * @return WordCount
	 */
  public Integer getWordCount() {
    return WordCount;
  }

	/**
	 * setWordCount
	 * Sets Integer
	 * @param WordCount Integer
	 */
  public void setWordCount(Integer WordCount) {
    this.WordCount = WordCount;
  }

  /**
	 * getParagraphCount
	 * Gets Integer
	 * @return ParagraphCount
	 */
  public Integer getParagraphCount() {
    return ParagraphCount;
  }

	/**
	 * setParagraphCount
	 * Sets Integer
	 * @param ParagraphCount Integer
	 */
  public void setParagraphCount(Integer ParagraphCount) {
    this.ParagraphCount = ParagraphCount;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class PageStatData {\n");
    sb.append("  PageNumber: ").append(PageNumber).append("\n");
    sb.append("  WordCount: ").append(WordCount).append("\n");
    sb.append("  ParagraphCount: ").append(ParagraphCount).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

