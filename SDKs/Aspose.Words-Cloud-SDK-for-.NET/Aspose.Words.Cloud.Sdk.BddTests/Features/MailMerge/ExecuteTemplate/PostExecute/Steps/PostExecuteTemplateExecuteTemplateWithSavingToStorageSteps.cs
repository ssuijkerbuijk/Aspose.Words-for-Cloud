namespace Aspose.Words.Cloud.Sdk.BddTests.Features.MailMerge.ExecuteTemplate.PostExecute.Steps
{
    using System.IO;

    using Aspose.Words.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.Words.Cloud.Sdk.Model.Requests;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for executing template with saving to storage
    /// </summary>
    [Binding]
    public class PostExecuteTemplateWithSavingToStorageSteps
    {
        private BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="PostExecuteTemplateWithSavingToStorageSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PostExecuteTemplateWithSavingToStorageSteps(BaseContext context)
        {
            this.context = context;
        }

        private PostExecuteTemplateRequest Request
        {
            get
            {
                return ScenarioContext.Current["Request"] as PostExecuteTemplateRequest;
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("PostExecuteTemplate")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new PostExecuteTemplateRequest();
        }

        /// <summary>
        /// Initialize document name for executing template from storage
        /// </summary>
        /// <param name="documentName">document name</param>
        [Given(@"I have specified a template file name (.*) with mustache syntax")]
        public void GivenIHaveSpecifiedATemplateWithMustacheSyntax(string documentName)
        {
            this.Request.Name = documentName;
        }

        /// <summary>
        /// Initialize body document name for executing template from storage
        /// </summary>
        /// <param name="bodyDocumentName">body document name</param>
        [Given(@"I have specified a body (.*)")]
        public void GivenIHaveSpecifiedABody(string bodyDocumentName)
        {
            // TODO: use "I have specified document <DocName> to send it in request body" step insted
            this.Request.Data = File.ReadAllText(Path.Combine(this.context.TestDataPath, bodyDocumentName));
        }

        /// <summary>
        /// Initialize destination file name
        /// </summary>
        /// <param name="destFileName">destination file name</param>
        [Given(@"I have specified a destFileName (.*)")]
        public void GivenIHaveSpecifiedADestFileName(string destFileName)
        {
            // TODO: move to common steps (it is ICanModifyDocumentRequest)
            this.Request.DestFileName = destFileName;
        }

        /// <summary>
        /// Initialize property "WithRegions"
        /// </summary>
        /// <param name="withRegions">WithRegions</param>
        [Given(@"I have specified withRegions (.*)")]
        public void GivenIHaveSpecifiedWithRegions(bool withRegions)
        {
            // TODO: Add interface "ICanSpecifyMailMergeParametersRequest" and move steps
            this.Request.WithRegions = withRegions;
        }

        /// <summary>
        /// Initialize property "UseWholeParagraphAsRegion"
        /// </summary>
        /// <param name="useWholeParagraphAsRegion">UseWholeParagraphAsRegion</param>
        [Given(@"I have specified useWholeParagraphAsRegion (.*)")]
        public void GivenIHaveSpecifiedUseWholeParagraphAsRegion(bool useWholeParagraphAsRegion)
        {
            // TODO: Add interface "ICanSpecifyMailMergeParametersRequest" and move steps
            this.Request.UseWholeParagraphAsRegion = useWholeParagraphAsRegion;
        }
        
        /// <summary>
        /// Executes template from storage
        /// </summary>
        [When(@"I execute template")]
        public void WhenIExecuteTemplate()
        {
            this.Request.Folder = this.context.TestFolderInStorage;
            this.context.Response = this.context.WordsApi.PostExecuteTemplate(this.Request);
        }
        
        /// <summary>
        /// Checks document was successfully created on storage
        /// </summary>
        [Then(@"document with merged values should be created on storage")]
        public void ThenDocumentWithMergedValuesShouldBeCreated()
        {
            // TODO: move to storage steps (+rename - we don't check here anything, which is related which "merged values"
            // or check "merged values"
            Assert.IsTrue(this.context.FileWithNameExists(this.Request.DestFileName), "Error while saving file to storage");
        }
    }
}
