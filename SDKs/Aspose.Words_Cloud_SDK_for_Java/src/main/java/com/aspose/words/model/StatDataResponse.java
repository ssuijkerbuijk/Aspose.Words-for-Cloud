package com.aspose.words.model;

import com.aspose.words.model.Link;
import com.aspose.words.model.DocumentStatData;
public class StatDataResponse {
  private DocumentStatData StatData = null;
  private Link DocumentLink = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getStatData
	 * Gets DocumentStatData
	 * @return StatData
	 */
  public DocumentStatData getStatData() {
    return StatData;
  }

	/**
	 * setStatData
	 * Sets DocumentStatData
	 * @param StatData DocumentStatData
	 */
  public void setStatData(DocumentStatData StatData) {
    this.StatData = StatData;
  }

  /**
	 * getDocumentLink
	 * Gets Link
	 * @return DocumentLink
	 */
  public Link getDocumentLink() {
    return DocumentLink;
  }

	/**
	 * setDocumentLink
	 * Sets Link
	 * @param DocumentLink Link
	 */
  public void setDocumentLink(Link DocumentLink) {
    this.DocumentLink = DocumentLink;
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
    sb.append("class StatDataResponse {\n");
    sb.append("  StatData: ").append(StatData).append("\n");
    sb.append("  DocumentLink: ").append(DocumentLink).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

