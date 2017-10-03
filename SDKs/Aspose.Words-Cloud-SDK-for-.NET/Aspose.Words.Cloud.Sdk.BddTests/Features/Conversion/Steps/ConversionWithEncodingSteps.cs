namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.Steps
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Class contains steps related to document conversion with encoding
    /// </summary>
    [Binding]
    public class ConversionWithEncodingSteps : BaseConversionStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionWithEncodingSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        public ConversionWithEncodingSteps(ConversionContext context) : base(context)
        {
        }

        /// <summary>
        /// Sets encoding for conversion
        /// </summary>
        /// <param name="encoding">encoding</param>
        [Given(@"I have specified encoding (.*)")]
        public void GivenIHaveSpecifiedEncoding(string encoding)
        {
            this.Context.LoadEncoding = encoding;
        }
        
        /// <summary>
        /// Executes conversion with encoding
        /// </summary>
        [When(@"I execute conversion with encoding")]
        public void WhenIExecuteConversionWithEncoding()
        {
            this.Context.ConversionWithEncoding();
        }
        
        /// <summary>
        /// Checks that document converted properly
        /// </summary>
        [Then(@"symbols are encoded properly")]
        public void ThenSymbolsAreEncodedProperly()
        {
            Assert.IsNotNull(this.Context.ConvertedDocument);
        }
    }
}
