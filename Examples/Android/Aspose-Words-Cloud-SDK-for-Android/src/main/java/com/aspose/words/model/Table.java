
package com.aspose.words.model;

import java.util.List;
import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Table {

    @SerializedName("TableRowList")
    @Expose
    private List<TableRowList> tableRowList = null;
    @SerializedName("TableProperties")
    @Expose
    private TableProperties tableProperties;
    @SerializedName("NodeId")
    @Expose
    private String nodeId;
    @SerializedName("link")
    @Expose
    private Link link;

    public List<TableRowList> getTableRowList() {
        return tableRowList;
    }

    public void setTableRowList(List<TableRowList> tableRowList) {
        this.tableRowList = tableRowList;
    }

    public TableProperties getTableProperties() {
        return tableProperties;
    }

    public void setTableProperties(TableProperties tableProperties) {
        this.tableProperties = tableProperties;
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
