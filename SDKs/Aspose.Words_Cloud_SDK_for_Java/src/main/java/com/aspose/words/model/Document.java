package com.aspose.words.model;

import java.util.*;
import com.aspose.words.model.DocumentFormat;
import com.aspose.words.model.DocumentProperties;
public class Document {
  private List<Link> Links = new ArrayList<Link>();
  private String FileName = null;
  private Integer SourceFormat = null;
  private Boolean IsEncrypted = null;
  private Boolean IsSigned = null;
  private DocumentProperties DocumentProperties = null;
  /**
	 * getLinks
	 * Gets List<Link>
	 * @return Links
	 */
  public List<Link> getLinks() {
    return Links;
  }

	/**
	 * setLinks
	 * Sets List<Link>
	 * @param Links List<Link>
	 */
  public void setLinks(List<Link> Links) {
    this.Links = Links;
  }

  /**
	 * getFileName
	 * Gets String
	 * @return FileName
	 */
  public String getFileName() {
    return FileName;
  }

	/**
	 * setFileName
	 * Sets String
	 * @param FileName String
	 */
  public void setFileName(String FileName) {
    this.FileName = FileName;
  }

  /**
	 * getSourceFormat
	 * Gets Integer
	 * @return SourceFormat
	 */
  public Integer getSourceFormat() {
    return SourceFormat;
  }

	/**
	 * setSourceFormat
	 * Sets DocumentFormat
	 * @param SourceFormat Integer
	 */
  public void setSourceFormat(Integer SourceFormat) {
    this.SourceFormat = SourceFormat;
  }

  /**
	 * getIsEncrypted
	 * Gets Boolean
	 * @return IsEncrypted
	 */
  public Boolean getIsEncrypted() {
    return IsEncrypted;
  }

	/**
	 * setIsEncrypted
	 * Sets Boolean
	 * @param IsEncrypted Boolean
	 */
  public void setIsEncrypted(Boolean IsEncrypted) {
    this.IsEncrypted = IsEncrypted;
  }

  /**
	 * getIsSigned
	 * Gets Boolean
	 * @return IsSigned
	 */
  public Boolean getIsSigned() {
    return IsSigned;
  }

	/**
	 * setIsSigned
	 * Sets Boolean
	 * @param IsSigned Boolean
	 */
  public void setIsSigned(Boolean IsSigned) {
    this.IsSigned = IsSigned;
  }

  /**
	 * getDocumentProperties
	 * Gets DocumentProperties
	 * @return DocumentProperties
	 */
  public DocumentProperties getDocumentProperties() {
    return DocumentProperties;
  }

	/**
	 * setDocumentProperties
	 * Sets DocumentProperties
	 * @param DocumentProperties DocumentProperties
	 */
  public void setDocumentProperties(DocumentProperties DocumentProperties) {
    this.DocumentProperties = DocumentProperties;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class Document {\n");
    sb.append("  Links: ").append(Links).append("\n");
    sb.append("  FileName: ").append(FileName).append("\n");
    sb.append("  SourceFormat: ").append(SourceFormat).append("\n");
    sb.append("  IsEncrypted: ").append(IsEncrypted).append("\n");
    sb.append("  IsSigned: ").append(IsSigned).append("\n");
    sb.append("  DocumentProperties: ").append(DocumentProperties).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

