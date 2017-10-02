namespace Aspose.Words.Cloud.Sdk.BddTests.Steps.MailMergeSteps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base;

    /// <summary>
    /// Base class for mail merge steps 
    /// </summary>
    public abstract class BaseMailMergeStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMailMergeStep"/> class.
        /// </summary>
        /// <param name="context">Mail merge context</param>
        protected BaseMailMergeStep(MailMergeContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Context for mail merging
        /// </summary>
        protected MailMergeContext Context { get; set; }
    }
}