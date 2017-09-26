namespace Aspose.Words.Cloud.Sdk.Requests
{
    /// <summary>
    /// Request for operation with word document.
    /// </summary>
    public interface IWordDocumentRequest
    {
        /// <summary>
        /// The document name.
        /// </summary>  
        string Name { get; set; }
        
        /// <summary>
        /// File storage, which have to be used.
        /// </summary>  
        string Storage { get; set; }

        /// <summary>
        /// Original document folder.
        /// </summary>  
        string Folder { get; set; }

        /// <summary>
        /// Encoding that will be used to load an HTML (or TXT) document if the encoding is not specified in HTML.
        /// </summary>  
        string LoadEncoding { get; set; }

        /// <summary>
        /// Password for opening an encrypted document.
        /// </summary>  
        string Password { get; set; }
    }
}