namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.ConversionSteps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Class with steps related to conversion with storage
    /// </summary>
    [Binding]
    public class ConversionWithStorageSteps : BaseConversionStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Aspose.Words.Cloud.Sdk.BddTests.Steps.ConversionSteps.ConversionWithStorageSteps" /> class.
        /// </summary>
        /// <param name="context">Converstion context</param>
        public ConversionWithStorageSteps(ConversionContext context) : base(context)
        {
        }

        /// <summary>
        /// Sets output name for converted document
        /// </summary>
        /// <param name="outPath">name for converted document</param>
        [Given(@"I have specified output path (.*)")]
        public void GivenIHaveSpecifiedOutputPath(string outPath)
        {
            this.Context.OutPath = outPath;
        }
        
        /// <summary>
        /// Saves converted document to storage
        /// </summary>
        [Then(@"converted document is saved to storage")]
        public void ThenConvertedDocumentIsSavedToStorage()
        {
            this.Context.SaveConvertedDocumentToStorage();
        }

        /// <summary>
        /// Checks document exisits on storage
        /// </summary>
        /// <param name="fileName">document name</param>
        [Then(@"its filename is (.*)")]
        public void ThenItsFilenameIs(string fileName)
        {
            var isExists = this.Context.FileWithNameExists(fileName);
            Assert.IsNotNull(isExists);
            Assert.IsTrue(isExists.Value);
        }
    }
}
