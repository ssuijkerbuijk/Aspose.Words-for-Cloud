package com.aspose.words.model;

import java.util.*;

import com.aspose.words.model.Link;
public class DrawingObject {
  private List<Link> RenderLinks = new ArrayList<Link>();
  private Double Width = null;
  private Double Height = null;
  private Link OleDataLink = null;
  private Link ImageDataLink = null;
  private Link link = null;
  
  /**
	 * getList
	 * Gets List<Link>
	 * @return List
	 */
  public List<Link> getList() {
    return RenderLinks;
  }

	/**
	 * setList
	 * Sets List<LinkElement>
	 * @param List List<LinkElement>
	 */
  public void setList(List<Link> List) {
    this.RenderLinks = List;
  }

  
  public Double getWidth() {
                return Width;
        }

        public void setWidth(Double width) {
                Width = width;
        }

        public Double getHeight() {
                return Height;
        }

        public void setHeight(Double height) {
                Height = height;
        }

        public Link getOleDataLink() {
                return OleDataLink;
        }

        public void setOleDataLink(Link oleDataLink) {
                OleDataLink = oleDataLink;
        }

        public Link getImageDataLink() {
                return ImageDataLink;
        }

        public void setImageDataLink(Link imageDataLink) {
                ImageDataLink = imageDataLink;
        }

        public Link getLink() {
                return link;
        }

        public void setLink(Link link) {
                this.link = link;
        }

@Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class DrawingObject {\n");
    sb.append("  List: ").append(RenderLinks).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}

