using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NwsAlerts
{
    /// <summary>
    /// Represents the arguments used by the <see cref="SettingsDlog.NeedImageSettings"> event handler.
    /// </summary>
    public class NeedImageSettingsArgs
    {
        /// <summary>
        /// The available images.
        /// </summary>
        public ImageList Images;

        /// <summary>
        /// The image map.
        /// </summary>
        public Dictionary<string, string> ImageMap;
    }
}
