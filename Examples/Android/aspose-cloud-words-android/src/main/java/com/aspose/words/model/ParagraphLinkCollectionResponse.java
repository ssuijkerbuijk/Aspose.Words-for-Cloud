package com.aspose.words.model;

import com.aspose.words.model.ParagraphLinkCollection;
public class ParagraphLinkCollectionResponse {
  private ParagraphLinkCollection Paragraphs = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getParagraphs
	 * Gets ParagraphLinkCollection
	 * @return Paragraphs
	 */
  public ParagraphLinkCollection getParagraphs() {
    return Paragraphs;
  }

	/**
	 * setParagraphs
	 * Sets ParagraphLinkCollection
	 * @param Paragraphs ParagraphLinkCollection
	 */
  public void setParagraphs(ParagraphLinkCollection Paragraphs) {
    this.Paragraphs = Paragraphs;
  }

  /**
	 * getCode
	 * Gets String
	 * @return Code
	 */
  public String getCode() {
    return Code;
  }

	/**
	 * setCode
	 * Sets String
	 * @param Code String
	 */
  public void setCode(String Code) {
    this.Code = Code;
  }

  /**
	 * getStatus
	 * Gets String
	 * @return Status
	 */
  public String getStatus() {
    return Status;
  }

	/**
	 * setStatus
	 * Sets String
	 * @param Status String
	 */
  public void setStatus(String Status) {
    this.Status = Status;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ParagraphLinkCollectionResponse {\n");
    sb.append("  Paragraphs: ").append(Paragraphs).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

