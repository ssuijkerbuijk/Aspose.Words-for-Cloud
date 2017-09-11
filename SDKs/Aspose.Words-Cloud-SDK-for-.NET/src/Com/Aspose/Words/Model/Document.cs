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
  /// Represents Words document DTO.
  /// </summary>  
  public class Document 
  {                       
        /// <summary>
        /// Gets the original format of the document.
        /// </summary>
        /// <value>Gets the original format of the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceFormatEnum
        {
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>            
            Unknown,
            
            /// <summary>
            /// Enum Doc for "Doc"
            /// </summary>            
            Doc,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>            
            Dot,
            
            /// <summary>
            /// Enum DocPreWord60 for "DocPreWord60"
            /// </summary>            
            DocPreWord60,
            
            /// <summary>
            /// Enum Docx for "Docx"
            /// </summary>            
            Docx,
            
            /// <summary>
            /// Enum Docm for "Docm"
            /// </summary>            
            Docm,
            
            /// <summary>
            /// Enum Dotx for "Dotx"
            /// </summary>            
            Dotx,
            
            /// <summary>
            /// Enum Dotm for "Dotm"
            /// </summary>            
            Dotm,
            
            /// <summary>
            /// Enum FlatOpc for "FlatOpc"
            /// </summary>            
            FlatOpc,
            
            /// <summary>
            /// Enum Rtf for "Rtf"
            /// </summary>            
            Rtf,
            
            /// <summary>
            /// Enum WordML for "WordML"
            /// </summary>            
            WordML,
            
            /// <summary>
            /// Enum Html for "Html"
            /// </summary>            
            Html,
            
            /// <summary>
            /// Enum Mhtml for "Mhtml"
            /// </summary>            
            Mhtml,
            
            /// <summary>
            /// Enum Epub for "Epub"
            /// </summary>            
            Epub,
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text,
            
            /// <summary>
            /// Enum Odt for "Odt"
            /// </summary>            
            Odt,
            
            /// <summary>
            /// Enum Ott for "Ott"
            /// </summary>            
            Ott,
            
            /// <summary>
            /// Enum Pdf for "Pdf"
            /// </summary>            
            Pdf,
            
            /// <summary>
            /// Enum Xps for "Xps"
            /// </summary>            
            Xps,
            
            /// <summary>
            /// Enum Swf for "Swf"
            /// </summary>            
            Swf,
            
            /// <summary>
            /// Enum Tiff for "Tiff"
            /// </summary>            
            Tiff,
            
            /// <summary>
            /// Enum Svg for "Svg"
            /// </summary>            
            Svg
        }

        /// <summary>
        /// Gets the original format of the document.
        /// </summary>
        /// <value>Gets the original format of the document.</value>
        public SourceFormatEnum? SourceFormat { get; set; }

        /// <summary>
        /// A list of links that originate from this document.
        /// </summary>
        /// <value>A list of links that originate from this document.</value>    
        public List<Link> Links { get; set; }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>Gets the name of the file.</value>    
        public string FileName { get; set; }

        /// <summary>
        /// Returns true if the document is encrypted and requires a password to open.
        /// </summary>
        /// <value>Returns true if the document is encrypted and requires a password to open.</value>    
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Returns true if the document contains a digital signature. This property merely informs that a   digital signature is present on a document, but it does not specify whether the signature is valid or not.
        /// </summary>
        /// <value>Returns true if the document contains a digital signature. This property merely informs that a   digital signature is present on a document, but it does not specify whether the signature is valid or not.</value>    
        public bool? IsSigned { get; set; }

        /// <summary>
        /// Returns document properties.
        /// </summary>
        /// <value>Returns document properties.</value>    
        public DocumentProperties DocumentProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Document {\n");
          sb.Append("  Links: ").Append(Links).Append("\n");
          sb.Append("  FileName: ").Append(FileName).Append("\n");
          sb.Append("  SourceFormat: ").Append(SourceFormat).Append("\n");
          sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
          sb.Append("  IsSigned: ").Append(IsSigned).Append("\n");
          sb.Append("  DocumentProperties: ").Append(DocumentProperties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
