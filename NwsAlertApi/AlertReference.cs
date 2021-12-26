using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines an alert reference.
    /// </summary>
    public class AlertReference
    {
        /// <summary>
        /// Gets/sets the LD ID for the alert.
        /// </summary>
        [JsonPropertyName("@id")]
        public string LDID { get; set; }

        /// <summary>
        /// Gets/sets the ID of the alert.
        /// </summary>
        [JsonPropertyName("identifer")]
        public string ID { get; set; }

        /// <summary>
        /// Gets/sets the emali of the sender.
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Gets/sets when the alert was sent.
        /// </summary>
        public DateTime Sent { get; set; }
    }
}
