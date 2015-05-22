package com.aspose.words.model;

public class MetafileRenderingOptionsData {
  private String EmfPlusDualRenderingMode = null;
  private String RenderingMode = null;
  private Boolean UseEmfEmbeddedToWmf = null;
  /**
	 * getEmfPlusDualRenderingMode
	 * Gets String
	 * @return EmfPlusDualRenderingMode
	 */
  public String getEmfPlusDualRenderingMode() {
    return EmfPlusDualRenderingMode;
  }

	/**
	 * setEmfPlusDualRenderingMode
	 * Sets String
	 * @param EmfPlusDualRenderingMode String
	 */
  public void setEmfPlusDualRenderingMode(String EmfPlusDualRenderingMode) {
    this.EmfPlusDualRenderingMode = EmfPlusDualRenderingMode;
  }

  /**
	 * getRenderingMode
	 * Gets String
	 * @return RenderingMode
	 */
  public String getRenderingMode() {
    return RenderingMode;
  }

	/**
	 * setRenderingMode
	 * Sets String
	 * @param RenderingMode String
	 */
  public void setRenderingMode(String RenderingMode) {
    this.RenderingMode = RenderingMode;
  }

  /**
	 * getUseEmfEmbeddedToWmf
	 * Gets Boolean
	 * @return UseEmfEmbeddedToWmf
	 */
  public Boolean getUseEmfEmbeddedToWmf() {
    return UseEmfEmbeddedToWmf;
  }

	/**
	 * setUseEmfEmbeddedToWmf
	 * Sets Boolean
	 * @param UseEmfEmbeddedToWmf Boolean
	 */
  public void setUseEmfEmbeddedToWmf(Boolean UseEmfEmbeddedToWmf) {
    this.UseEmfEmbeddedToWmf = UseEmfEmbeddedToWmf;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class MetafileRenderingOptionsData {\n");
    sb.append("  EmfPlusDualRenderingMode: ").append(EmfPlusDualRenderingMode).append("\n");
    sb.append("  RenderingMode: ").append(RenderingMode).append("\n");
    sb.append("  UseEmfEmbeddedToWmf: ").append(UseEmfEmbeddedToWmf).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

