namespace Aspose.Words.Cloud.Sdk
{
    using System;

    public class ApiException : Exception
    {
        private readonly int errorCode;
        
        public ApiException(int errorCode, string message) : base(message)
        {
            this.errorCode = errorCode;
        }

        public int ErrorCode
        {
            get
            {
                return this.errorCode;
            }
        }       
    }
}
