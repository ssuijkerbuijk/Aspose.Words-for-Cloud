package com.aspose.words.model;

import com.aspose.words.model.ModificationOperationResult;
public class RevisionsModificationResponse {
  private ModificationOperationResult Result = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getResult
	 * Gets ModificationOperationResult
	 * @return Result
	 */
  public ModificationOperationResult getResult() {
    return Result;
  }

	/**
	 * setResult
	 * Sets ModificationOperationResult
	 * @param Result ModificationOperationResult
	 */
  public void setResult(ModificationOperationResult Result) {
    this.Result = Result;
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
    sb.append("class RevisionsModificationResponse {\n");
    sb.append("  Result: ").append(Result).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

