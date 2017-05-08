package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class CommentsResponse {

	 @SerializedName("Comments")
	    @Expose
	    private Comments comments;
	    @SerializedName("Code")
	    @Expose
	    private String code;
	    @SerializedName("Status")
	    @Expose
	    private String status;

	    public Comments getComments() {
	        return comments;
	    }

	    public void setComments(Comments comments) {
	        this.comments = comments;
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