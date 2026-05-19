using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace NwsAlerts
{
    public partial class JsonDlog : Form
    {
        /// <summary>
        /// Gets or sets the JSON text
        /// </summary>
        public string JsonText
        {
            get
            {
                return textBoxJson.Text;
            }
            set
            {
                textBoxJson.Text = value;
            }
        }

        public JsonDlog()
        {
            InitializeComponent();
        }

        private void JsonDlog_Load(object sender, EventArgs e)
        {

        }
    }
}
