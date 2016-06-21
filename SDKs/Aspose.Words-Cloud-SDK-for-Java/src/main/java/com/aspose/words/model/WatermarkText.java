package com.aspose.words.model;

public class WatermarkText {
  private String Text = null;
  private Double RotationAngle = null;
  /**
	 * getText
	 * Gets String
	 * @return Text
	 */
  public String getText() {
    return Text;
  }

	/**
	 * setText
	 * Sets String
	 * @param Text String
	 */
  public void setText(String Text) {
    this.Text = Text;
  }

  /**
	 * getRotationAngle
	 * Gets Double
	 * @return RotationAngle
	 */
  public Double getRotationAngle() {
    return RotationAngle;
  }

	/**
	 * setRotationAngle
	 * Sets Double
	 * @param RotationAngle Double
	 */
  public void setRotationAngle(Double RotationAngle) {
    this.RotationAngle = RotationAngle;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class WatermarkText {\n");
    sb.append("  Text: ").append(Text).append("\n");
    sb.append("  RotationAngle: ").append(RotationAngle).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

