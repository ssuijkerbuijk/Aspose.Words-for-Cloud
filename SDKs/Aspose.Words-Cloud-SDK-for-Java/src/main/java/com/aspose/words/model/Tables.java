
package com.aspose.words.model;

import java.util.List;
import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class Tables {

    @SerializedName("TableLinkList")
    @Expose
    private List<TableLinkList> tableLinkList = null;
    @SerializedName("link")
    @Expose
    private String link;

    public List<TableLinkList> getTableLinkList() {
        return tableLinkList;
    }

    public void setTableLinkList(List<TableLinkList> tableLinkList) {
        this.tableLinkList = tableLinkList;
    }

    public String getLink() {
        return link;
    }

    public void setLink(String link) {
        this.link = link;
    }

}
