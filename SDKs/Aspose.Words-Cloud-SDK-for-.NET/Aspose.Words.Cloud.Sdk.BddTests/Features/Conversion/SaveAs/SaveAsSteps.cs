namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.SaveAs
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Requests;

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
        [BeforeScenario("StoredDocConversionWithStorage", "ConversionPdfToWord")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new GetDocumentWithFormatRequest();
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


        /// <summary>
        /// Sets encoding for conversion
        /// </summary>
        /// <param name="encoding">encoding</param>
        [Given(@"I have specified encoding (.*)")]
        public void GivenIHaveSpecifiedEncoding(string encoding)
        {
            this.Request.LoadEncoding = encoding;
        }
    }
}