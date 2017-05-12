
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class OfficeMathObjectsResponse {

    @SerializedName("OfficeMathObjects")
    @Expose
    private OfficeMathObjects officeMathObjects;
    @SerializedName("Code")
    @Expose
    private String code;
    @SerializedName("Status")
    @Expose
    private String status;

    public OfficeMathObjects getOfficeMathObjects() {
        return officeMathObjects;
    }

    public void setOfficeMathObjects(OfficeMathObjects officeMathObjects) {
        this.officeMathObjects = officeMathObjects;
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
