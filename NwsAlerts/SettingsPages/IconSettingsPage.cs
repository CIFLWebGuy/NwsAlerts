using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NwsAlerts
{
    /// <summary>
    /// Implements the settings page for the event images.
    /// </summary>
    public partial class IconSettingsPage : UserControl
    {
        private ImageList iconImages;
        private Dictionary<string, string> iconSettings;

        /// <summary>
        /// Gets the settings set by the user.
        /// </summary>
        public Dictionary<string, string> Settings
        {
            get
            {
                return iconSettings;
            }
        }

        /// <summary>
        /// Initalizes an instance of a <see cref="IconSettingsPage"/> object with the specified images and setting map.
        /// </summary>
        /// <param name="images">The images available.</param>
        /// <param name="settings">The settings map.</param>
        public IconSettingsPage(ImageList images, Dictionary<string, string> settings)
        {
            InitializeComponent();

            this.iconImages = images;
            this.iconSettings = new Dictionary<string, string>();

            foreach(KeyValuePair<string, string> pair in settings)
            {
                this.iconSettings.Add(pair.Key, pair.Value);
            }
        }

        private void IconSettingsPage_Load(object sender, EventArgs e)
        {
            listViewImages.LargeImageList = iconImages;

            for(int i = 0; i < iconImages.Images.Count; i++) 
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = iconImages.Images.Keys[i].ToString();

                listViewImages.Items.Add(item);
            }

            foreach(KeyValuePair<string, string> item in iconSettings)
            {
                ListViewItem listViewItem = new ListViewItem(item.Key);
                listViewEvents.Items.Add(listViewItem);
            }
        }

        private void listViewEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedIndices.Count == 0)
                return;

            if(listViewImages.SelectedIndices.Count != 0)
                listViewImages.SelectedItems[0].Selected = false;

            string imageKey = iconSettings[listViewEvents.SelectedItems[0].Text];

            if(string.IsNullOrEmpty(imageKey))
                imageKey = listViewEvents.SelectedItems[0].Text;

            ListViewItem item = listViewImages.FindItemWithText(imageKey);

            if (imageKey != "" && item != null)
            {
                item.Selected = true;
                item.EnsureVisible();
            }
            else
            {
                string key = listViewEvents.SelectedItems[0].Text;

                if (key.Contains("Warning"))
                {
                    item = listViewImages.FindItemWithText("Warning");
                }
                else if (key.Contains("Watch"))
                {
                    item = listViewImages.FindItemWithText("Watch");
                }
                else
                {
                    item = listViewImages.FindItemWithText("Advisory");
                }

                item.Selected = true;
                item.EnsureVisible();
            }
        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewEvents.SelectedItems.Count == 0 || listViewImages.SelectedItems.Count == 0)
                return;

            iconSettings[listViewEvents.SelectedItems[0].Text] = listViewImages.SelectedItems[0].Text;
        }
    }
}
