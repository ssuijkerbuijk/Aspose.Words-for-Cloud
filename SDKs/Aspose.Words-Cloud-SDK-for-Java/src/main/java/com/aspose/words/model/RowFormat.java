
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class RowFormat {

    @SerializedName("Height")
    @Expose
    private Integer height;
    @SerializedName("HeightRule")
    @Expose
    private String heightRule;
    @SerializedName("AllowBreakAcrossPages")
    @Expose
    private Boolean allowBreakAcrossPages;
    @SerializedName("HeadingFormat")
    @Expose
    private Boolean headingFormat;
    @SerializedName("link")
    @Expose
    private Link link;

    public Integer getHeight() {
        return height;
    }

    public void setHeight(Integer height) {
        this.height = height;
    }

    public String getHeightRule() {
        return heightRule;
    }

    public void setHeightRule(String heightRule) {
        this.heightRule = heightRule;
    }

    public Boolean getAllowBreakAcrossPages() {
        return allowBreakAcrossPages;
    }

    public void setAllowBreakAcrossPages(Boolean allowBreakAcrossPages) {
        this.allowBreakAcrossPages = allowBreakAcrossPages;
    }

    public Boolean getHeadingFormat() {
        return headingFormat;
    }

    public void setHeadingFormat(Boolean headingFormat) {
        this.headingFormat = headingFormat;
    }

    public Link getLink() {
        return link;
    }

    public void setLink(Link link) {
        this.link = link;
    }

}
