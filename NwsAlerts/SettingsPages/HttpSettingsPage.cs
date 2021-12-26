using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NwsAlerts.SettingsPages
{
    internal partial class HttpSettingsPage : UserControl
    {
        public string OutputPath
        {
            get
            {
                return textBoxPath.Text;
            }
            set
            {
                textBoxPath.Text = value;
            }
        }

        public HttpSettingsPage()
        {
            InitializeComponent();
        }

        private void HttpSettingsPage_Load(object sender, EventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select output folder";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                    textBoxPath.Text = dialog.SelectedPath;
            }
        }
    }
}
