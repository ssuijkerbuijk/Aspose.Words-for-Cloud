namespace Aspose.Words.Cloud.Sdk.Requests
{
    /// <summary>
    /// Request which can modify document.
    /// </summary>
    public interface ICanModifyDocumentRequest
    {
        /// <summary>
        /// Result name of the document after the operation. If this parameter is omitted then result of the operation will be saved as the source document.
        /// </summary>  
        string DestFileName { get; set; }
    }
}