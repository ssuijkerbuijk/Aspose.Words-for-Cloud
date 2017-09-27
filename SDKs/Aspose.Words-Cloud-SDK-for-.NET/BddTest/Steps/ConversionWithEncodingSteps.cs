using System;
using BddTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BddTest.Steps
{
    [Binding]
    public class ConversionWithEncodingSteps : BaseStep
    {
        public ConversionWithEncodingSteps(ConversionContext context) : base(context)
        {
        }

        [Given(@"I have specified encoding (.*)")]
        public void GivenIHaveSpecifiedEncoding(string encoding)
        {
            context.LoadEncoding = encoding;
        }
        
        [When(@"I execute conversion with encoding")]
        public void WhenIExecuteConversionWithEncoding()
        {
            context.ConversionWithEncoding();
        }
        
        [Then(@"symbols are encoded properly")]
        public void ThenSymbolsAreEncodedProperly()
        {
            Assert.IsNotNull(context.ConvertedDocument);
        }
    }
}
