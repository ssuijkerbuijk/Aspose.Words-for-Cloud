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
  /// container class for details of digital signature
  /// </summary>  
  public class PdfDigitalSignatureDetailsData 
  {                       
        /// <summary>
        /// certificate's filename using for signing
        /// </summary>
        /// <value>certificate's filename using for signing</value>    
        public string CertificateFilename { get; set; }

        /// <summary>
        /// hash algorithm
        /// </summary>
        /// <value>hash algorithm</value>    
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// location of the signing
        /// </summary>
        /// <value>location of the signing</value>    
        public string Location { get; set; }

        /// <summary>
        /// reason for the signing
        /// </summary>
        /// <value>reason for the signing</value>    
        public string Reason { get; set; }

        /// <summary>
        /// date of the signing
        /// </summary>
        /// <value>date of the signing</value>    
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
