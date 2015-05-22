package com.aspose.words.model;

public class DocSaveOptions {
  private String SaveFormat = null;
  private String FileName = null;
  private String Password = "";
  private Boolean SaveRoutingSlip = true;
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

        public String getPassword() {
                return Password;
        }

        public void setPassword(String password) {
                Password = password;
        }

        public Boolean getSaveRoutingSlip() {
                return SaveRoutingSlip;
        }

        public void setSaveRoutingSlip(Boolean saveRoutingSlip) {
                SaveRoutingSlip = saveRoutingSlip;
        }

  
  
}

