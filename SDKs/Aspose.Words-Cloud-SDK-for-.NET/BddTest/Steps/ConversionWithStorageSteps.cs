using BddTest.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BddTest.Steps
{
    [Binding]
    public class ConversionWithStorageSteps : BaseStep
    {
        public ConversionWithStorageSteps(ConversionContext context) : base(context)
        {
        }

        [Given(@"I have specified output path (.*)")]
        public void GivenIHaveSpecifiedOutputPath(string outPath)
        {
            context.OutPath = outPath;
        }
        
        [Then(@"converted document is saved to storage")]
        public void ThenConvertedDocumentIsSavedToStorage()
        {
            context.SaveConvertedDocumentToStorage();
        }

        [Then(@"its filename is (.*)")]
        public void ThenItsFilenameIs(string fileName)
        {
            Assert.IsNotNull(context.FileWithNameExists(fileName));
            Assert.IsTrue(context.FileWithNameExists(fileName).Value);
        }
    }
}
