
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TableProperties {

    @SerializedName("Alignment")
    @Expose
    private String alignment;
    @SerializedName("AllowAutoFit")
    @Expose
    private Boolean allowAutoFit;
    @SerializedName("Bidi")
    @Expose
    private Boolean bidi;
    @SerializedName("BottomPadding")
    @Expose
    private Double bottomPadding;
    @SerializedName("CellSpacing")
    @Expose
    private Double cellSpacing;
    @SerializedName("LeftIndent")
    @Expose
    private Double leftIndent;
    @SerializedName("LeftPadding")
    @Expose
    private Double leftPadding;
    @SerializedName("PreferredWidth")
    @Expose
    private PreferredWidth preferredWidth;
    @SerializedName("RightPadding")
    @Expose
    private Double rightPadding;
    @SerializedName("StyleIdentifier")
    @Expose
    private String styleIdentifier;
    @SerializedName("StyleName")
    @Expose
    private String styleName;
    @SerializedName("StyleOptions")
    @Expose
    private String styleOptions;
    @SerializedName("TextWrapping")
    @Expose
    private String textWrapping;
    @SerializedName("TopPadding")
    @Expose
    private Integer topPadding;
    @SerializedName("link")
    @Expose
    private Link link;

    public String getAlignment() {
        return alignment;
    }

    public void setAlignment(String alignment) {
        this.alignment = alignment;
    }

    public Boolean getAllowAutoFit() {
        return allowAutoFit;
    }

    public void setAllowAutoFit(Boolean allowAutoFit) {
        this.allowAutoFit = allowAutoFit;
    }

    public Boolean getBidi() {
        return bidi;
    }

    public void setBidi(Boolean bidi) {
        this.bidi = bidi;
    }

    public Double getBottomPadding() {
        return bottomPadding;
    }

    public void setBottomPadding(Double bottomPadding) {
        this.bottomPadding = bottomPadding;
    }

    public Double getCellSpacing() {
        return cellSpacing;
    }

    public void setCellSpacing(Double cellSpacing) {
        this.cellSpacing = cellSpacing;
    }

    public Double getLeftIndent() {
        return leftIndent;
    }

    public void setLeftIndent(Double leftIndent) {
        this.leftIndent = leftIndent;
    }

    public Double getLeftPadding() {
        return leftPadding;
    }

    public void setLeftPadding(Double leftPadding) {
        this.leftPadding = leftPadding;
    }

    public PreferredWidth getPreferredWidth() {
        return preferredWidth;
    }

    public void setPreferredWidth(PreferredWidth preferredWidth) {
        this.preferredWidth = preferredWidth;
    }

    public Double getRightPadding() {
        return rightPadding;
    }

    public void setRightPadding(Double rightPadding) {
        this.rightPadding = rightPadding;
    }

    public String getStyleIdentifier() {
        return styleIdentifier;
    }

    public void setStyleIdentifier(String styleIdentifier) {
        this.styleIdentifier = styleIdentifier;
    }

    public String getStyleName() {
        return styleName;
    }

    public void setStyleName(String styleName) {
        this.styleName = styleName;
    }

    public String getStyleOptions() {
        return styleOptions;
    }

    public void setStyleOptions(String styleOptions) {
        this.styleOptions = styleOptions;
    }

    public String getTextWrapping() {
        return textWrapping;
    }

    public void setTextWrapping(String textWrapping) {
        this.textWrapping = textWrapping;
    }

    public Integer getTopPadding() {
        return topPadding;
    }

    public void setTopPadding(Integer topPadding) {
        this.topPadding = topPadding;
    }

    public Link getLink() {
        return link;
    }

    public void setLink(Link link) {
        this.link = link;
    }

}
