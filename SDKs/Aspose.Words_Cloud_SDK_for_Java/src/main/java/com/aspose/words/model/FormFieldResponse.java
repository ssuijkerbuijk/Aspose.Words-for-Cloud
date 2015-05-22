package com.aspose.words.model;

import com.aspose.words.model.FormField;
public class FormFieldResponse {
  private FormField FormField = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getFormField
	 * Gets FormField
	 * @return FormField
	 */
  public FormField getFormField() {
    return FormField;
  }

	/**
	 * setFormField
	 * Sets FormField
	 * @param FormField FormField
	 */
  public void setFormField(FormField FormField) {
    this.FormField = FormField;
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
    sb.append("class FormFieldResponse {\n");
    sb.append("  FormField: ").append(FormField).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

