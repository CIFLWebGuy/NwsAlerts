using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the LD context
    /// </summary>
    public class LdContext
    {
        /// <summary>
        /// Gets or sets the version number
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the WX ID
        /// </summary>
        public string WX { get; set; }
        
        /// <summary>
        /// Gets or sets the vocab URI
        /// </summary>
        [JsonPropertyName("@vocab") ]
        public string Vocab { get; set; }
    }
}
