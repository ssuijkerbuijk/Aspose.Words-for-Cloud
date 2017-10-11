namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.GetAlternateDocument.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

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

        private GetDocumentWithFormatRequest Request
        {
            get
            {
                return ScenarioContext.Current["Request"] as GetDocumentWithFormatRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("ConversionOfStoredDoc")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new GetDocumentWithFormatRequest();
        }

        /// <summary>
        /// Executes conversion from storage
        /// </summary>
        [When(@"I execute conversion from storage")]
        public void WhenIExecuteConversionFromStorage()
        {
            this.Request.Folder = this.context.TestFolderInStorage;
            this.context.Response = this.context.WordsApi.GetDocumentWithFormat(this.Request);
        }
    }
}
