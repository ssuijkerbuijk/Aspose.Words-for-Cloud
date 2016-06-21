package com.aspose.words.model;

import java.util.*;
public class DocumentEntryList {
  private List<DocumentEntry> DocumentEntries = new ArrayList<DocumentEntry>();
  /**
	 * getDocumentEntries
	 * Gets List<DocumentEntry>
	 * @return DocumentEntries
	 */
  public List<DocumentEntry> getDocumentEntries() {
    return DocumentEntries;
  }

	/**
	 * setDocumentEntries
	 * Sets List<DocumentEntry>
	 * @param DocumentEntries List<DocumentEntry>
	 */
  public void setDocumentEntries(List<DocumentEntry> DocumentEntries) {
    this.DocumentEntries = DocumentEntries;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocumentEntryList {\n");
    sb.append("  DocumentEntries: ").append(DocumentEntries).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

