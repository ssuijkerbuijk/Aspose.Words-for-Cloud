package com.aspose.words.model;

import com.aspose.words.model.DrawingObject;

public class DrawingObjectResponse {
  private DrawingObject DrawingObject = null;
  private String Code = null;
  private String Status = null;
  /**
	 * getDrawingObject
	 * Gets DrawingObject
	 * @return DrawingObject
	 */
  public DrawingObject getDrawingObject() {
    return DrawingObject;
  }

	/**
	 * setDrawingObject
	 * Sets DrawingObject
	 * @param DrawingObjects DrawingObject
	 */
  public void setDrawingObject(DrawingObject DrawingObject) {
    this.DrawingObject = DrawingObject;
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
    sb.append("class DrawingObjectResponse {\n");
    sb.append("  DrawingObject: ").append(DrawingObject).append("\n");
    sb.append("  Code: ").append(Code).append("\n");
    sb.append("  Status: ").append(Status).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

