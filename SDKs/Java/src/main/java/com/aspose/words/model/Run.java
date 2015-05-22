package com.aspose.words.model;

import com.aspose.words.model.Link;
public class Run {
  private String Text = null;
  private String NodeId = null;
  private Link link = null;
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
    sb.append("class Run {\n");
    sb.append("  Text: ").append(Text).append("\n");
    sb.append("  NodeId: ").append(NodeId).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

