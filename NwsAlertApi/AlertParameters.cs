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
        /// Gets/sets the PIL
        /// </summary>
        string[] PIL { get; set; }  

        /// <summary>
        /// Gets/sets the headline.
        /// </summary>
        [JsonPropertyName("NWSheadline")]
        string[] Headline { get; set; }

        /// <summary>
        /// Gets/sets the block channels to send the alert through.
        /// </summary>
        string[] BlockChannel { get; set; }

        /// <summary>
        /// Gets/sets the EAS data.
        /// </summary>
        [JsonPropertyName("EAS-ORG")]
        string EasOrg { get; set; }
    }
}
