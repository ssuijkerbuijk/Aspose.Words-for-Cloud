package com.aspose.words.model;

public class ReplaceTextRequest {
  private String OldValue = null;
  private String NewValue = null;
  private Boolean IsMatchCase = null;
  private Boolean IsMatchWholeWord = null;
  /**
	 * getOldValue
	 * Gets String
	 * @return OldValue
	 */
  public String getOldValue() {
    return OldValue;
  }

	/**
	 * setOldValue
	 * Sets String
	 * @param OldValue String
	 */
  public void setOldValue(String OldValue) {
    this.OldValue = OldValue;
  }

  /**
	 * getNewValue
	 * Gets String
	 * @return NewValue
	 */
  public String getNewValue() {
    return NewValue;
  }

	/**
	 * setNewValue
	 * Sets String
	 * @param NewValue String
	 */
  public void setNewValue(String NewValue) {
    this.NewValue = NewValue;
  }

  /**
	 * getIsMatchCase
	 * Gets Boolean
	 * @return IsMatchCase
	 */
  public Boolean getIsMatchCase() {
    return IsMatchCase;
  }

	/**
	 * setIsMatchCase
	 * Sets Boolean
	 * @param IsMatchCase Boolean
	 */
  public void setIsMatchCase(Boolean IsMatchCase) {
    this.IsMatchCase = IsMatchCase;
  }

  /**
	 * getIsMatchWholeWord
	 * Gets Boolean
	 * @return IsMatchWholeWord
	 */
  public Boolean getIsMatchWholeWord() {
    return IsMatchWholeWord;
  }

	/**
	 * setIsMatchWholeWord
	 * Sets Boolean
	 * @param IsMatchWholeWord Boolean
	 */
  public void setIsMatchWholeWord(Boolean IsMatchWholeWord) {
    this.IsMatchWholeWord = IsMatchWholeWord;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ReplaceTextRequest {\n");
    sb.append("  OldValue: ").append(OldValue).append("\n");
    sb.append("  NewValue: ").append(NewValue).append("\n");
    sb.append("  IsMatchCase: ").append(IsMatchCase).append("\n");
    sb.append("  IsMatchWholeWord: ").append(IsMatchWholeWord).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

