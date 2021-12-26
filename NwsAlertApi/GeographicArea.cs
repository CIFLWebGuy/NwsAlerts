using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwsAlertApi
{
    /// <summary>
    /// Defines the properties used to define a geographic area in API calls.
    /// </summary>
    /// <remarks>This class is used by API calls where a geographic area can be specified. These properties are mutually exclusive; setting one will clear the others. </remarks>
    public class GeographicArea
    {
        private RegionType regionType;
        private Point? point;
        private Regions region;
        private readonly ObservableCollection<string> area;
        private readonly ObservableCollection<string> zone;
        private bool clearList;

        /// <summary>
        /// Gets/sets the region type.
        /// </summary>
        public RegionType RegionType
        {
            get
            {
                return regionType;
            }
            set
            {
                regionType = value;
                point = null;
                region = Regions.None;
                area.Clear();
                zone.Clear();
            }
        }

        /// <summary>
        /// Gets/sets the geographic point to use.
        /// </summary>
        public Point? Point
        {
            get 
            {
                return point; 
            }
            set 
            {
                point = value;
                regionType = RegionType.None;
                region = Regions.None;
                area.Clear();
                zone.Clear();
            }
        }

        /// <summary>
        /// Gets/sets the marine region.
        /// </summary>
        public Regions Region
        {
            get
            {
                return region;
            }
            set 
            {
                region = value;
                point = null;
                regionType = RegionType.None;
                area.Clear();
                zone.Clear();
            }
        }

        /// <summary>
        /// Gets the list of states codes used to define the area.
        /// </summary>
        public ObservableCollection<string> StateCodes
        {
            get
            {
                return area;
            }
        }

        /// <summary>
        /// Gets the list of zone IDs.
        /// </summary>
        public ObservableCollection<string> Zones
        {
            get
            {
                return zone;
            }
        }

        /// <summary>
        /// Initalizes an instance of an GeographicArea object.
        /// </summary>
        public GeographicArea()
        {
            area = new ObservableCollection<string>();
            area.CollectionChanged += Area_CollectionChanged;

            zone = new ObservableCollection<string>();
            zone.CollectionChanged += Zone_CollectionChanged;

            point = null;
            region = Regions.None;
            regionType = RegionType.None;
            clearList = false;
        }

        private void Zone_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (clearList)
                return;

            clearList = true;

            area.Clear();
            regionType = RegionType.None;
            region = Regions.None;
            point = null;

            clearList = false;
        }

        private void Area_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (clearList)
                return;

            clearList = true;
            
            zone.Clear();
            regionType = RegionType.None;
            region = Regions.None;
            point = null;

            clearList = false;
        }
    }
}
