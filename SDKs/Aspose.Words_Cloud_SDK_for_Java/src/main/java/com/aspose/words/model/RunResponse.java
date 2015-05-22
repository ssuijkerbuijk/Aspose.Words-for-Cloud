package com.aspose.words.model;

import com.aspose.words.model.Run;
public class RunResponse {
  private Run Run = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getRun
	 * Gets Run
	 * @return Run
	 */
  public Run getRun() {
    return Run;
  }

	/**
	 * setRun
	 * Sets Run
	 * @param Run Run
	 */
  public void setRun(Run Run) {
    this.Run = Run;
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
    sb.append("class RunResponse {\n");
    sb.append("  Run: ").append(Run).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

