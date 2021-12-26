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
    internal partial class GroupSettingsPage : UserControl
    {
        List<AlertGroup> alertGroups;

        public List<AlertGroup> Groups
        {
            get
            { 
                return alertGroups;
            }
        }

        public GroupSettingsPage(List<AlertGroup> groups)
        {
            InitializeComponent();
            
            alertGroups = new List<AlertGroup>();
            alertGroups.AddRange(groups);

            foreach(AlertGroup group in groups)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewGroups, group.Name, group.CssClass);
                dataGridViewGroups.Rows.Add(row);
            }
        }
    }
}
