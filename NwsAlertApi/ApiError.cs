using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Provides properties that detail errors from API calls.
    /// </summary>
    internal class ApiError
    {
        /// <summary>
        /// Gets/sets the error URL
        /// </summary>
        [JsonPropertyName("type")]
        public string Url { get; set; }

        /// <summary>
        /// Gets/sets the error summary
        /// </summary>
        [JsonPropertyName("title")]
        public string Message { get; set; }

        /// <summary>
        /// Gets/sets the HTTP status code.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets/sets the error detail.
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// Gets/sets a URI reference that identifies the specific occurrence of the problem.
        /// </summary>
        public string Instance { get; set; }

        /// <summary>
        /// Gets/sets a unique identifier for the request, used for NWS debugging purposes. 
        /// </summary>
        /// <remarks>Please include this identifier with any correspondence to help us investigate your issue.</remarks>
        public string CorrelationId { get; set; }
    }
}
