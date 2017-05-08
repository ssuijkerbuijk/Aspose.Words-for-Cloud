
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class ResultsList {

    @SerializedName("RangeStart")
    @Expose
    private RangeStart rangeStart;
    @SerializedName("RangeEnd")
    @Expose
    private RangeEnd rangeEnd;

    public RangeStart getRangeStart() {
        return rangeStart;
    }

    public void setRangeStart(RangeStart rangeStart) {
        this.rangeStart = rangeStart;
    }

    public RangeEnd getRangeEnd() {
        return rangeEnd;
    }

    public void setRangeEnd(RangeEnd rangeEnd) {
        this.rangeEnd = rangeEnd;
    }

}
