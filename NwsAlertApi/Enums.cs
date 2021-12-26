using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines alert status flags
    /// </summary>
    [Flags]
    public enum AlertStatuses
    {
        None = 0x0,
        Actual = 0x1,
        Exercise = 0x2,
        System = 0x4,
        Test = 0x8,
        Draft = 0x10
    }

    /// <summary>
    /// Defines message type flags
    /// </summary>
    [Flags]
    public enum MessageTypes
    {
        None = 0x0,
        Alert = 0x1,
        Update = 0x2,
        Cancel = 0x4
    }

    /// <summary>
    /// Defines the region types.
    /// </summary>
    public enum RegionType
    {
        None,
        Land,
        Marine
    }

    /// <summary>
    /// Defines the marine regions.
    /// </summary>
    [Flags]
    public enum Regions
    {
        None = 0x0,
        AL = 0x1,
        AT = 0x2,
        GL = 0x4,
        GM = 0x8,
        PA = 0x10,
        PI = 0x20
    }

    /// <summary>
    /// Defines the the urgency of the alert.
    /// </summary>
    [Flags]
    public enum Urgencies
    {
        None = 0x0,
        Immediate = 0x1,
        Expected = 0x2,
        Future = 0x4,
        Past = 0x8,
        Unknown = 0x10
    }

    /// <summary>
    /// Defines the severity of the alert.
    /// </summary>
    [Flags]
    public enum Severities
    {
        None = 0x0,
        Unknown = 0x1,
        Minor = 0x2,
        Moderate = 0x4,
        Severe = 0x8,
        Extreme = 0x10
    }

    /// <summary>
    /// Defines the certainty of the event.
    /// </summary>
    [Flags]
    public enum Certainties
    {
        None = 0x0,
        Unknown = 0x1,
        Unlikely = 0x2,
        Possible = 0x4,
        Likely = 0x8,
        Observed = 0x10
    }

    public enum NwsZoneType
    {
        Land,
        Marine,
        Forecast,
        Public,
        Coastal,
        Offshore,
        Fire,
        County
    }
}
