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
    internal partial class ApiSettingsPage : UserControl
    {
        /// <summary>
        /// Gets/sets the refresh interval.
        /// </summary>
        public int RefreshInterval
        {
            get
            {
                return (int)upDownRefresh.Value;
            }
            set
            {
                upDownRefresh.Value = value;
            }
        }

        /// <summary>
        /// Gets/sets the API endpoint URL
        /// </summary>
        public string Endpoint
        {
            get
            {
                return textBoxEndpoint.Text;
            }
            set
            {
                textBoxEndpoint.Text = value;
            }
        }

        /// <summary>
        /// Gets/sets the user's email.
        /// </summary>
        public string Email
        {
            get
            {
                return textBoxEmail.Text;
            }
            set
            {
                textBoxEmail.Text = value;
            }
        }

        public ApiSettingsPage()
        {
            InitializeComponent();
        }

        private void textBoxEndpoint_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxEndpoint.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter the API endpoint.");
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter an email address.");
            }
        }

        private void ApiSettingsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
