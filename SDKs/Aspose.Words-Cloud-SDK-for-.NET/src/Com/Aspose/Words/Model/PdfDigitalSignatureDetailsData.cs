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
  /// 
  /// </summary>  
  public class PdfDigitalSignatureDetailsData 
  {                       
        /// <summary>
        /// Gets or sets CertificateFilename
        /// </summary>    
        public string CertificateFilename { get; set; }

        /// <summary>
        /// Gets or sets HashAlgorithm
        /// </summary>    
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets Location
        /// </summary>    
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets Reason
        /// </summary>    
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets SignatureDate
        /// </summary>    
        public DateTime? SignatureDate { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfDigitalSignatureDetailsData {\n");
          sb.Append("  CertificateFilename: ").Append(CertificateFilename).Append("\n");
          sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
          sb.Append("  Location: ").Append(Location).Append("\n");
          sb.Append("  Reason: ").Append(Reason).Append("\n");
          sb.Append("  SignatureDate: ").Append(SignatureDate).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
