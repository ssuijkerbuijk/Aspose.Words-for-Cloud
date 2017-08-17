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
  public class SectionPageSetupResponse 
  {           
        /// <summary>
        /// Initializes a new instance of the <see cref="SectionPageSetupResponse" /> class.
        /// </summary>
        /// <param name="PageSetup">PageSetup.</param>
        /// <param name="Code">Code.</param>
        /// <param name="Status">Status.</param>
        public SectionPageSetupResponse(PageSetup PageSetup = default(PageSetup), CodeEnum? Code = default(CodeEnum?), string Status = default(string))
        {
                        this.PageSetup = PageSetup;
                        this.Code = Code;
                        this.Status = Status;
        }

        /// <summary>
        /// Gets or sets Code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            
            /// <summary>
            /// Enum Continue for "Continue"
            /// </summary>            
            Continue,
            
            /// <summary>
            /// Enum SwitchingProtocols for "SwitchingProtocols"
            /// </summary>            
            SwitchingProtocols,
            
            /// <summary>
            /// Enum OK for "OK"
            /// </summary>            
            OK,
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>            
            Created,
            
            /// <summary>
            /// Enum Accepted for "Accepted"
            /// </summary>            
            Accepted,
            
            /// <summary>
            /// Enum NonAuthoritativeInformation for "NonAuthoritativeInformation"
            /// </summary>            
            NonAuthoritativeInformation,
            
            /// <summary>
            /// Enum NoContent for "NoContent"
            /// </summary>            
            NoContent,
            
            /// <summary>
            /// Enum ResetContent for "ResetContent"
            /// </summary>            
            ResetContent,
            
            /// <summary>
            /// Enum PartialContent for "PartialContent"
            /// </summary>            
            PartialContent,
            
            /// <summary>
            /// Enum MultipleChoices for "MultipleChoices"
            /// </summary>            
            MultipleChoices,
            
            /// <summary>
            /// Enum Ambiguous for "Ambiguous"
            /// </summary>            
            Ambiguous,
            
            /// <summary>
            /// Enum MovedPermanently for "MovedPermanently"
            /// </summary>            
            MovedPermanently,
            
            /// <summary>
            /// Enum Moved for "Moved"
            /// </summary>            
            Moved,
            
            /// <summary>
            /// Enum Found for "Found"
            /// </summary>            
            Found,
            
            /// <summary>
            /// Enum Redirect for "Redirect"
            /// </summary>            
            Redirect,
            
            /// <summary>
            /// Enum SeeOther for "SeeOther"
            /// </summary>            
            SeeOther,
            
            /// <summary>
            /// Enum RedirectMethod for "RedirectMethod"
            /// </summary>            
            RedirectMethod,
            
            /// <summary>
            /// Enum NotModified for "NotModified"
            /// </summary>            
            NotModified,
            
            /// <summary>
            /// Enum UseProxy for "UseProxy"
            /// </summary>            
            UseProxy,
            
            /// <summary>
            /// Enum Unused for "Unused"
            /// </summary>            
            Unused,
            
            /// <summary>
            /// Enum TemporaryRedirect for "TemporaryRedirect"
            /// </summary>            
            TemporaryRedirect,
            
            /// <summary>
            /// Enum RedirectKeepVerb for "RedirectKeepVerb"
            /// </summary>            
            RedirectKeepVerb,
            
            /// <summary>
            /// Enum BadRequest for "BadRequest"
            /// </summary>            
            BadRequest,
            
            /// <summary>
            /// Enum Unauthorized for "Unauthorized"
            /// </summary>            
            Unauthorized,
            
            /// <summary>
            /// Enum PaymentRequired for "PaymentRequired"
            /// </summary>            
            PaymentRequired,
            
            /// <summary>
            /// Enum Forbidden for "Forbidden"
            /// </summary>            
            Forbidden,
            
            /// <summary>
            /// Enum NotFound for "NotFound"
            /// </summary>            
            NotFound,
            
            /// <summary>
            /// Enum MethodNotAllowed for "MethodNotAllowed"
            /// </summary>            
            MethodNotAllowed,
            
            /// <summary>
            /// Enum NotAcceptable for "NotAcceptable"
            /// </summary>            
            NotAcceptable,
            
            /// <summary>
            /// Enum ProxyAuthenticationRequired for "ProxyAuthenticationRequired"
            /// </summary>            
            ProxyAuthenticationRequired,
            
            /// <summary>
            /// Enum RequestTimeout for "RequestTimeout"
            /// </summary>            
            RequestTimeout,
            
            /// <summary>
            /// Enum Conflict for "Conflict"
            /// </summary>            
            Conflict,
            
            /// <summary>
            /// Enum Gone for "Gone"
            /// </summary>            
            Gone,
            
            /// <summary>
            /// Enum LengthRequired for "LengthRequired"
            /// </summary>            
            LengthRequired,
            
            /// <summary>
            /// Enum PreconditionFailed for "PreconditionFailed"
            /// </summary>            
            PreconditionFailed,
            
            /// <summary>
            /// Enum RequestEntityTooLarge for "RequestEntityTooLarge"
            /// </summary>            
            RequestEntityTooLarge,
            
            /// <summary>
            /// Enum RequestUriTooLong for "RequestUriTooLong"
            /// </summary>            
            RequestUriTooLong,
            
            /// <summary>
            /// Enum UnsupportedMediaType for "UnsupportedMediaType"
            /// </summary>            
            UnsupportedMediaType,
            
            /// <summary>
            /// Enum RequestedRangeNotSatisfiable for "RequestedRangeNotSatisfiable"
            /// </summary>            
            RequestedRangeNotSatisfiable,
            
            /// <summary>
            /// Enum ExpectationFailed for "ExpectationFailed"
            /// </summary>            
            ExpectationFailed,
            
            /// <summary>
            /// Enum UpgradeRequired for "UpgradeRequired"
            /// </summary>            
            UpgradeRequired,
            
            /// <summary>
            /// Enum InternalServerError for "InternalServerError"
            /// </summary>            
            InternalServerError,
            
            /// <summary>
            /// Enum NotImplemented for "NotImplemented"
            /// </summary>            
            NotImplemented,
            
            /// <summary>
            /// Enum BadGateway for "BadGateway"
            /// </summary>            
            BadGateway,
            
            /// <summary>
            /// Enum ServiceUnavailable for "ServiceUnavailable"
            /// </summary>            
            ServiceUnavailable,
            
            /// <summary>
            /// Enum GatewayTimeout for "GatewayTimeout"
            /// </summary>            
            GatewayTimeout,
            
            /// <summary>
            /// Enum HttpVersionNotSupported for "HttpVersionNotSupported"
            /// </summary>            
            HttpVersionNotSupported
        }

        /// <summary>
        /// Gets or sets Code
        /// </summary>
        public CodeEnum? Code { get; set; }

        /// <summary>
        /// Gets or sets PageSetup
        /// </summary>    
        public PageSetup PageSetup { get; set; }

        /// <summary>
        /// Gets or sets Status
        /// </summary>    
        public string Status { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SectionPageSetupResponse {\n");
          sb.Append("  PageSetup: ").Append(PageSetup).Append("\n");
          sb.Append("  Code: ").Append(Code).Append("\n");
          sb.Append("  Status: ").Append(Status).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
