package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.Link;
public class Paragraph {
  private List<Object> ChildNodes = new ArrayList<Object>();
  private String NodeId = null;
  private Link link = null;
  /**
	 * getChildNodes
	 * Gets List<Object>
	 * @return ChildNodes
	 */
  public List<Object> getChildNodes() {
    return ChildNodes;
  }

	/**
	 * setChildNodes
	 * Sets List<Object>
	 * @param ChildNodes List<Object>
	 */
  public void setChildNodes(List<Object> ChildNodes) {
    this.ChildNodes = ChildNodes;
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
    sb.append("class Paragraph {\n");
    sb.append("  ChildNodes: ").append(ChildNodes).append("\n");
    sb.append("  NodeId: ").append(NodeId).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

