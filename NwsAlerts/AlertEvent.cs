using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlerts
{   
    /// <summary>
    /// Defines the properties for an event.
    /// </summary>
    internal class AlertEvent
    {
        /// <summary>
        /// Gets/sets the name of the event
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets/sets the ID of the group.
        /// </summary>
        public int GroupID { get; set; }

        /// <summary>
        /// Gets/sets the location the alert is displayed.
        /// </summary>
        public DisplayLocation DisplayLocation { get; set; }

        /// <summary>
        /// Returns the string representation of this instance.
        /// </summary>
        /// <returns>The value of the <see cref="Name"/> property.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Calculates the hash code for this instance.
        /// </summary>
        /// <returns>This returns the value of the <see cref="GroupID"/> property.</returns>
        public override int GetHashCode()
        {
            return GroupID;
        }

        /// <summary>
        /// Determines if another object is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare.</param>
        /// <returns>True if the object is equal, false if not.</returns>
        public override bool Equals(object obj)
        {
            AlertEvent other = obj as AlertEvent;

            if (other == null)
                return false;

            return other == this || (other.Name == this.Name && other.GroupID == this.GroupID && other.DisplayLocation == this.DisplayLocation);
        }
    }
}
