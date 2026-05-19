using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the parameters for an alert.
    /// </summary>
    public class AlertParameters
    {
        /// <summary>
        /// Gets or sets the PIL
        /// </summary>
        string[] PIL { get; set; }  

        /// <summary>
        /// Gets or sets the headline.
        /// </summary>
        [JsonPropertyName("NWSheadline")]
        string[] Headline { get; set; }

        /// <summary>
        /// Gets or sets the block channels to send the alert through.
        /// </summary>
        string[] BlockChannel { get; set; }

        /// <summary>
        /// Gets or sets the EAS data.
        /// </summary>
        [JsonPropertyName("EAS-ORG")]
        string[] EasOrg { get; set; }

        /// <summary>
        /// Gets or sets the AWIPS identifer
        /// </summary>
        [JsonPropertyName("AWIPSidentifier")]
        string[] AwipsIdentifer { get; set; }

        /// <summary>
        /// Gets or sets the event end time.
        /// </summary>
        [JsonPropertyName("eventEndingTime")]
        string[] EventEndingTime { get; set; }

        /// <summary>
        /// Gets or sets the motion description
        /// </summary>
        [JsonPropertyName("eventMotionDescription")]
        string[] EventMotionDescription { get; set; }

        /// <summary>
        /// Gets or sets the hail threat.
        /// </summary>
        [JsonPropertyName("hailThreat")]
        string[]     HailThreat { get; set;  }

        /// <summary>
        /// Gets or sets the max hail size.
        /// </summary>
        [JsonPropertyName("maxHailSize")]
        string[] MaxHailSize { get; set; }

        /// <summary>
        /// Gets or sets the max wind gust.
        /// </summary>
        [JsonPropertyName("maxWindGust")]
        string[] MaxWindGust { get; set; }
        
        /// <summary>
        /// Gets or sets the thunderstorm damage threat.
        /// </summary>
        [JsonPropertyName("thunderstormDamageThreat")]
        string[] ThunderstormDamageThreat { get; set; }

        /// <summary>
        /// Gets or sets the tornado detection tag.
        /// </summary>
        [JsonPropertyName("tornadoDetection")]
        string[] TornadoDetection { get; set; }

        /// <summary>
        /// Gets or sets the VTEC header.
        /// </summary>
        [JsonPropertyName("VTEC")]
        string[] Vtec { get; set; }

        /// <summary>
        /// Gets or sets the wind threat.
        /// </summary>
        [JsonPropertyName("windThreat")]
        string[] WindThreat { get; set; }

        /// <summary>
        /// Gets or sets the WMO identifer.
        /// </summary>
        [JsonPropertyName("WMOidentifier")]
        string[] WmoIdentifer { get; set; }
    }
}
