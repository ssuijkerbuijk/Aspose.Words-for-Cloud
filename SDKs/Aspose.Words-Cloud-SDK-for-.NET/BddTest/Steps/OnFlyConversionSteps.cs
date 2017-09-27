using System;
using BddTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BddTest.Steps
{
    [Binding]
    public class OnFlyConversionSteps : BaseStep
    {
        public OnFlyConversionSteps(ConversionContext context) : base(context)
        {
        }

        [Given(@"I have specified document name is (.*)  and format is (.*)")]
        public void GivenIHaveSpecifiedDocumentNameAndFormat(string documentName, string format)
        {
            context.FileName = string.Concat(documentName.Trim('\''), ".", format.Trim('\''));
        }
        
        [Given(@"I have specified format (.*) document to be converted")]
        public void GivenIHaveSpecifiedFormatDocumentToBeConverted(string destinationFormat)
        {
            context.OutputFormat = destinationFormat.Trim('\'');
        }

        [When(@"I execute conversion")]
        public void WhenIExecuteConversion()
        {
            context.ConvertDocumentFormAttachment();
        }

        [Then(@"document has to be returned as an attachment")]
        public void ThenDocumentHasToBeReturnedAsAnAttachment()
        {
            Assert.IsNotNull(context.ConvertedDocument);
        }
        
        [Then(@"its format (.*)")]
        public void ThenItsFormat(string outFormat)
        {
            if (outFormat.Trim('\'') == "pdf")
            {
                byte[] pdfHeader = new byte[10];
                context.ConvertedDocument.Position = 0;
                context.ConvertedDocument.Read(pdfHeader, 0, pdfHeader.Length);
                Assert.AreEqual('%', Convert.ToChar(pdfHeader[0]));
                Assert.AreEqual('P', Convert.ToChar(pdfHeader[1]));
                Assert.AreEqual('D', Convert.ToChar(pdfHeader[2]));
                Assert.AreEqual('F', Convert.ToChar(pdfHeader[3]));
            }
            
            Assert.IsNotNull(context.ConvertedDocument);
            Assert.AreNotEqual(0, context.ConvertedDocument.Length);
        }
    }
}
