
package com.aspose.words.model;

import java.util.List;
import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TableCellList {

    @SerializedName("ChildNodes")
    @Expose
    private List<ChildNode> childNodes = null;
    @SerializedName("NodeId")
    @Expose
    private String nodeId;
    @SerializedName("link")
    @Expose
    private Link link;

    public List<ChildNode> getChildNodes() {
        return childNodes;
    }

    public void setChildNodes(List<ChildNode> childNodes) {
        this.childNodes = childNodes;
    }

    public String getNodeId() {
        return nodeId;
    }

    public void setNodeId(String nodeId) {
        this.nodeId = nodeId;
    }

    public Link getLink() {
        return link;
    }

    public void setLink(Link link) {
        this.link = link;
    }

}
