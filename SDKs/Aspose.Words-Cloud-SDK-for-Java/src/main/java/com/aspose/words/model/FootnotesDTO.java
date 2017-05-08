
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class FootnotesDTO {

    @SerializedName("Position")
    @Expose
    private Position position;
    @SerializedName("FootnoteType")
    @Expose
    private String footnoteType;
    @SerializedName("ReferenceMark")
    @Expose
    private String referenceMark;
    @SerializedName("Text")
    @Expose
    private String text;
    @SerializedName("Content")
    @Expose
    private Content content;
    @SerializedName("NodeId")
    @Expose
    private String nodeId;
    @SerializedName("link")
    @Expose
    private String link;

    public Position getPosition() {
        return position;
    }

    public void setPosition(Position position) {
        this.position = position;
    }

    public String getFootnoteType() {
        return footnoteType;
    }

    public void setFootnoteType(String footnoteType) {
        this.footnoteType = footnoteType;
    }

    public String getReferenceMark() {
        return referenceMark;
    }

    public void setReferenceMark(String referenceMark) {
        this.referenceMark = referenceMark;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public Content getContent() {
        return content;
    }

    public void setContent(Content content) {
        this.content = content;
    }

    public String getNodeId() {
        return nodeId;
    }

    public void setNodeId(String nodeId) {
        this.nodeId = nodeId;
    }

    public String getLink() {
        return link;
    }

    public void setLink(String link) {
        this.link = link;
    }

}
