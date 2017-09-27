namespace BddTest.Steps
{
    using Base;

    public class BaseStep
    {
        protected ConversionContext context;

        public BaseStep(ConversionContext context)
        {
            this.context = context;
        }
    }
}