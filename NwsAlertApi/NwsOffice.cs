using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the properties for an NWS office.
    /// </summary>
    public class NwsOffice
    {
        /// <summary>
        /// Gets/sets the LD Context
        /// </summary>
        [JsonPropertyName("@context")]
        public LdContext Context { get; set; }
        
        /// <summary>
        /// Gets/sets the LD type name.
        /// </summary>
        [JsonPropertyName("@type")]
        public string LdTypeName { get; set; }

        /// <summary>
        /// Gets/sets the LD ID.
        /// </summary>
        [JsonPropertyName("@id")]
        public string LDID { get; set; }

        /// <summary>
        /// Get/sets the office ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string OfficeID { get; set; }

        /// <summary>
        /// Gets/sets the name of the office.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the address.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Gets/sets the telephone number.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Gets/sets the fax number.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// Gets/sets the email address of the office.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets/sets the URL for the office.
        /// </summary>
        public string SameAs { get; set; }

        /// <summary>
        /// Gets/sets the NWS region the office has been assigned to.
        /// </summary>
        public string NwsRegion { get; set; }

        /// <summary>
        /// Gets/sets the URL of the parent orginization.
        /// </summary>
        public string ParentOrginization { get; set; }

        /// <summary>
        /// Gets/sets the counties the office is responsible for.
        /// </summary>
        /// <remarks>This is an array of LD IDs.</remarks>
        public string[] ResponsibleCounties { get; set; }

        /// <summary>
        /// Gets/sets the forecast zones the office is responsible for,
        /// </summary>
        /// <remarks>This is an array of LD IDs.</remarks>
        public string[] ResponsibleForecastZones { get; set; }

        /// <summary>
        /// Gets/sets the fire zones the office is responsible for.
        /// </summary>
        /// <remarks>This is an array of LD IDs</remarks>
        public string[] ResponsibleFireZones { get; set; }

        /// <summary>
        /// Gets/sets the approved observation stations assigned to the office.
        /// </summary>
        /// <remarks>This is an array of LD IDs.</remarks>
        public string[] ApprovedObservationStations { get; set; }
    }
}
