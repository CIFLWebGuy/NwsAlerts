using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the response for the <c>/Zone</c> endpoint.
    /// </summary>
    public class ZoneResponse
    {
        /// <summary>
        /// Gets/sets the API context.
        /// </summary>
        [JsonPropertyName("@context")]
        public LdContext Context { get; set; }

        /// <summary>
        /// Gets/sets the list of zones.
        /// </summary>
        [JsonPropertyName("@graph")]
        public List<Zone> Zones { get; set; }
    }
}
