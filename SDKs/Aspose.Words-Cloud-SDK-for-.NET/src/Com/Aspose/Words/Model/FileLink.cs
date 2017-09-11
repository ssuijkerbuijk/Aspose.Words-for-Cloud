using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// Provides information for the file link.
  /// </summary>  
  public class FileLink 
  {                       
        /// <summary>
        /// The \"href\" attribute contains the link's IRI. atom:link elements MUST  have an href attribute, whose value MUST be a IRI reference
        /// </summary>
        /// <value>The \"href\" attribute contains the link's IRI. atom:link elements MUST  have an href attribute, whose value MUST be a IRI reference</value>    
        public string Href { get; set; }

        /// <summary>
        /// atom:link elements MAY have a \"rel\" attribute that indicates the link  relation type.  If the \"rel\" attribute is not present, the link  element MUST be interpreted as if the link relation type is \"alternate\".
        /// </summary>
        /// <value>atom:link elements MAY have a \"rel\" attribute that indicates the link  relation type.  If the \"rel\" attribute is not present, the link  element MUST be interpreted as if the link relation type is \"alternate\".</value>    
        public string Rel { get; set; }

        /// <summary>
        /// On the link element, the \"type\" attribute's value is an advisory  media type: it is a hint about the type of the representation that is  expected to be returned when the value of the href attribute is  dereferenced.  Note that the type attribute does not override the  actual media type returned with the representation.
        /// </summary>
        /// <value>On the link element, the \"type\" attribute's value is an advisory  media type: it is a hint about the type of the representation that is  expected to be returned when the value of the href attribute is  dereferenced.  Note that the type attribute does not override the  actual media type returned with the representation.</value>    
        public string Type { get; set; }

        /// <summary>
        /// The \"title\" attribute conveys human-readable information about the  link.  The content of the \"title\" attribute is Language-Sensitive.
        /// </summary>
        /// <value>The \"title\" attribute conveys human-readable information about the  link.  The content of the \"title\" attribute is Language-Sensitive.</value>    
        public string Title { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class FileLink {\n");
          sb.Append("  Href: ").Append(Href).Append("\n");
          sb.Append("  Rel: ").Append(Rel).Append("\n");
          sb.Append("  Type: ").Append(Type).Append("\n");
          sb.Append("  Title: ").Append(Title).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
