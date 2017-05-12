
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class OfficeMathObjects {

    @SerializedName("List")
    @Expose
    private java.util.List<com.aspose.words.model.ObjectList> list = null;
    @SerializedName("link")
    @Expose
    private Link link;

    public java.util.List<com.aspose.words.model.ObjectList> getList() {
        return list;
    }

    public void setList(java.util.List<com.aspose.words.model.ObjectList> list) {
        this.list = list;
    }

    public Link getLink() {
        return link;
    }

    public void setLink(Link link) {
        this.link = link;
    }

}