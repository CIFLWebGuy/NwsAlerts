using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the properties of an observation station.
    /// </summary>
    public class ObservationStation
    {
        /// <summary>
        /// Gets/sets the Index of the station.
        /// </summary>
        [JsonPropertyOrder(0)]
        public int Index { get; set; }

        /// <summary>
        /// Gets/sets the URL of the station.
        /// </summary>
        [JsonPropertyOrder(1)]
        public string Url { get; set; }
    }
}
