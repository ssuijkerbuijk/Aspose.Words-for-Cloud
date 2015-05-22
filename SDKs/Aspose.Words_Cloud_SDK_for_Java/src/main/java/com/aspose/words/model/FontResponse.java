package com.aspose.words.model;

import com.aspose.words.model.Font;
public class FontResponse {
  private Font Font = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getFont
	 * Gets Font
	 * @return Font
	 */
  public Font getFont() {
    return Font;
  }

	/**
	 * setFont
	 * Sets Font
	 * @param Font Font
	 */
  public void setFont(Font Font) {
    this.Font = Font;
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
    sb.append("class FontResponse {\n");
    sb.append("  Font: ").append(Font).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

