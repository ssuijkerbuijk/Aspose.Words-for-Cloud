package com.aspose.words.model;
import java.util.List;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class SearchResults {

    @SerializedName("ResultsList")
    @Expose
    private List<ResultsList> resultsList = null;
    @SerializedName("link")
    @Expose
    private Link link;

    public List<ResultsList> getResultsList() {
        return resultsList;
    }

    public void setResultsList(List<ResultsList> resultsList) {
        this.resultsList = resultsList;
    }

    public Link getLink() {
        return link;
    }

    public void setLink(Link link) {
        this.link = link;
    }

}