package com.aspose.words.model;

import com.aspose.words.model.SectionLinkCollection;
public class SectionLinkCollectionResponse {
  private SectionLinkCollection Sections = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getSections
	 * Gets SectionLinkCollection
	 * @return Sections
	 */
  public SectionLinkCollection getSections() {
    return Sections;
  }

	/**
	 * setSections
	 * Sets SectionLinkCollection
	 * @param Sections SectionLinkCollection
	 */
  public void setSections(SectionLinkCollection Sections) {
    this.Sections = Sections;
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
    sb.append("class SectionLinkCollectionResponse {\n");
    sb.append("  Sections: ").append(Sections).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

