using BddTest.Base;
using TechTalk.SpecFlow;

namespace BddTest.Steps
{
    [Binding]
    public class ConversionOfStoredDocumentSteps : BaseStep
    {
        public ConversionOfStoredDocumentSteps(ConversionContext context) : base(context)
        {
        }

        [Given(@"I have uploaded document with name (.*) to storage")]
        public void GivenIHaveUploadedDocumentWithNameToStorage(string fileName)
        {
            context.FileName = fileName;
            context.UploadDocumentToStorage();
        }
        
        [Given(@"I have specified document name (.*) in GET URL")]
        public void GivenIHaveSpecifiedDocumentNameInGetUrl(string fileName)
        {
            context.FileName = fileName;
        }
        
        [When(@"I execute conversion from storage")]
        public void WhenIExecuteConversionFromStorage()
        {
            context.ConvertDocumentFromStorage(context.FileName);
        }
    }
}
