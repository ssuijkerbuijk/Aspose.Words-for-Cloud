namespace Aspose.Words.Cloud.Sdk.Requests
{
    /// <summary>
    /// Request which can save revisions in document.
    /// </summary>
    public interface ICanSaveRevisionRequest
    {
        /// <summary>
        /// Initials of the author to use for revisions.If you set this parameter and then make some changes to the document programmatically, save the document and later open the document in MS Word you will see these changes as revisions.
        /// </summary>  
        string RevisionAuthor { get; set; }

        /// <summary>
        /// The date and time to use for revisions.
        /// </summary>  
        string RevisionDateTime { get; set; }
    }
}