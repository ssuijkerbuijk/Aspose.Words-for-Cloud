namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.MailMergeSteps
{
    using System;

    using Aspose.Words.Cloud.Sdk.BddTests.Base;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;


    /// <summary>
    /// Steps for template execution
    /// </summary>
    [Binding]
    public class TemplateExecutionSteps : BaseMailMergeStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateExecutionSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public TemplateExecutionSteps(MailMergeContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Sets template name
        /// </summary>
        /// <param name="templateName">template name</param>
        [Given(@"I have specified a template (.*) with mustache syntax")]
        public void GivenIHaveSpecifiedATemplateWithMustacheSyntax(string templateName)
        {
            this.Context.FileName = templateName;
            this.Context.UploadDocumentToStorage();
        }
        
        /// <summary>
        /// Sets body file name
        /// </summary>
        /// <param name="bodyFile">body file name</param>
        [Given(@"I have specified a body (.*)")]
        public void GivenIHaveSpecifiedABody(string bodyFile)
        {
            this.Context.FileWithBodyData = bodyFile;
        }
        
        /// <summary>
        /// Executes template
        /// </summary>
        [When(@"I execute template")]
        public void WhenIExecuteTemplate()
        {
            this.Context.ExecuteTemplate();
        }
        
        /// <summary>
        /// Asserts document is created
        /// </summary>
        [Then(@"document with merged values should be created")]
        public void ThenDocumentWithMergedValuesShouldBeCreated()
        {
            Assert.IsNotNull(this.Context.DocumentResponse.Document);
        }
        
        /// <summary>
        /// Asserts document name contains Guid value
        /// </summary>
        [Then(@"document name is Guid value")]
        public void ThenDocumentNameIsGuidValue()
        {
            Guid outGuid;
            Assert.IsTrue(Guid.TryParse(this.Context.DocumentResponse.Document.FileName.Split('.')[1], out outGuid));
        }

        /// <summary>
        /// Sets destiation file name
        /// </summary>
        /// <param name="destFileName">destiation file name</param>
        [Given(@"I have specified a destFileName (.*)")]
        public void GivenIHaveSpecifiedADestFileName(string destFileName)
        {
            this.Context.DestinationFileName = destFileName;
        }

        /// <summary>
        /// Asserts document name is equal to destFileName
        /// </summary>
        [Then(@"document name is equal to destFileName")]
        public void ThenDocumentNameIsEqualToDestFileName()
        {
            Assert.AreEqual(this.Context.DestinationFileName, this.Context.DocumentResponse.Document.FileName);
        }

        /// <summary>
        /// Sets use or not option 'WithRegions'
        /// </summary>
        /// <param name="withRegions">with regions</param>
        [Given(@"I have specified withRegions (.*)")]
        public void GivenIHaveSpecifiedWithRegions(bool withRegions)
        {
            this.Context.WithRegions = withRegions;
        }

        /// <summary>
        /// Sets use or not option 'UseWholeParagraphAsRegion'
        /// </summary>
        /// <param name="useWholeParagraphAsRegion">useWholeParagraphAsRegion</param>
        [Given(@"I have specified useWholeParagraphAsRegion (.*)")]
        public void GivenIHaveSpecifiedUseWholeParagraphAsRegion(bool useWholeParagraphAsRegion)
        {
            this.Context.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
        }

        /// <summary>
        /// Checks image was rendered
        /// </summary>
        [Then(@"image should be rendered")]
        public void ThenImageShouldBeRendered()
        {
            // TODO how to check images are rendered?
            Assert.IsNotNull(this.Context.DocumentResponse.Document);
        }

        /// <summary>
        /// Sets cleanup option
        /// </summary>
        /// <param name="cleanupOption">option to cleanup</param>
        [Given(@"I have specified a cleanup option (.*)")]
        public void GivenIHaveSpecifiedACleanupOption(string cleanupOption)
        {
            this.Context.Cleanup = cleanupOption;
        }

        /// <summary>
        /// Checks options that have to be cleaned up are actually cleaned up
        /// </summary>
        [Then(@"unused option is cleaned up")]
        public void ThenUnusedOptionIsCleanedUp()
        {
            // TODO how to check all options are cleaned
            Assert.IsNotNull(this.Context.DocumentResponse.Document);
        }
    }
}
