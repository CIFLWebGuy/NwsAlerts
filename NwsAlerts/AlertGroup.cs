using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlerts
{
    /// <summary>
    /// Defines an alert group.
    /// </summary>
    internal class AlertGroup
    {
        /// <summary>
        /// Gets/sets the ID of the group.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets/sets the name of the group.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the CSS class of the group.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// Gets/sets a flag that determines if the event type is displayed in the output list.
        /// </summary>
        public bool ShowEvent { get; set; }
    }
}
