using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Contains SAME and UGC lists
    /// </summary>
    public class GeoCode
    {
        /// <summary>
        /// Gets/sets the list of SAME codes
        /// </summary>
        public string[] SAME { get; set; }

        /// <summary>
        /// Gets/sets the list of UGC codes
        /// </summary>
        public string[] UGC { get; set; }
    }
}
