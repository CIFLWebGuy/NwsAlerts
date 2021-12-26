using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the properties of a NWS zone.
    /// </summary>
    public class Zone
    {
        /// <summary>
        /// A geometry represented in Well-Known Text (WKT) format.
        /// </summary>
        [JsonPropertyName("geometry")]
        public string GeometryWkt { get; set; }
        
        /// <summary>
        /// Gets/sets the LD ID
        /// </summary>
        [JsonPropertyName("@id")]
        public string LDID { get; set; }

        /// <summary>
        /// Gets/sets the LD type name
        /// </summary>
        [JsonPropertyName("@type")]
        public string LdTypeName { get; set; }

        /// <summary>
        /// UGC identifier for a NWS forecast zone or county.
        /// </summary>
        /// <remarks><para>The first two letters will correspond to either a state code or marine area code 
        /// (see #/components/schemas/StateTerritoryCode and #/components/schemas/MarineAreaCode for lists of valid letter combinations).</para> 
        /// <para>The third letter will be Z for public/fire zone or C for county.</para></remarks>
        public string ID { get; set; }

        /// <summary>
        /// Gets the NWS zone type.
        /// </summary>
        public NwsZoneType NwsZoneType { get; set; }

        /// <summary>
        /// Gets/sets the name of the zone.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the effective date.
        /// </summary>
        public DateTime EffectiveDate { get; set; }

        /// <summary>
        /// Gets/sets the expiration date.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets/sets the state code for the zone.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets/sets the three-letter identifer for a NWS office.
        /// </summary>
        public string[] Cwa { get; set; }

        /// <summary>
        /// Gets/sets the URLs of the forecast offices
        /// </summary>
        public string[] ForecastOffices { get; set; }

        /// <summary>
        /// Gets/sets the timezone IDs.
        /// </summary>
        public string[] TimeZone { get; set; }

        /// <summary>
        /// Gets/sets the observation stations URLs.
        /// </summary>
        //public string[] ObservationStations { get; set; }

        /// <summary>
        /// Gets/sets the radar station ID.
        /// </summary>
        public string RadarStation { get; set; }
    }
}
