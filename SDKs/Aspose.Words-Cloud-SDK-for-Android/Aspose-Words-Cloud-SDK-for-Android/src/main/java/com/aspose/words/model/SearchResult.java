
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class SearchResult {

    @SerializedName("SearchingPattern")
    @Expose
    private String searchingPattern;
    @SerializedName("SearchResults")
    @Expose
    private SearchResults searchResults;
    @SerializedName("Code")
    @Expose
    private String code;
    @SerializedName("Status")
    @Expose
    private String status;

    public String getSearchingPattern() {
        return searchingPattern;
    }

    public void setSearchingPattern(String searchingPattern) {
        this.searchingPattern = searchingPattern;
    }

    public SearchResults getSearchResults() {
        return searchResults;
    }

    public void setSearchResults(SearchResults searchResults) {
        this.searchResults = searchResults;
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
