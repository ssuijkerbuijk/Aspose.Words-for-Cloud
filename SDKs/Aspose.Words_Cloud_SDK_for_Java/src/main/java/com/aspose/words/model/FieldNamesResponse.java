package com.aspose.words.model;

import com.aspose.words.model.FieldNames;
public class FieldNamesResponse {
  private FieldNames FieldNames = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getFieldNames
	 * Gets FieldNames
	 * @return FieldNames
	 */
  public FieldNames getFieldNames() {
    return FieldNames;
  }

	/**
	 * setFieldNames
	 * Sets FieldNames
	 * @param FieldNames FieldNames
	 */
  public void setFieldNames(FieldNames FieldNames) {
    this.FieldNames = FieldNames;
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
    sb.append("class FieldNamesResponse {\n");
    sb.append("  FieldNames: ").append(FieldNames).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

