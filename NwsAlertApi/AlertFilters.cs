using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines properties used to filter query results.
    /// </summary>
    public class AlertFilters
    {
        private int limit;

        /// <summary>
        /// Gets/sets a flag that determines whether to retrieve only active alerts.
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Gets/sets the start time.
        /// </summary>
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets/sets the ending time.
        /// </summary>
        public DateTime? End { get; set; }

        /// <summary>
        /// Gets/sets the alert statues to query for.
        /// </summary>
        public AlertStatuses Status { get; set; }

        /// <summary>
        /// Gets/sets the message types to query
        /// </summary>
        public MessageTypes MessageTypes { get; set; }       
        
        /// <summary>
        /// Gets the list of events to retrieve.
        /// </summary>
        public List<string> Events { get; }

        /// <summary>
        /// Gets the list of codes to retrieve.
        /// </summary>
        public List<string> Codes { get; }

        /// <summary>
        /// Gets the geographic area to search.
        /// </summary>
        public GeographicArea Area { get; }

        /// <summary>
        /// Gets/sets the urgency of the alert.
        /// </summary>
        public Urgencies Urgency { get; set; }

        /// <summary>
        /// Gets/sets the severity of the alert.
        /// </summary>
        public Severities Severity { get; set; }

        /// <summary>
        /// Gets/sets the certianty of the event.
        /// </summary>
        public Certainties Certainty { get; set; }

        /// <summary>
        /// Gets/sets the page number.
        /// </summary>
        public int? PageNo { get; set; }

        public int Limit
        {
            get
            {
                return limit;
            }
            
            set
            {
                if(value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Limit must be between 0 and 500.");
                }

                limit = value;
            }
        }

        /// <summary>
        /// Initalizes an instance of an AlertFilters object.
        /// </summary>
        public AlertFilters()
        {
            Events = new List<string>();
            Codes = new List<string>();
            Area = new GeographicArea();
        }
    }
}
