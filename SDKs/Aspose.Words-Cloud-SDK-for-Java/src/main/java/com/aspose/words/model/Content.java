
package com.aspose.words.model;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Content {

    private List<ChildNode> childNodes = null;
    private Map<String, Object> additionalProperties = new HashMap<String, Object>();

    public List<ChildNode> getChildNodes() {
        return childNodes;
    }

    public void setChildNodes(List<ChildNode> childNodes) {
        this.childNodes = childNodes;
    }

    public Map<String, Object> getAdditionalProperties() {
        return this.additionalProperties;
    }

    public void setAdditionalProperty(String name, Object value) {
        this.additionalProperties.put(name, value);
    }

}
