using NwsAlertApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace NwsAlerts
{
    public partial class FormMain : Form
    {
        private readonly string userAgent = "vbwcomputers.com, ciflwebguy@gmail.com";
        private readonly ApiClient api;
        private List<AlertEvent> selectedEvents;
        private List<AlertGroup> groupList;
        public bool loading;
        private string apiEndpoint;
        private int refreshInterval;
        private string email;
        private string outputPath;
        private List<Alert> activeAlerts;
        private CrawlWindow crawlWin;
        private PropertyForm propertyWindow;

        private readonly string defaultCrawl = "●  SEVERE WEATHER IS POSSIBLE TODAY.  PLEASE REMAIN ALERT FOR CHANGING CONDITIONS.";
        public FormMain()
        {
            InitializeComponent();

            selectedEvents = new List<AlertEvent>();
            groupList = new List<AlertGroup>();

            LoadConfiguration();

            api = new ApiClient(apiEndpoint, userAgent);

            DataGridViewComboBoxColumn col = dataGridViewEvents.Columns["Group"] as DataGridViewComboBoxColumn;
            col.Items.Add("(none)");
            
            foreach(AlertGroup item in groupList)
            {
                col.Items.Add(item.Name);
            }

            col = dataGridViewEvents.Columns["LocationName"] as DataGridViewComboBoxColumn;
            col.Items.Add("Main");
            col.Items.Add("Crawl");

            timerRefresh.Interval = 60000 * refreshInterval;
        }
        
        private void LoadConfiguration()
        {
            XDocument doc = XDocument.Load("Alerts.xml");
            
            XElement root = doc.Element("configuration");
            XElement groups = root.Element("groups");
            XElement events = root.Element("events");
            XElement api = root.Element("api");
            XElement http = root.Element("http");

            apiEndpoint = api.Attribute("endpoint").Value;
            email = api.Attribute("email").Value;
            refreshInterval = int.Parse(api.Attribute("refresh").Value);
            outputPath = http.Attribute("output").Value;

            foreach(XElement group in groups.Elements())
            {
                AlertGroup item = new AlertGroup();
                item.Name = group.Attribute("name").Value;
                item.ID = int.Parse(group.Attribute("id").Value);
                item.CssClass = group.Attribute("class").Value;
                item.ShowEvent = group.Attribute("showEvent").Value == "true";

                groupList.Add(item);
            }

            foreach(XElement item in events.Elements())
            {
                AlertEvent alertEvent = new AlertEvent();
                alertEvent.Name = item.Attribute("name").Value;
                alertEvent.GroupID = int.Parse(item.Attribute("groupID").Value);
                alertEvent.DisplayLocation = (DisplayLocation)int.Parse(item.Attribute("location").Value);

                selectedEvents.Add(alertEvent); 
            }
        }

        private void SaveConfiguration()
        {
            XElement root = new XElement("configuration");
            XElement groups = new XElement("groups");
            XElement events = new XElement("events");
            XElement api = new XElement("api");
            XElement http = new XElement("http");

            api.SetAttributeValue("endpoint", apiEndpoint);
            api.SetAttributeValue("email", email);
            api.SetAttributeValue("refresh", refreshInterval);

            http.SetAttributeValue("output", outputPath);

            foreach(AlertGroup item in groupList)
            {
                XElement element = new XElement("group");
                element.SetAttributeValue("name", item.Name);
                element.SetAttributeValue("id", item.ID);
                element.SetAttributeValue("class", item.CssClass);
                element.SetAttributeValue("showEvent", item.ShowEvent ? "true" : "false");
                groups.Add(element);
            }

            foreach(AlertEvent item in selectedEvents)
            {
                XElement element = new XElement("event");
                element.SetAttributeValue("name", item.Name);
                element.SetAttributeValue("groupID", item.GroupID);
                element.SetAttributeValue("location", (int)item.DisplayLocation);

                events.Add(element);
            }

            root.Add(api);
            root.Add(http);
            root.Add(groups);
            root.Add(events);
            root.Save("Alerts.xml");
        }

        private void AddGridRow(AlertEvent alertEvent)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewEvents);
            row.Cells[0].Value = alertEvent.Name;

            if (alertEvent.DisplayLocation == DisplayLocation.Main)
                row.Cells[2].Value = "Main";
            else
                row.Cells[2].Value = "Crawl";

            AlertGroup group = groupList.Where(e => e.ID == alertEvent.GroupID).FirstOrDefault();

            if (group != null)
            {
                row.Cells[1].Value = group.Name;
            }
            else
            {
                row.Cells[1].Value = "(none)";
            }

            dataGridViewEvents.Rows.Add(row);
        }

        private bool IsActiveEvent(string item)
        {
            if (selectedEvents.Where(e => e.Name == item).Count() != 0)
                return true;

            return false;
        }

        private void RefreshAlerts()
        {
            statusLabelRetrieve.Visible = true;
            Refresh();

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        private AlertFilters GetFilters()
        {
            AlertFilters alertFilters = new AlertFilters();
            alertFilters.Area.StateCodes.Add(toolStripComboBoxState.Text);
            alertFilters.Active = true;

            if (checkedListBoxMessageType.GetItemChecked(0))
                alertFilters.MessageTypes |= MessageTypes.Alert;

            if (checkedListBoxMessageType.GetItemChecked(1))
                alertFilters.MessageTypes |= MessageTypes.Update;

            if (checkedListBoxMessageType.GetItemChecked(2))
                alertFilters.MessageTypes |= MessageTypes.Cancel;

            if (checkedListBoxSeverity.GetItemChecked(0))
                alertFilters.Severity |= Severities.Unknown;

            if (checkedListBoxSeverity.GetItemChecked(1))
                alertFilters.Severity |= Severities.Minor;

            if (checkedListBoxSeverity.GetItemChecked(2))
                alertFilters.Severity |= Severities.Moderate;

            if (checkedListBoxSeverity.GetItemChecked(3))
                alertFilters.Severity |= Severities.Severe;

            if (checkedListBoxSeverity.GetItemChecked(4))
                alertFilters.Severity |= Severities.Extreme;

            foreach (AlertEvent item in selectedEvents)
            {
                alertFilters.Events.Add(item.Name);
            }

            foreach(ListViewItem item in listViewZones.CheckedItems)
            {
                alertFilters.Area.Zones.Add(item.Text);
            }

            return alertFilters;
        }

        private void PopulateAlertList()
        {
            dataGridViewAlerts.Rows.Clear();

            foreach(Alert alert in activeAlerts)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewAlerts, alert.Event, alert.Effective, alert.Expires, alert.AreaDesc);
                dataGridViewAlerts.Rows.Add(row);
            }

            dataGridViewAlerts.AutoResizeRows();
        }

        private ListViewGroup GetZoneGroup(string wfo)
        {
            foreach(ListViewGroup group in listViewZones.Groups)
            {
                if(group.Header.Contains($"({wfo})"))
                    return group;
            }

            return null;
        }

        private void GenerateOutput()
        {
            string doc = File.ReadAllText("Warnings.html");
            StringBuilder body = new StringBuilder();
            StringBuilder crawl = new StringBuilder();
            Dictionary<int, List<Tuple<Alert, AlertEvent>>> alerts = new Dictionary<int, List<Tuple<Alert, AlertEvent>>>();

            foreach(AlertGroup group in groupList)
            {
                alerts.Add(group.ID, new List<Tuple<Alert, AlertEvent>>());
            }

            foreach(Alert alert in activeAlerts)
            {
                AlertEvent ae = selectedEvents.Where(evt => evt.Name == alert.Event).FirstOrDefault();
                
                if(ae != null && ae.DisplayLocation == DisplayLocation.Main)
                    alerts[ae.GroupID].Add(new Tuple<Alert, AlertEvent>(alert, ae));
            }

            foreach (var item in alerts.Where(a => a.Value.Count > 0))
            {
                AlertGroup group = groupList.Where(g => g.ID == item.Key).Single();

                body.AppendLine($"<h2 class=\"{group.CssClass}\">{group.Name}</h2>");

                foreach(Tuple<Alert, AlertEvent> alert in item.Value)
                {
                    if (alert.Item2.DisplayLocation == DisplayLocation.Main)
                    {
                        if (group.ShowEvent)
                        {
                            body.AppendLine($"<p><h3>{alert.Item1.Event}</h3>{alert.Item1.AreaDesc}<br />until {alert.Item1.Expires:g}</p>");
                        }
                        else
                        {
                            body.AppendLine($"{alert.Item1.AreaDesc} until {alert.Item1.Expires:g}</p>");
                        }
                    }
                }
                body.AppendLine("<p>&nbsp;</p>");
            }

            foreach (var items in alerts)
            {
                foreach (var alert in items.Value)
                {
                    if (alert.Item2.DisplayLocation == DisplayLocation.Crawl)
                    {
                        crawl.Append("●   ");
                        crawl.Append(alert.Item1.Headline.ToUpper());
                        crawl.Append(alert.Item1.Description.Replace("\r", "").Replace("\n", " ").ToUpper());
                        crawl.Append("   ");
                    }
                }
            }

            if (body.Length == 0)
            {
                body.AppendLine("<i>No active alerts</i>");
            }
            string output = doc.Replace("{alerts}", body.ToString());

            File.WriteAllText($"{outputPath}\\Warnings.html", output);
            File.WriteAllText($"{outputPath}\\crawl.txt", crawl.ToString());

            if (crawl.Length > 0)
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate () { crawlWin.CrawlText = crawl.ToString(); });
                else
                    crawlWin.CrawlText = crawl.ToString();
            }
            else
            {
                if (InvokeRequired)
                    Invoke(new MethodInvoker(delegate () { crawlWin.CrawlText = defaultCrawl; }));
                else
                    crawlWin.CrawlText = defaultCrawl;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            Properties.Settings.Default.MessageTypes = MessageTypes.None;
            Properties.Settings.Default.Severity = Severities.None;

            for (int i = 0; i < 3; i++)
            {
                if (checkedListBoxMessageType.GetItemChecked(i))
                    Properties.Settings.Default.MessageTypes += (int)Math.Pow(0x2, i);
            }

            for (int i = 0; i < 5; i++)
            {
                if (checkedListBoxSeverity.GetItemChecked(i))
                    Properties.Settings.Default.Severity += (int)Math.Pow(0x2, i);
            }

            Properties.Settings.Default.Save();
            SaveConfiguration();
        }

        private void checkedListBoxEvent_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!loading)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    AlertEvent eventItem = new AlertEvent();
                    eventItem.Name = checkedListBoxEvent.Items[e.Index].ToString();
                    selectedEvents.Add(eventItem);

                    AddGridRow(eventItem);
                }
                else
                {
                    string key = checkedListBoxEvent.SelectedItem.ToString();

                    DataGridViewRow row = null;

                    foreach (DataGridViewRow r in dataGridViewEvents.Rows)
                    {
                        if (r.Cells["EventName"].Value.ToString() == key)
                        {
                            row = r;
                            break;
                        }
                    }

                    if (row != null)
                    {
                        selectedEvents.Remove(selectedEvents.Where(x => x.Name == row.Cells["EventName"].Value.ToString()).Single());
                        dataGridViewEvents.Rows.Remove(row);
                    }
                }
            }

            dataGridViewEvents.Sort(dataGridViewEvents.Columns[0], ListSortDirection.Ascending);
            statusLabelActive.Text = $"Selected: {selectedEvents.Count}";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<String> events = api.GetEventTypes();
            int selectedMessages = (int)Properties.Settings.Default.MessageTypes;
            int selectedSeverity = (int)Properties.Settings.Default.Severity;

            loading = true;
            statusLabelAvailable.Text = $"Available events: {events.Count}";

            foreach (string item in events)
            {
                if (IsActiveEvent(item))
                {
                    checkedListBoxEvent.Items.Add(item, true);
                    AddGridRow(selectedEvents.Where(x => x.Name == item).Single());
                }
                else
                {
                    checkedListBoxEvent.Items.Add(item, false);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if ((selectedMessages & (int)Math.Pow(0x2, i)) > 0)
                    checkedListBoxMessageType.SetItemChecked(i, true);
            }

            for (int i = 0; i < 5; i++)
            {
                if ((selectedSeverity & (int)Math.Pow(0x2, i)) > 0)
                    checkedListBoxSeverity.SetItemChecked(i, true);
            }

            foreach (string item in api.GetStates())
            {
                toolStripComboBoxState.Items.Add(item);
            }

            if (toolStripComboBoxState.Items.Count > 0)
                toolStripComboBoxState.SelectedIndex = 0;

            loading = false;

            crawlWin = new CrawlWindow();
            crawlWin.CrawlText = defaultCrawl;
            crawlWin.Show(this);

            propertyWindow = new PropertyForm();
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            using(SettingsDlog dlog = new SettingsDlog())
            {
                dlog.ShowDialog();
            }
        }

        private void dataGridViewEvents_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewEvents.Rows[e.RowIndex];
            string eventName = row.Cells["EventName"].Value.ToString();
            AlertEvent alertEvent = selectedEvents.Where(x => x.Name == eventName).Single();

            switch(e.ColumnIndex)
            {
                case 1:
                    AlertGroup group = groupList.Where(x => x.Name == row.Cells["Group"].Value.ToString()).FirstOrDefault();

                    if(group != null)
                        alertEvent.GroupID = group.ID;
                    break;

                case 2:
                    if (row.Cells[2].Value.ToString() == "Main")
                        alertEvent.DisplayLocation = DisplayLocation.Main;
                    else
                        alertEvent.DisplayLocation = DisplayLocation.Crawl;
                    break;
            }
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshAlerts();
            crawlWin.ResetCrawl();
        }

        private void dataGridViewAlerts_SelectionChanged(object sender, EventArgs e)
        {
            richTextBoxAlert.Text = "";

            if (dataGridViewAlerts.SelectedRows.Count == 0)
                return;

            Alert alert = activeAlerts[dataGridViewAlerts.SelectedRows[0].Index];
            richTextBoxAlert.Text = $"{alert.Headline}\n\n{alert.Description}";
        }

        private void toolStripComboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewZones.Items.Clear();
            listViewZones.Groups.Clear();

            GeographicArea area = new GeographicArea();
            area.StateCodes.Add(toolStripComboBoxState.Text);

            List<Zone> zones = api.GetZones(area, false);
            List<string> wfoGroups = zones.Select(z => z.Cwa[0]).Distinct().ToList();
            
            foreach(string g in wfoGroups)
            {
                NwsOffice office = api.GetOffice(g);

                ListViewGroup group = new ListViewGroup();
                group.Header = $"{office.Name} ({g})";
                group.Name = g;
                
                listViewZones.Groups.Add(group);
            }

            foreach (Zone zone in zones)
            {
                if(zone.NwsZoneType == NwsZoneType.Land && zone.ID.Substring(2,1) == "C")
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = $"{zone.ID}";
                    lvi.SubItems.Add(zone.Name);
                    lvi.SubItems.Add(zone.State);
                    lvi.Group = GetZoneGroup(zone.Cwa[0]);

                    listViewZones.Items.Add(lvi);
                }
            }
        }

        private void toolStripButtonConnect_CheckedChanged(object sender, EventArgs e)
        {
            timerRefresh.Enabled = toolStripButtonConnect.Checked;

            if (toolStripButtonConnect.Checked)
                RefreshAlerts();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            RefreshAlerts();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            AlertFilters filters = null;

            Invoke((MethodInvoker)delegate () { filters = GetFilters(); });

            AlertResponse response = api.GetAlerts(filters);
            activeAlerts = response.Alerts.Where(a => a.Expires > DateTime.Now).ToList();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            PopulateAlertList();

            statusLabelRetrieve.Visible = false;
            statusLabelAlerts.Text = $"Active Alerts: {activeAlerts.Count}";
            statusLabelUpdate.Text = $"Last update: {DateTime.Now:g}";

            if (timerRefresh.Enabled)
                statusLabelUpdate.Image = Properties.Resources.Connect_16x;
            else
                statusLabelUpdate.Image = Properties.Resources.Disconnect_16x;

            Task.Run(() => { GenerateOutput(); });
        }

        private void dataGridViewAlerts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Alert alert = activeAlerts[dataGridViewAlerts.SelectedRows[0].Index];

            propertyWindow.BrowseAlert(alert);
            propertyWindow.Show();
        }
    }
}
