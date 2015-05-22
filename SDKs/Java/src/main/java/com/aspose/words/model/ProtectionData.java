package com.aspose.words.model;

public class ProtectionData {
  private String ProtectionType = null;
  /**
	 * getProtectionType
	 * Gets String
	 * @return ProtectionType
	 */
  public String getProtectionType() {
    return ProtectionType;
  }

	/**
	 * setProtectionType
	 * Sets String
	 * @param ProtectionType String
	 */
  public void setProtectionType(String ProtectionType) {
    this.ProtectionType = ProtectionType;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ProtectionData {\n");
    sb.append("  ProtectionType: ").append(ProtectionType).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

