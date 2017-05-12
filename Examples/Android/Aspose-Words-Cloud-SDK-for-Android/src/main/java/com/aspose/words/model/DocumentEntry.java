package com.aspose.words.model;

public class DocumentEntry {
  private String Href = null;
  private String ImportFormatMode = null;
  /**
	 * getHref
	 * Gets String
	 * @return Href
	 */
  public String getHref() {
    return Href;
  }

	/**
	 * setHref
	 * Sets String
	 * @param Href String
	 */
  public void setHref(String Href) {
    this.Href = Href;
  }

  /**
	 * getImportFormatMode
	 * Gets String
	 * @return ImportFormatMode
	 */
  public String getImportFormatMode() {
    return ImportFormatMode;
  }

	/**
	 * setImportFormatMode
	 * Sets String
	 * @param ImportFormatMode String
	 */
  public void setImportFormatMode(String ImportFormatMode) {
    this.ImportFormatMode = ImportFormatMode;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentEntry {\n");
    sb.append("  Href: ").append(Href).append("\n");
    sb.append("  ImportFormatMode: ").append(ImportFormatMode).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

