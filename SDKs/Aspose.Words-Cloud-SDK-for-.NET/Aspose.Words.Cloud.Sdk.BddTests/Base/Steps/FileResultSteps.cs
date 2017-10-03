namespace Aspose.Words.Cloud.Sdk.BddTests.Base.Steps
{
    using System;
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for working with "File results".
    /// </summary>
    [Binding]
    public class FileResultSteps
    {
        private readonly MemoryStream fileResult;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResultSteps"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected FileResultSteps(BaseContext context)
        {           
            this.fileResult = context.Response as MemoryStream;            
        }

        /// <summary>
        /// Asserts document has been converted successfully
        /// </summary>
        [Then(@"document is returned as an attachment")]
        public void ThenDocumentHasToBeReturnedAsAnAttachment()
        {
            Assert.IsNotNull(this.fileResult);
        }

        /// <summary>
        /// Checks output format
        /// </summary>
        /// <param name="format">output format</param>
        [Then(@"attachment's format is (.*)")]
        public void ThenItsFormat(string format)
        {
            var attachment = this.fileResult;
            if (attachment == null)
            {
                throw new Exception("MemoryStream is expected in operation result");
            }

            if (format == "pdf")
            {
                byte[] pdfHeader = new byte[10];
                attachment.Position = 0;
                attachment.Read(pdfHeader, 0, pdfHeader.Length);

                // TODO: join them to 1 assert with message
                Assert.AreEqual('%', Convert.ToChar(pdfHeader[0]));
                Assert.AreEqual('P', Convert.ToChar(pdfHeader[1]));
                Assert.AreEqual('D', Convert.ToChar(pdfHeader[2]));
                Assert.AreEqual('F', Convert.ToChar(pdfHeader[3]));
            }

            Assert.AreNotEqual(0, attachment.Length);
        } 
    }
}