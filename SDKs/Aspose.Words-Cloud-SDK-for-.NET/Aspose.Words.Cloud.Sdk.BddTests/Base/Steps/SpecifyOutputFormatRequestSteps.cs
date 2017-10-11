namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps to specify output format of document
    /// </summary>
    [Binding]
    public class SpecifyOutputFormatRequestSteps
    {
        private readonly BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpecifyOutputFormatRequestSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public SpecifyOutputFormatRequestSteps(BaseContext context)
        {
            this.context = context;
        }

        private ICanSpecifyOutputFormatRequest Request
        {
            get
            {
                return (ICanSpecifyOutputFormatRequest)ScenarioContext.Current["Request"];
            }
        }

        /// <summary>
        /// Sets destination format
        /// </summary>
        /// <param name="destinationFormat">format document to be converted in</param>
        [Given(@"I have specified format (.*) document to be converted")]
        public void GivenIHaveSpecifiedFormatDocumentToBeConverted(string destinationFormat)
        {
            this.Request.Format = destinationFormat;
        }

        /// <summary>
        /// Sets output name for converted document
        /// </summary>
        /// <param name="outPath">name for converted document</param>
        [Given(@"I have specified output path (.*)")]
        public void GivenIHaveSpecifiedOutputPath(string outPath)
        {
            this.Request.OutPath = this.context.TestFolderInStorage + outPath;
        }
    }
}