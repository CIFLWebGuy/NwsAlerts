using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the alert codes for an alert.
    /// </summary>
    public class EventCode
    {
        /// <summary>
        /// Gets or sets the SAME codes.
        /// </summary>
        public string[] Same { get; set; }

        /// <summary>
        /// Gets or sets the NWS codes.
        /// </summary>
        [JsonPropertyName("NationalWeatherService")]
        public string[] Nws { get; set; }
    }
}
