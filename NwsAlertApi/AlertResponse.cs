using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    ///  Defines the response for the <c>/Alert</c> endpoint.
    /// </summary>
    public class AlertResponse
    {
        /// <summary>
        /// Gets or sets the api context.
        /// </summary>
        [JsonPropertyName("@context")]
        public LdContext context { get; set; }

        /// <summary>
        /// Gets or sets the alert data.
        /// </summary>
        [JsonPropertyName("@graph")]
        public List<Alert> Alerts { get; set; }

        /// <summary>
        /// Gets or sets the response title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets when the data was updated.
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
