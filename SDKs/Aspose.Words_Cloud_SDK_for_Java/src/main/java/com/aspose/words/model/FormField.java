package com.aspose.words.model;

import com.aspose.words.model.Link;
public class FormField {
  private String Name = null;
  private Boolean Enabled = null;
  private String StatusText = null;
  private Boolean OwnStatus = null;
  private String HelpText = null;
  private Boolean OwnHelp = null;
  private Boolean CalculateOnExit = null;
  private String EntryMacro = null;
  private String ExitMacro = null;
  private String NodeId = null;
  private Link link = null;
  /**
	 * getName
	 * Gets String
	 * @return Name
	 */
  public String getName() {
    return Name;
  }

	/**
	 * setName
	 * Sets String
	 * @param Name String
	 */
  public void setName(String Name) {
    this.Name = Name;
  }

  /**
	 * getEnabled
	 * Gets Boolean
	 * @return Enabled
	 */
  public Boolean getEnabled() {
    return Enabled;
  }

	/**
	 * setEnabled
	 * Sets Boolean
	 * @param Enabled Boolean
	 */
  public void setEnabled(Boolean Enabled) {
    this.Enabled = Enabled;
  }

  /**
	 * getStatusText
	 * Gets String
	 * @return StatusText
	 */
  public String getStatusText() {
    return StatusText;
  }

	/**
	 * setStatusText
	 * Sets String
	 * @param StatusText String
	 */
  public void setStatusText(String StatusText) {
    this.StatusText = StatusText;
  }

  /**
	 * getOwnStatus
	 * Gets Boolean
	 * @return OwnStatus
	 */
  public Boolean getOwnStatus() {
    return OwnStatus;
  }

	/**
	 * setOwnStatus
	 * Sets Boolean
	 * @param OwnStatus Boolean
	 */
  public void setOwnStatus(Boolean OwnStatus) {
    this.OwnStatus = OwnStatus;
  }

  /**
	 * getHelpText
	 * Gets String
	 * @return HelpText
	 */
  public String getHelpText() {
    return HelpText;
  }

	/**
	 * setHelpText
	 * Sets String
	 * @param HelpText String
	 */
  public void setHelpText(String HelpText) {
    this.HelpText = HelpText;
  }

  /**
	 * getOwnHelp
	 * Gets Boolean
	 * @return OwnHelp
	 */
  public Boolean getOwnHelp() {
    return OwnHelp;
  }

	/**
	 * setOwnHelp
	 * Sets Boolean
	 * @param OwnHelp Boolean
	 */
  public void setOwnHelp(Boolean OwnHelp) {
    this.OwnHelp = OwnHelp;
  }

  /**
	 * getCalculateOnExit
	 * Gets Boolean
	 * @return CalculateOnExit
	 */
  public Boolean getCalculateOnExit() {
    return CalculateOnExit;
  }

	/**
	 * setCalculateOnExit
	 * Sets Boolean
	 * @param CalculateOnExit Boolean
	 */
  public void setCalculateOnExit(Boolean CalculateOnExit) {
    this.CalculateOnExit = CalculateOnExit;
  }

  /**
	 * getEntryMacro
	 * Gets String
	 * @return EntryMacro
	 */
  public String getEntryMacro() {
    return EntryMacro;
  }

	/**
	 * setEntryMacro
	 * Sets String
	 * @param EntryMacro String
	 */
  public void setEntryMacro(String EntryMacro) {
    this.EntryMacro = EntryMacro;
  }

  /**
	 * getExitMacro
	 * Gets String
	 * @return ExitMacro
	 */
  public String getExitMacro() {
    return ExitMacro;
  }

	/**
	 * setExitMacro
	 * Sets String
	 * @param ExitMacro String
	 */
  public void setExitMacro(String ExitMacro) {
    this.ExitMacro = ExitMacro;
  }

  /**
	 * getNodeId
	 * Gets String
	 * @return NodeId
	 */
  public String getNodeId() {
    return NodeId;
  }

	/**
	 * setNodeId
	 * Sets String
	 * @param NodeId String
	 */
  public void setNodeId(String NodeId) {
    this.NodeId = NodeId;
  }

  /**
	 * getLink
	 * Gets Link
	 * @return link
	 */
  public Link getLink() {
    return link;
  }

	/**
	 * setLink
	 * Sets Link
	 * @param link Link
	 */
  public void setLink(Link link) {
    this.link = link;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class FormField {\n");
    sb.append("  Name: ").append(Name).append("\n");
    sb.append("  Enabled: ").append(Enabled).append("\n");
    sb.append("  StatusText: ").append(StatusText).append("\n");
    sb.append("  OwnStatus: ").append(OwnStatus).append("\n");
    sb.append("  HelpText: ").append(HelpText).append("\n");
    sb.append("  OwnHelp: ").append(OwnHelp).append("\n");
    sb.append("  CalculateOnExit: ").append(CalculateOnExit).append("\n");
    sb.append("  EntryMacro: ").append(EntryMacro).append("\n");
    sb.append("  ExitMacro: ").append(ExitMacro).append("\n");
    sb.append("  NodeId: ").append(NodeId).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

