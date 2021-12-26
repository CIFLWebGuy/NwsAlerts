using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the properties for an NWS Alert
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// Gets/sets the LD ID of the alert
        /// </summary>
        [JsonPropertyName("@id")]
        public string LDID { get; set; }

        /// <summary>
        /// Gets/sets the ID of the alert
        /// </summary>
        [JsonPropertyName("id")]
        public string ID { get; set; }

        /// <summary>
        /// Gets/sets the alert type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets/sets the county names affected by the alert.
        /// </summary>
        /// <remarks>
        /// This property contains the names of the counties affected by the alert delimited by a semicolin.
        /// </remarks>
        public string AreaDesc { get; set; }

        /// <summary>
        /// Gets/sets the geocode data.
        /// </summary>
        public GeoCode GeoCode { get; set; }

        /// <summary>
        /// Gets/sets the list of URL for the affected zones.
        /// </summary>
        public string[] AffectedZones { get; set; }

        /// <summary>
        /// Gets/sets the references
        /// </summary>
        public List<AlertReference> References { get; set; }

        /// <summary>
        /// Gets/sets when the alert was sent.
        /// </summary>
        public DateTime? Sent { get; set; }

        /// <summary>
        /// Gets/sets when the alert goes into effect.
        /// </summary>
        public DateTime? Effective { get; set; }

        /// <summary>
        /// Gets/sets when the onset of the alert will occur.
        /// </summary>
        public DateTime? Onset { get; set; }

        /// <summary>
        /// Gets/sets when the alert will expire.
        /// </summary>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets/sets the status of the alert.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets/sets the message type.
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// Gets/sets the category of the alert.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets/sets the severity of the alert
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Gets/sets the certainty of the event
        /// </summary>
        public string Certainty { get; set; }

        /// <summary>
        /// Gets/sets the urgency of the alert.
        /// </summary>
        public string Urgency { get; set; }

        /// <summary>
        /// Gets/sets the type of the event.
        /// </summary>
        /// <remarks>This will be one of the event types returned by <see>ApiClient.GetEventTypes()</see> </remarks>
        public string Event { get; set; }

        /// <summary>
        /// Gets/sets the email of the sender.
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// Gets/sets the name of the sender.
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Gets/sets the alert headline.
        /// </summary>
        public string Headline { get; set; }

        /// <summary>
        /// Gets/sets the alert text.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets/sets additional instructions.
        /// </summary>
        public string Instruction { get; set; }

        /// <summary>
        /// Gets/sets the requested response.
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// Gets/sets the alert parameters.
        /// </summary>
        public AlertParameters Parameters { get; set; }
    }
}
