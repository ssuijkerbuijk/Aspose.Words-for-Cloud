package com.aspose.words.model;

import com.aspose.words.model.Section;
public class SectionResponse {
  private Section Section = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getSection
	 * Gets Section
	 * @return Section
	 */
  public Section getSection() {
    return Section;
  }

	/**
	 * setSection
	 * Sets Section
	 * @param Section Section
	 */
  public void setSection(Section Section) {
    this.Section = Section;
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
    sb.append("class SectionResponse {\n");
    sb.append("  Section: ").append(Section).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

