package com.aspose.words.model;

public class SaveOptions {
  private String SaveFormat = null;
  private String FileName = null;
  private String DmlRenderingMode = null;
  private String DmlEffectsRenderingMode = null;
  private Boolean ZipOutput = true;
  /**
	 * getSaveFormat
	 * Gets String
	 * @return SaveFormat
	 */
  public String getSaveFormat() {
    return SaveFormat;
  }

	/**
	 * setSaveFormat
	 * Sets String
	 * @param SaveFormat String
	 */
  public void setSaveFormat(String SaveFormat) {
    this.SaveFormat = SaveFormat;
  }

  /**
	 * getFileName
	 * Gets String
	 * @return FileName
	 */
  public String getFileName() {
    return FileName;
  }

	/**
	 * setFileName
	 * Sets String
	 * @param FileName String
	 */
  public void setFileName(String FileName) {
    this.FileName = FileName;
  }

  /**
	 * getDmlRenderingMode
	 * Gets String
	 * @return DmlRenderingMode
	 */
  public String getDmlRenderingMode() {
    return DmlRenderingMode;
  }

	/**
	 * setDmlRenderingMode
	 * Sets String
	 * @param DmlRenderingMode String
	 */
  public void setDmlRenderingMode(String DmlRenderingMode) {
    this.DmlRenderingMode = DmlRenderingMode;
  }

  /**
	 * getDmlEffectsRenderingMode
	 * Gets String
	 * @return DmlEffectsRenderingMode
	 */
  public String getDmlEffectsRenderingMode() {
    return DmlEffectsRenderingMode;
  }

	/**
	 * setDmlEffectsRenderingMode
	 * Sets String
	 * @param DmlEffectsRenderingMode String
	 */
  public void setDmlEffectsRenderingMode(String DmlEffectsRenderingMode) {
    this.DmlEffectsRenderingMode = DmlEffectsRenderingMode;
  }

  /**
	 * getZipOutput
	 * Gets Boolean
	 * @return ZipOutput
	 */
  public Boolean getZipOutput() {
    return ZipOutput;
  }

	/**
	 * setZipOutput
	 * Sets Boolean
	 * @param ZipOutput Boolean
	 */
  public void setZipOutput(Boolean ZipOutput) {
    this.ZipOutput = ZipOutput;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class SaveOptionsData {\n");
    sb.append("  SaveFormat: ").append(SaveFormat).append("\n");
    sb.append("  FileName: ").append(FileName).append("\n");
    sb.append("  DmlRenderingMode: ").append(DmlRenderingMode).append("\n");
    sb.append("  DmlEffectsRenderingMode: ").append(DmlEffectsRenderingMode).append("\n");
    sb.append("  ZipOutput: ").append(ZipOutput).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

