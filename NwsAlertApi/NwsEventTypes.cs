using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Contains the list of events used by the NWS.
    /// </summary>
    internal class NwsEventTypes
    {   
        /// <summary>
        /// Gets/sets the API context
        /// </summary>
        /// <remarks>
        /// This is not used and will be empty.
        /// </remarks>
        [JsonPropertyName("@context")]
        public string[] Context { get; set; }

        /// <summary>
        /// Gets/sets the event type list.
        /// </summary>
        public string[] EventTypes { get; set; }
    }
}
