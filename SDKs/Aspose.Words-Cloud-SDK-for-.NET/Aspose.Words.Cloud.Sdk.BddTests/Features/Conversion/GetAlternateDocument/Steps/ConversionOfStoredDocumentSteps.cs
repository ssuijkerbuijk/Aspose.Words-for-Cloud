namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.GetAlternateDocument.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    
    using TechTalk.SpecFlow;

    /// <summary>
    /// Class contains steps related to document conversion of stored document
    /// </summary>
    [Binding]
    public class GetAlternateDocumentSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlternateDocumentSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        public GetAlternateDocumentSteps(BaseContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Executes conversion from storage
        /// </summary>
        [When(@"I execute conversion from storage")]
        public void WhenIExecuteConversionFromStorage()
        {
            ////var fullPath = this.Context.Folder + this.Context.FileName;
            ////var resp = this.StorageApi.GetDownload(fullPath, null, null);
            // TODO: change request to http://auckland.dynabic.com/wiki/display/words/document
            ////var request = new PutConvertDocumentRequest(this.OutputFormat, new MemoryStream(resp.ResponseStream));
            ////this.ConvertedDocument =
            ////    (MemoryStream)this.MethodsApi.PutConvertDocument(request);
        }
    }
}
