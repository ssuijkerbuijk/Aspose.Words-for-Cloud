
package com.aspose.words.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class CommentList {

	    @SerializedName("RangeStart")
	    private RangeStart rangeStart;
	    @SerializedName("RangeEnd")
	    @Expose
	    private RangeEnd rangeEnd;
	    @SerializedName("Author")
	    @Expose
	    private String author;
	    @SerializedName("Initial")
	    @Expose
	    private String initial;
	    @SerializedName("DateTime")
	    private String dateTime;
	    @SerializedName("Text")
	    private String text;
	    @SerializedName("Content")
	    private Content content;
	    @SerializedName("link")
	    private Link link;

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

	    public String getAuthor() {
	        return author;
	    }

	    public void setAuthor(String author) {
	        this.author = author;
	    }

	    public String getInitial() {
	        return initial;
	    }

	    public void setInitial(String initial) {
	        this.initial = initial;
	    }

	    public String getDateTime() {
	        return dateTime;
	    }

	    public void setDateTime(String dateTime) {
	        this.dateTime = dateTime;
	    }

	    public String getText() {
	        return text;
	    }

	    public void setText(String text) {
	        this.text = text;
	    }

	    public Content getContent() {
	        return content;
	    }

	    public void setContent(Content content) {
	        this.content = content;
	    }

	    public Link getLink() {
	        return link;
	    }

	    public void setLink(Link link) {
	        this.link = link;
	    }
   

}
