namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.ConversionSteps
{
    using System;

    using Aspose.Words.Cloud.Sdk.BddTests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Class with steps for On Fly Conversion
    /// </summary>
    [Binding]
    public class OnFlyConversionSteps : BaseConversionStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnFlyConversionSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        public OnFlyConversionSteps(ConversionContext context) : base(context)
        {
        }

        /// <summary>
        /// Sets the name of document
        /// </summary>
        /// <param name="documentName">name of document</param>
        [Given(@"I have specified document name is (.*)")]
        public void GivenIHaveSpecifiedDocumentName(string documentName)
        {
            this.Context.FileName = documentName;
        }
        
        /// <summary>
        /// Sets destination format
        /// </summary>
        /// <param name="destinationFormat">format document to be converted in</param>
        [Given(@"I have specified format (.*) document to be converted")]
        public void GivenIHaveSpecifiedFormatDocumentToBeConverted(string destinationFormat)
        {
            this.Context.OutputFormat = destinationFormat;
        }

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion")]
        public void WhenIExecuteConversion()
        {
            this.Context.ConvertDocumentFormAttachment();
        }

        /// <summary>
        /// Asserts document has been converted successfully
        /// </summary>
        [Then(@"document has to be returned as an attachment")]
        public void ThenDocumentHasToBeReturnedAsAnAttachment()
        {
            Assert.IsNotNull(this.Context.ConvertedDocument);
        }
        
        /// <summary>
        /// Checks output format
        /// </summary>
        /// <param name="outFormat">output format</param>
        [Then(@"its format (.*)")]
        public void ThenItsFormat(string outFormat)
        {
            if (outFormat == "pdf")
            {
                byte[] pdfHeader = new byte[10];
                this.Context.ConvertedDocument.Position = 0;
                this.Context.ConvertedDocument.Read(pdfHeader, 0, pdfHeader.Length);
                Assert.AreEqual('%', Convert.ToChar(pdfHeader[0]));
                Assert.AreEqual('P', Convert.ToChar(pdfHeader[1]));
                Assert.AreEqual('D', Convert.ToChar(pdfHeader[2]));
                Assert.AreEqual('F', Convert.ToChar(pdfHeader[3]));
            }
            
            Assert.IsNotNull(this.Context.ConvertedDocument);
            Assert.AreNotEqual(0, this.Context.ConvertedDocument.Length);
        }
    }
}
