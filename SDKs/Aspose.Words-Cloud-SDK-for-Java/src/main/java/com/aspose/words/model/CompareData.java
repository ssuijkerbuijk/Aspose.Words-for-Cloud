package com.aspose.words.model;

import com.google.gson.annotations.SerializedName;

public class CompareData {
	@SerializedName("ComparingWithDocument")
	String ComparingWithDocument;
	@SerializedName("Author")
	String Author;
	@SerializedName("DateTime")
	String DateTime;

	public String getComparingWithDocument() {
		return ComparingWithDocument;
	}

	public void setComparingWithDocument(String comparingWithDocument) {
		ComparingWithDocument = comparingWithDocument;
	}

	public String getAuthor() {
		return Author;
	}

	public void setAuthor(String author) {
		Author = author;
	}

	public String getDateTime() {
		return DateTime;
	}

	public void setDateTime(String dateTime) {
		DateTime = dateTime;
	}

}