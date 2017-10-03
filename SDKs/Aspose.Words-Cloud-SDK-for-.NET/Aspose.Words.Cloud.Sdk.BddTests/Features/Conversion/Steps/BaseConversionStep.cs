namespace Aspose.Words.Cloud.Sdk.BddTests.Features.Conversion.Steps
{
    /// <summary>
    /// It's a base conversion step class with injection of conversion context
    /// </summary>
    public abstract class BaseConversionStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseConversionStep"/> class.
        /// </summary>
        /// <param name="context">Conversion context</param>
        protected BaseConversionStep(ConversionContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        protected ConversionContext Context { get; set; }
    }
}