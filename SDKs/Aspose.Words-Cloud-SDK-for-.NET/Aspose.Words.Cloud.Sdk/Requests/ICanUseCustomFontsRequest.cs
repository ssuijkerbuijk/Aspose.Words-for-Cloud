namespace Aspose.Words.Cloud.Sdk.Requests
{
    /// <summary>
    /// Request which can use custom fonts.
    /// </summary>
    public interface ICanUseCustomFontsRequest
    {
        /// <summary>
        /// Folder in filestorage with custom fonts.
        /// </summary>  
        string FontsLocation { get; set; }
    }
}