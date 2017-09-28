namespace Aspose.Words.Cloud.Sdk.BddTests.Steps
{
    using Aspose.Words.Cloud.Sdk.BddTests.Base;

    /// <summary>
    /// It's a base step class with injection of conversion context
    /// </summary>
    public class BaseStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStep"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        public BaseStep(ConversionContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        protected ConversionContext Context { get; }
    }
}