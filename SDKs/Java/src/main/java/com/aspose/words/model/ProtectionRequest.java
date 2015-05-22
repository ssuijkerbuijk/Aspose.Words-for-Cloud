package com.aspose.words.model;

public class ProtectionRequest {
  private String Password = null;
  private String NewPassword = null;
  private String ProtectionType = null;
  /**
	 * getPassword
	 * Gets String
	 * @return Password
	 */
  public String getPassword() {
    return Password;
  }

	/**
	 * setPassword
	 * Sets String
	 * @param Password String
	 */
  public void setPassword(String Password) {
    this.Password = Password;
  }

  /**
	 * getNewPassword
	 * Gets String
	 * @return NewPassword
	 */
  public String getNewPassword() {
    return NewPassword;
  }

	/**
	 * setNewPassword
	 * Sets String
	 * @param NewPassword String
	 */
  public void setNewPassword(String NewPassword) {
    this.NewPassword = NewPassword;
  }

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
    sb.append("class ProtectionRequest {\n");
    sb.append("  Password: ").append(Password).append("\n");
    sb.append("  NewPassword: ").append(NewPassword).append("\n");
    sb.append("  ProtectionType: ").append(ProtectionType).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

