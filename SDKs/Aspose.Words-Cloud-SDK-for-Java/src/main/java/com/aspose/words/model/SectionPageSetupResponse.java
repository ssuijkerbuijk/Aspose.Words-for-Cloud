package com.aspose.words.model;

import com.aspose.words.model.PageSetup;
public class SectionPageSetupResponse {
  private PageSetup PageSetup = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getPageSetup
	 * Gets PageSetup
	 * @return PageSetup
	 */
  public PageSetup getPageSetup() {
    return PageSetup;
  }

	/**
	 * setPageSetup
	 * Sets PageSetup
	 * @param PageSetup PageSetup
	 */
  public void setPageSetup(PageSetup PageSetup) {
    this.PageSetup = PageSetup;
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
    sb.append("class SectionPageSetupResponse {\n");
    sb.append("  PageSetup: ").append(PageSetup).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

