using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    internal class ApiException : Exception
    {
        private ApiError err;

        public ApiError Details { get { return err; } }

        /// <summary>
        /// Initalizes a new instance of an ApiException object with the specified error data.
        /// </summary>
        /// <param name="error">The error data.</param>
        public ApiException(ApiError error) : base(error.Message)
        {
            err = error;
        }

        /// <summary>
        /// Initalizes a new instance of an ApiException object with the specified error data and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="innerException"></param>
        public ApiException(ApiError error, Exception innerException) : base(error.Message, innerException)
        {
            err = error;
        }
    }
}
