namespace Aspose.Words.Cloud.Sdk.Requests
{
    /// <summary>
    /// Request with format of output document
    /// </summary>
    public interface ICanSpecifyFormatRequest
    {
        /// <summary>
        /// Sets the output format for convert and split operations
        /// </summary>
        string Format { get; set; }

        /// <summary>
        /// Sets the ouput path for converted document
        /// </summary>
        string OutPath { get; set; }
    }
}