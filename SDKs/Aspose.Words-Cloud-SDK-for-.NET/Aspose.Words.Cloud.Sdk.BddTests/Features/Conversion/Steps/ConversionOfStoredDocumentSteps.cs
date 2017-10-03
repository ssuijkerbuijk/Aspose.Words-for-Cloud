namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.Steps
{
    using TechTalk.SpecFlow;

    /// <summary>
    /// Class contains steps related to document conversion of stored document
    /// </summary>
    [Binding]
    public class ConversionOfStoredDocumentSteps : BaseConversionStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionOfStoredDocumentSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        public ConversionOfStoredDocumentSteps(ConversionContext context) : base(context)
        {
        }

        /// <summary>
        /// Uploads specified document to storage
        /// </summary>
        /// <param name="fileName">document name</param>
        [Given(@"I have uploaded document with name (.*) to storage")]
        public void GivenIHaveUploadedDocumentWithNameToStorage(string fileName)
        {
            this.Context.FileName = fileName;
            this.Context.UploadDocumentToStorage();
        }
        
        /// <summary>
        /// Sets document name we would like to get
        /// </summary>
        /// <param name="fileName">document name</param>
        [Given(@"I have specified document name (.*) in GET URL")]
        public void GivenIHaveSpecifiedDocumentNameInGetUrl(string fileName)
        {
            this.Context.FileName = fileName;
        }
        
        /// <summary>
        /// Executes conversion from storage
        /// </summary>
        [When(@"I execute conversion from storage")]
        public void WhenIExecuteConversionFromStorage()
        {
            this.Context.ConvertDocumentFromStorage(this.Context.FileName);
        }
    }
}
