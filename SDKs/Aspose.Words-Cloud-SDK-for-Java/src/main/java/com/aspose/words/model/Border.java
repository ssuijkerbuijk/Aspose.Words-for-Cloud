package com.aspose.words.model;

import com.aspose.words.model.LineStyle;
public class Border {
  private String LineStyle = null;
  private Double LineWidth = null;
  private Color Color = null;
  private Double DistanceFromText = null;
  private Boolean Shadow = null;
  /**
	 * getLineStyle
	 * Gets LineStyle
	 * @return LineStyle
	 */
  public String getLineStyle() {
    return LineStyle;
  }

	/**
	 * setLineStyle
	 * Sets LineStyle
	 * @param LineStyle LineStyle
	 */
  public void setLineStyle(String LineStyle) {
    this.LineStyle = LineStyle;
  }

  /**
	 * getLineWidth
	 * Gets Double
	 * @return LineWidth
	 */
  public Double getLineWidth() {
    return LineWidth;
  }

	/**
	 * setLineWidth
	 * Sets Double
	 * @param LineWidth Double
	 */
  public void setLineWidth(Double LineWidth) {
    this.LineWidth = LineWidth;
  }

  /**
	 * getColor
	 * Gets Color
	 * @return Color
	 */
  public Color getColor() {
    return Color;
  }

	/**
	 * setColor
	 * Sets Color
	 * @param Color Color
	 */
  public void setColor(Color Color) {
    this.Color = Color;
  }

  /**
	 * getDistanceFromText
	 * Gets Double
	 * @return DistanceFromText
	 */
  public Double getDistanceFromText() {
    return DistanceFromText;
  }

	/**
	 * setDistanceFromText
	 * Sets Double
	 * @param DistanceFromText Double
	 */
  public void setDistanceFromText(Double DistanceFromText) {
    this.DistanceFromText = DistanceFromText;
  }

  /**
	 * getShadow
	 * Gets Boolean
	 * @return Shadow
	 */
  public Boolean getShadow() {
    return Shadow;
  }

	/**
	 * setShadow
	 * Sets Boolean
	 * @param Shadow Boolean
	 */
  public void setShadow(Boolean Shadow) {
    this.Shadow = Shadow;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Border {\n");
    sb.append("  LineStyle: ").append(LineStyle).append("\n");
    sb.append("  LineWidth: ").append(LineWidth).append("\n");
    sb.append("  Color: ").append(Color).append("\n");
    sb.append("  DistanceFromText: ").append(DistanceFromText).append("\n");
    sb.append("  Shadow: ").append(Shadow).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

