namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.SaveAs
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for SaveUs feature
    /// </summary>
    [Binding]
    public class SaveAsSteps
    {
        private BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public SaveAsSteps(BaseContext context)
        {
            this.context = context;
        }

        private MemoryStream File
        {
            get { return this.context.Response as MemoryStream; }
        }

        private PostDocumentSaveAsRequest Request
        {
            get
            {
                return (PostDocumentSaveAsRequest)ScenarioContext.Current["Request"];
            }
        }


        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("StoredDocConversionWithStorage", "ConversionPdfToWord")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PostDocumentSaveAsRequest();
        }

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion from storage \(POST SaveAs\)")]
        public void WhenIExecuteConversion()
        {
            this.context.Response = this.context.WordsApi.PostDocumentSaveAs(this.Request);
        }        

        /// <summary>
        /// Checks that document converted properly
        /// </summary>
        [Then(@"symbols are encoded properly")]
        public void ThenSymbolsAreEncodedProperly()
        {
            this.File.Position = 0;
            var formatInfo = FileFormatUtil.DetectFileFormat(this.File);
            if (formatInfo.LoadFormat != LoadFormat.Unknown && formatInfo.Encoding != null)
            {
                Assert.IsTrue(formatInfo.Encoding.BodyName == this.Request.LoadEncoding);
            }
        }        
    }
}