using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines an address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the locality (city).
        /// </summary>
        public string AddressLocality { get; set; }

        /// <summary>
        /// Gets or sets the region (state/territory).
        /// </summary>
        public string AddressRegion { get; set; }

        /// <summary>
        /// Gets or sets the postal code
        /// </summary>
        public string postalCode { get; set; }
    }
}
