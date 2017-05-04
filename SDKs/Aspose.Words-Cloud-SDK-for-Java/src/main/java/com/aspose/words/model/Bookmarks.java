package com.aspose.words.model;

import java.util.ArrayList;
import java.util.List;
public class Bookmarks {
  private List<Bookmark> BookmarkList = new ArrayList<Bookmark>();
  private Link link = null;
  /**
	 * getBookmarkList
	 * Gets List<Bookmark>
	 * @return BookmarkList
	 */
  public List<Bookmark> getBookmarkList() {
    return BookmarkList;
  }

	/**
	 * setBookmarkList
	 * Sets List<Bookmark>
	 * @param BookmarkList List<Bookmark>
	 */
  public void setBookmarkList(List<Bookmark> BookmarkList) {
    this.BookmarkList = BookmarkList;
  }

  /**
	 * getLink
	 * Gets Link
	 * @return link
	 */
  public Link getLink() {
    return link;
  }

	/**
	 * setLink
	 * Sets Link
	 * @param link Link
	 */
  public void setLink(Link link) {
    this.link = link;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Bookmarks {\n");
    sb.append("  BookmarkList: ").append(BookmarkList).append("\n");
    sb.append("  link: ").append(link).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

