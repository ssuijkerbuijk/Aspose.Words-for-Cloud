
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class FootnotesResponse {

    @SerializedName("Footnote")
    @Expose
    private Footnote footnote;
    @SerializedName("Code")
    @Expose
    private String code;
    @SerializedName("Status")
    @Expose
    private String status;

    public Footnote getFootnote() {
        return footnote;
    }

    public void setFootnote(Footnote footnote) {
        this.footnote = footnote;
    }

    public String getCode() {
        return code;
    }

    public void setCode(String code) {
        this.code = code;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

}
