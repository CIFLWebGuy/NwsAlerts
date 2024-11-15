using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NwsAlerts
{
    public partial class SettingsDlog : Form
    {
        private IconSettingsPage imagePage;
        private UserControl activePage;

        /// <summary>
        /// Event that is raised when the dialog needs the image settings.
        /// </summary>
        public event EventHandler<NeedImageSettingsArgs> NeedImageSettings;

        public SettingsDlog()
        {
            InitializeComponent();
        }

        private void SaveImageSettings()
        {
            XDocument settingsDoc = XDocument.Load("Alerts.xml");
            XElement eventRoot = settingsDoc.Element("configuration").Element("events");

            try
            {

                foreach (XElement eventElement in eventRoot.Elements())
                {
                    eventElement.SetAttributeValue("icon", imagePage.Settings[eventElement.Attribute("name").Value]);
                }

                settingsDoc.Save("Alerts.xml");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Encountered a problem attempting to save the settings: " + ex.Message, "Save Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void DoNeedImageSettings(NeedImageSettingsArgs e)
        {
            NeedImageSettings?.Invoke(this, e);
        }

        private void treeViewNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(activePage != null)
                activePage.Visible = false;

            switch(e.Node.FullPath)
            {
                case "Event Icons":

                    if (imagePage == null)
                    {
                        NeedImageSettingsArgs args = new NeedImageSettingsArgs();
                        DoNeedImageSettings(args);

                        if (args.Images == null)
                            throw new InvalidOperationException("ImageList cannot be null.");

                        if (args.ImageMap == null)
                            throw new InvalidOperationException("Image map cannot be null.");
                                                
                        imagePage = new IconSettingsPage(args.Images, args.ImageMap);
                        imagePage.Dock = DockStyle.Fill;

                        panelPages.Controls.Add(imagePage);
                    }

                    activePage = imagePage;
                    break;
            }

            if(activePage != null)
                activePage.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (imagePage != null)
                SaveImageSettings();

            DialogResult = DialogResult.OK;
        }
    }
}
