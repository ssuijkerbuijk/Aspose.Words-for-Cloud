
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class ObjectList {

    @SerializedName("Content")
    @Expose
    private Content content;
    @SerializedName("DisplayType")
    @Expose
    private String displayType;
    @SerializedName("Justification")
    @Expose
    private String justification;
    @SerializedName("MathObjectType")
    @Expose
    private String mathObjectType;
    @SerializedName("NodeId")
    @Expose
    private String nodeId;
    @SerializedName("link")
    @Expose
    private Link link;

    public Content getContent() {
        return content;
    }

    public void setContent(Content content) {
        this.content = content;
    }

    public String getDisplayType() {
        return displayType;
    }

    public void setDisplayType(String displayType) {
        this.displayType = displayType;
    }

    public String getJustification() {
        return justification;
    }

    public void setJustification(String justification) {
        this.justification = justification;
    }

    public String getMathObjectType() {
        return mathObjectType;
    }

    public void setMathObjectType(String mathObjectType) {
        this.mathObjectType = mathObjectType;
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
