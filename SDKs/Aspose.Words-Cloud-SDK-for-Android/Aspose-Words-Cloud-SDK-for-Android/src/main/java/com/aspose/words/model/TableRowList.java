
package com.aspose.words.model;

import java.util.List;
import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TableRowList {

    @SerializedName("TableCellList")
    @Expose
    private List<TableCellList> tableCellList = null;
    @SerializedName("RowFormat")
    @Expose
    private RowFormat rowFormat;
    @SerializedName("NodeId")
    @Expose
    private String nodeId;
    @SerializedName("link")
    @Expose
    private Link link;

    public List<TableCellList> getTableCellList() {
        return tableCellList;
    }

    public void setTableCellList(List<TableCellList> tableCellList) {
        this.tableCellList = tableCellList;
    }

    public RowFormat getRowFormat() {
        return rowFormat;
    }

    public void setRowFormat(RowFormat rowFormat) {
        this.rowFormat = rowFormat;
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
