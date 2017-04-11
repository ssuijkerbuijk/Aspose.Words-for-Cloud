package com.aspose.words.model;

import com.aspose.words.model.Link;
public class ModificationOperationResult {
  private Link Source = null;
  private Link Dest = null;
  /**
	 * getSource
	 * Gets Link
	 * @return Source
	 */
  public Link getSource() {
    return Source;
  }

	/**
	 * setSource
	 * Sets Link
	 * @param Source Link
	 */
  public void setSource(Link Source) {
    this.Source = Source;
  }

  /**
	 * getDest
	 * Gets Link
	 * @return Dest
	 */
  public Link getDest() {
    return Dest;
  }

	/**
	 * setDest
	 * Sets Link
	 * @param Dest Link
	 */
  public void setDest(Link Dest) {
    this.Dest = Dest;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class ModificationOperationResult {\n");
    sb.append("  Source: ").append(Source).append("\n");
    sb.append("  Dest: ").append(Dest).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

