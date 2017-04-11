package com.aspose.words.model;

import java.util.*;
public class DocumentStatData {
  private Integer WordCount = null;
  private Integer ParagraphCount = null;
  private Integer PageCount = null;
  private List<PageStatData> PageStatData = new ArrayList<PageStatData>();
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

  /**
	 * getPageCount
	 * Gets Integer
	 * @return PageCount
	 */
  public Integer getPageCount() {
    return PageCount;
  }

	/**
	 * setPageCount
	 * Sets Integer
	 * @param PageCount Integer
	 */
  public void setPageCount(Integer PageCount) {
    this.PageCount = PageCount;
  }

  /**
	 * getPageStatData
	 * Gets List<PageStatData>
	 * @return PageStatData
	 */
  public List<PageStatData> getPageStatData() {
    return PageStatData;
  }

	/**
	 * setPageStatData
	 * Sets List<PageStatData>
	 * @param PageStatData List<PageStatData>
	 */
  public void setPageStatData(List<PageStatData> PageStatData) {
    this.PageStatData = PageStatData;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentStatData {\n");
    sb.append("  WordCount: ").append(WordCount).append("\n");
    sb.append("  ParagraphCount: ").append(ParagraphCount).append("\n");
    sb.append("  PageCount: ").append(PageCount).append("\n");
    sb.append("  PageStatData: ").append(PageStatData).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

