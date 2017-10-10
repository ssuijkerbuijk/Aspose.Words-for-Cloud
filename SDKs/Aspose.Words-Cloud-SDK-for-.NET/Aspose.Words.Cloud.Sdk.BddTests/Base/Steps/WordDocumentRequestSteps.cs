namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for working with <see cref="IWordDocumentRequest"/>.
    /// </summary>
    [Binding]
    public class WordDocumentRequestSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WordDocumentRequestSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected WordDocumentRequestSteps(BaseContext context)
        {
            this.context = context;
        }

        private IWordDocumentRequest Request
        {
            get
            {             
                return ScenarioContext.Current["Request"] as IWordDocumentRequest;
            }
        }

        /// <summary>
        /// Sets document name we would like to use.
        /// </summary>
        /// <param name="fileName">document name</param>
        [Given(@"I have specified document name (.*) in URL")]
        public void GivenIHaveSpecifiedDocumentNameInUrl(string fileName)
        {
            this.Request.Name = fileName;
        }
    }
}