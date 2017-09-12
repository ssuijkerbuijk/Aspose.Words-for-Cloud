namespace Aspose.Words.Cloud.Sdk.Model 
{
  using System;
  using System.Text;
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// container class for details of digital signature
  /// </summary>  
  public class PdfDigitalSignatureDetailsData 
  {                       
        /// <summary>
        /// certificate's filename using for signing
        /// </summary>  
        public string CertificateFilename { get; set; }

        /// <summary>
        /// hash algorithm
        /// </summary>  
        public string HashAlgorithm { get; set; }

        /// <summary>
        /// location of the signing
        /// </summary>  
        public string Location { get; set; }

        /// <summary>
        /// reason for the signing
        /// </summary>  
        public string Reason { get; set; }

        /// <summary>
        /// date of the signing
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
          sb.Append("  CertificateFilename: ").Append(this.CertificateFilename).Append("\n");
          sb.Append("  HashAlgorithm: ").Append(this.HashAlgorithm).Append("\n");
          sb.Append("  Location: ").Append(this.Location).Append("\n");
          sb.Append("  Reason: ").Append(this.Reason).Append("\n");
          sb.Append("  SignatureDate: ").Append(this.SignatureDate).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
