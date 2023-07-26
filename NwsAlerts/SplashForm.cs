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
    public partial class SplashForm : Form
    {
        /// <summary>
        /// Gets/sets the status text
        /// </summary>
        public string StatusText
        {
            get
            {
                return labelStatus.Text;
            }
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        labelStatus.Text = value;
                        Refresh();
                    }));
                }
                else
                {
                    labelStatus.Text = value;
                    Refresh();
                }
            }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            labelVersion.Text = Application.ProductVersion;
        }
    }
}
