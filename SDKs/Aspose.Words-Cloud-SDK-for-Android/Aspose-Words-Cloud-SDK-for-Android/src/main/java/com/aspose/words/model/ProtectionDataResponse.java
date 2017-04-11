package com.aspose.words.model;

import com.aspose.words.model.Link;
import com.aspose.words.model.ProtectionData;
public class ProtectionDataResponse {
  private ProtectionData ProtectionData = null;
  private Link DocumentLink = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getProtectionData
	 * Gets ProtectionData
	 * @return ProtectionData
	 */
  public ProtectionData getProtectionData() {
    return ProtectionData;
  }

	/**
	 * setProtectionData
	 * Sets ProtectionData
	 * @param ProtectionData ProtectionData
	 */
  public void setProtectionData(ProtectionData ProtectionData) {
    this.ProtectionData = ProtectionData;
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
    sb.append("class ProtectionDataResponse {\n");
    sb.append("  ProtectionData: ").append(ProtectionData).append("\n");
    sb.append("  DocumentLink: ").append(DocumentLink).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

