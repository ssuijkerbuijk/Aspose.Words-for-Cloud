
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TableResponse {

    @SerializedName("Table")
    @Expose
    private Table table;
    @SerializedName("Code")
    @Expose
    private String code;
    @SerializedName("Status")
    @Expose
    private String status;

    public Table getTable() {
        return table;
    }

    public void setTable(Table table) {
        this.table = table;
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
