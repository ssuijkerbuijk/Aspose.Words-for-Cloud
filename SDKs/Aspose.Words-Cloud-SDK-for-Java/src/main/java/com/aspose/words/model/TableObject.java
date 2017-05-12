
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class TableObject {

    @SerializedName("Postion")
    @Expose
    private Postion postion;
    @SerializedName("ColumnsCount")
    @Expose
    private Integer columnsCount;
    @SerializedName("RowsCount")
    @Expose
    private Integer rowsCount;

    public Postion getPostion() {
        return postion;
    }

    public void setPostion(Postion postion) {
        this.postion = postion;
    }

    public Integer getColumnsCount() {
        return columnsCount;
    }

    public void setColumnsCount(Integer columnsCount) {
        this.columnsCount = columnsCount;
    }

    public Integer getRowsCount() {
        return rowsCount;
    }

    public void setRowsCount(Integer rowsCount) {
        this.rowsCount = rowsCount;
    }

}
