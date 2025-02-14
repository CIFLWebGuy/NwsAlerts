using NwsAlertApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
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
        private PropertyForm propertyWindow;
        private bool resetCrawl;
        private NamedPipeClientStream crawlPipe;
        private SplashForm splashDlog;
        private string crawlMessage;

        public FormMain()
        {
            InitializeComponent();

            splashDlog = new SplashForm();
            splashDlog.Show();
            Application.DoEvents();

            selectedEvents = new List<AlertEvent>();
            groupList = new List<AlertGroup>();

            splashDlog.StatusText = "Loading configuration...";
            LoadConfiguration();

            api = new ApiClient(apiEndpoint, userAgent);
            crawlMessage = "";
            propertyWindow = new PropertyForm();
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

            foreach (XElement group in groups.Elements())
            {
                AlertGroup item = new AlertGroup();
                item.Name = group.Attribute("name").Value;
                item.ID = int.Parse(group.Attribute("id").Value);
                item.CssClass = group.Attribute("class").Value;
                item.ShowEvent = group.Attribute("showEvent").Value == "true";

                groupList.Add(item);
                listViewAlerts.Groups.Add(item.ID.ToString(), item.Name);
            }

            foreach(XElement item in events.Elements())
            {
                AlertEvent alertEvent = new AlertEvent();
                alertEvent.Name = item.Attribute("name").Value;
                alertEvent.GroupID = int.Parse(item.Attribute("groupID").Value);
                alertEvent.DisplayLocation = (DisplayLocation)int.Parse(item.Attribute("location").Value);
                alertEvent.ImageKey = item.Attribute("icon").Value.ToString();

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
                element.SetAttributeValue("icon", item.ImageKey);
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

            foreach(TreeNode root in treeViewZones.Nodes)
            {
                foreach (TreeNode node in root.Nodes)
                {
                    if (node.Checked)
                        alertFilters.Area.Zones.Add(node.Tag.ToString());
                }
            }

            return alertFilters;
        }

        private void PopulateAlertList()
        {
            ListViewItem selectedItem = null;
            
            if(listViewAlerts.SelectedItems.Count != 0)
                selectedItem = listViewAlerts.SelectedItems[0];

            listViewAlerts.Items.Clear();

            foreach(Alert alert in activeAlerts)
            {
                AlertEvent alertEvent = selectedEvents.Where(e => e.Name == alert.Event).FirstOrDefault();

                ListViewItem item = new ListViewItem();
                item.Text = alert.Event;
                item.SubItems.Add(alert.AreaDesc);

                if (alert.Ends != null)
                {
                    item.SubItems.Add($"until {alert.Ends}");
                }
                else
                {
                    item.SubItems.Add($" until {alert.Expires}");
                }

                item.ImageKey = alertEvent.ImageKey;
                item.Group = listViewAlerts.Groups[alertEvent.GroupID.ToString()];
                item.Tag = alert.ID;
                item.ToolTipText = alert.AreaDesc;

                string description = alert.Description.ToUpper();
                string instruction = string.IsNullOrEmpty(alert.Instruction) ? "" : alert.Instruction.ToUpper();

                if (description.Contains("TORNADO EMERGENCY") || instruction.Contains("TORNADO EMERGENCY"))
                {
                    alert.Level = AlertLevel.TornadoEmergency;
                    item.Text = "*** TORNADO EMERGENCY ***";
                    item.ImageKey = "Tornado Emergency";
                }
                else if (description.Contains("PARTICULARLY DANGEROUS SITUATION") || instruction.Contains("PARTICULARLY DANGEROUS SITUATION"))
                {
                    alert.Level = AlertLevel.PDS;
                    item.Text = $"*** PDS {alert.Event.ToUpper()} ***";
                    item.SubItems[0].ForeColor = Color.DarkRed;

                    switch(alert.Event.ToUpper())
                    {
                        case "TORNADO WATCH":
                            item.ImageKey = "Tornado Watch PDS";
                            break;

                        case "TORNADO WARNING":
                            item.ImageKey = "Tornado Warning PDS";
                            break;

                        case "SEVERE THUNDERSTORM WATCH":
                            item.ImageKey = "Thunderstorm Watch PDS";
                            break;

                        case "SEVERE THUNDERSTORM WARNING":
                            item.ImageKey = "Thunderstorm Warning PDS";
                            break;
                    }
                }

                listViewAlerts.Items.Add(item);

                if(selectedItem != null && item.Tag == selectedItem.Tag)
                    item.Selected = true;
            }
        }

        private void GenerateOutput()
        {
            string doc = File.ReadAllText("Warnings.html");
            StringBuilder body = new StringBuilder();
            StringBuilder crawl = new StringBuilder();
            int prevGroupID = -1;

            foreach (AlertEvent alertEvent in selectedEvents)
            {
                var alerts = activeAlerts.Where(e => e.Event == alertEvent.Name);
                
                foreach (var alert in alerts)
                {
                    if (alertEvent.DisplayLocation == DisplayLocation.Main)
                    {
                        AlertGroup group = groupList.Where(g => g.ID == alertEvent.GroupID).Single();

                        if (group.ID != prevGroupID)
                        {
                            body.AppendLine($"<h2 class=\"{group.CssClass}\">{group.Name}</h2>");
                            prevGroupID = group.ID;
                        }

                        if (group.ShowEvent)
                        {
                            if (alert.Level == AlertLevel.TornadoEmergency)
                            {
                                body.AppendLine($"<p><h3>*** TORNADO EMERGENCY ***</h3>{alert.AreaDesc}<br />until {alert.Expires:g}</p>");
                            }
                            else if (alert.Level == AlertLevel.PDS)
                            {
                                body.AppendLine($"<p><h3>** PDS {alert.Event} **</h3>{alert.AreaDesc}<br />until {alert.Expires:g}</p>");
                            }
                            else
                            {
                                body.AppendLine($"<p><h3>{alert.Event}</h3>{alert.AreaDesc}<br />until {alert.Expires:g}</p>");
                            }
                        }
                        else
                        {
                            if (alert.Level == AlertLevel.TornadoEmergency)
                            {
                                body.AppendLine($"<p><b>*** TORNADO EMERGENCY ***</b><br />{alert.AreaDesc}<br />until {alert.Expires:g}</p>");
                            }
                            else if (alert.Level == AlertLevel.PDS)
                            {
                                body.AppendLine($"<p><b>** PDS ALERT **</b><br />{alert.AreaDesc}<br />until {alert.Expires:g}</p>");
                            }
                            else
                            {
                                body.AppendLine($"<p>{alert.AreaDesc} until {alert.Expires:g}</p>");
                            }
                        }

                        //body.AppendLine("<p>&nbsp;</p>");
                    }
                    else if (alertEvent.DisplayLocation == DisplayLocation.Crawl)
                    {
                        crawl.Append("●   ");
                        crawl.Append(alert.Headline.ToUpper());
                        crawl.Append("...");
                        crawl.Append(alert.Description.Replace("\r", "").Replace("\n", " ").ToUpper());
                        crawl.Append("   ");
                    }
                }
            }

            if (body.Length == 0)
            {
                body.AppendLine("<i>No active alerts</i>");
            }
            string output = doc.Replace("{alerts}", body.ToString());

            if (crawl.Length == 0)
            {
                if (crawlMessage == "")
                    crawl.Append("SEVERE WEATHER IS POSSIBLE TODAY.  PLEASE REMAIN ALERT FOR CHANGING CONDITIONS.");
                else
                    crawl.Append(crawlMessage);
            }

            try
            {
                File.WriteAllText($"{outputPath}\\Warnings.html", output);
                //File.WriteAllText($"{outputPath}\\crawl.txt", crawl.ToString());

                SendCrawl(crawl.ToString());
            }
            catch (IOException)
            {
                // do nothing
            }

            resetCrawl = false;
        }

        /// <summary>
        /// Sends the specifed text to the crawl without forcing a refresh.
        /// </summary>
        /// <param name="text">The text to send.</param>
        void SendCrawl(string text)
        {
            SendCrawl(text, false);
        }

        /// <summary>
        /// Sends the specified the the crawl, and optionally forces a refresh of the crawl.
        /// </summary>
        /// <param name="text">The text to send.</param>
        /// <param name="reset">Specifies whether the crawl is reset or not.</param>
        void SendCrawl(string text, bool reset)
        {
            if(reset)
            {
                text = "!RESET!" + text.ToUpper();
            }
            else
            {
                text = text.ToUpper();
            }

            if (crawlPipe != null && crawlPipe.IsConnected)
            {
                byte[] message = Encoding.UTF8.GetBytes(text);
                crawlPipe.Write(message, 0, message.Length);
            }

            if (crawlPipe != null && !crawlPipe.IsConnected)
                toolStripButtonCrawl.Checked = false;
        }

        private void InitalizeApplication(SplashForm dlog)
        {
            dlog.StatusText = "Retrieving event types...";
            List<String> events = api.GetEventTypes();

            int selectedMessages = (int)Properties.Settings.Default.MessageTypes;
            int selectedSeverity = (int)Properties.Settings.Default.Severity;

            dlog.StatusText = "Initializing event grid...";
            DataGridViewComboBoxColumn col = dataGridViewEvents.Columns["Group"] as DataGridViewComboBoxColumn;
            col.Items.Add("(none)");

            foreach (AlertGroup item in groupList)
            {
                col.Items.Add(item.Name);
            }

            col = dataGridViewEvents.Columns["LocationName"] as DataGridViewComboBoxColumn;
            col.Items.Add("Main");
            col.Items.Add("Crawl");

            timerRefresh.Interval = 60000 * refreshInterval;
            statusLabelAvailable.Text = $"Available events: {events.Count}";
            
            dlog.StatusText = "Populating alert events...";

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

            dlog.StatusText = "Retrieving state list...";

            foreach (string item in api.GetStates())
            {
                toolStripComboBoxState.Items.Add(item);
            }

            if (toolStripComboBoxState.Items.Count > 0)
                toolStripComboBoxState.SelectedIndex = 0;

            loading = false;

            propertyWindow = new PropertyForm();
        }

        private Dictionary<string, string> GetImageMap()
        {
            Dictionary<string, string> imageMap = new Dictionary<string, string>();

            foreach(AlertEvent alert in selectedEvents)
            {
                imageMap.Add(alert.Name, alert.ImageKey);
            }

            return imageMap;
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

            if(crawlPipe != null)
                crawlPipe.Dispose();
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
                resetCrawl = false;
                loading = true;
                
                InitalizeApplication(splashDlog);

                splashDlog.Close();
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            using(SettingsDlog dlog = new SettingsDlog())
            {
                dlog.NeedImageSettings += SettingsDlog_NeedImageSettings;
                dlog.ShowDialog();
            }
        }

        private void SettingsDlog_NeedImageSettings(object sender, NeedImageSettingsArgs e)
        {
            e.Images = imageListTiles;
            e.ImageMap = GetImageMap();
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
                    else
                        alertEvent.GroupID = 0;
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
        }

        private void toolStripComboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewZones.Nodes.Clear();
            treeViewZones.BeginUpdate();

            GeographicArea area = new GeographicArea();
            area.StateCodes.Add(toolStripComboBoxState.Text);

            List<Zone> zones = api.GetZones(area, false);
            List<string> wfoGroups = zones.Select(z => z.Cwa[0]).Distinct().ToList();
            
            foreach(string g in wfoGroups)
            {
                NwsOffice office = api.GetOffice(g);

                TreeNode root = new TreeNode();

                root.Text = $"{office.Name} ({g})";
                root.Name = g;
                
                treeViewZones.Nodes.Add(root);
            }

            foreach (Zone zone in zones)
            {
                if(zone.NwsZoneType == NwsZoneType.Land && zone.ID.Substring(2,1) == "C")
                {
                    TreeNode node = new TreeNode();
                    node.Text = $"{zone.ID} - {zone.Name} ({zone.State})";
                    node.Tag = zone.ID;

                    TreeNode parent = treeViewZones.Nodes[zone.Cwa[0]];
                    parent.Nodes.Add(node);
                }
            }

            treeViewZones.EndUpdate();
            resetCrawl = true;
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
            activeAlerts = response.Alerts.Where(a => a.Ends != null ? a.Ends > DateTime.Now : a.Expires > DateTime.Now).ToList();
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

        private void toolStripButtonCrawl_Click(object sender, EventArgs e)
        {
            if(toolStripButtonCrawl.Checked)
            {
                try
                {
                    crawlPipe = new NamedPipeClientStream(".", "AlertCrawl", PipeDirection.InOut);
                    crawlPipe.Connect(1000);
                    crawlPipe.ReadMode = PipeTransmissionMode.Message;
                }
                catch(IOException ex)
                {
                    MessageBox.Show($"Unable to connect to alert crawl due to a problem: {ex.Message}", "Connect to crawl");
                    crawlPipe.Dispose();
                    crawlPipe = null;

                    toolStripButtonCrawl.Checked = false;
                }
                catch(TimeoutException)
                {
                    MessageBox.Show($"Unable to connect to alert crawl. Connection timed out.", "Connect to Crawl");
                    crawlPipe.Dispose();
                    crawlPipe = null;

                    toolStripButtonCrawl.Checked = false;
                }
            }
            else
            {
                if(crawlPipe != null)
                {
                    crawlPipe.Dispose();
                    crawlPipe = null;
                }    
            }
        }

        private void toolStripButtonSendCrawl_ButtonClick(object sender, EventArgs e)
        {
            crawlMessage = toolStripTextBoxCrawl.Text;
            SendCrawl(toolStripTextBoxCrawl.Text);
        }

        private void sendToCrawlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crawlMessage = toolStripTextBoxCrawl.Text;
            SendCrawl(toolStripTextBoxCrawl.Text);
        }

        private void resetAndSendToCrawlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crawlMessage = toolStripTextBoxCrawl.Text;
            SendCrawl(toolStripTextBoxCrawl.Text, true);
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crawlMessage = "";
            SendCrawl("SEVERE WEATHER IS POSSIBLE TODAY.  PLEASE REMAIN ALERT FOR CHANGING CONDITIONS.", true);
        }

        private void linkLabelExportWarning_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (richTextBoxAlert.Text == "")
                return;

            if(listViewAlerts.SelectedItems.Count == 0)
                return;

            Alert alert = activeAlerts.Where(a => a.ID == listViewAlerts.SelectedItems[0].Tag.ToString()).Single();

            try
            {
                StringBuilder expires = new StringBuilder();
                
                if(alert.Expires.HasValue)
                {
                    DateTime untilTime = alert.Expires.Value;

                    if (alert.Ends.HasValue && alert.Ends.Value > untilTime)
                        untilTime = alert.Ends.Value;

                    expires.Append("Until ");

                    if(untilTime == DateTime.Now.Date)
                    {
                        expires.Append(untilTime.ToString("t"));
                    }
                    else if (untilTime.Subtract(DateTime.Today).Days < 7)
                    {
                        expires.Append(untilTime.ToString("hh:mm tt dddd"));
                    }
                    else
                    {
                        expires.Append(untilTime.ToString("g"));
                    }

                    File.WriteAllText(Path.Combine(Properties.Settings.Default.WarningOutputPath, "Expires.txt"), expires.ToString());
                }

                File.WriteAllText(Path.Combine(Properties.Settings.Default.WarningOutputPath, "Warning.txt"), richTextBoxAlert.Text);
                File.WriteAllText(Path.Combine(Properties.Settings.Default.WarningOutputPath, "AlertTitle.txt"), alert.Event);
            }
            catch (IOException ex)
            {
                MessageBox.Show(this, $"A problem was encounterd while exporting the warning text. {ex.Message}", "Export Warning Text", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAlerts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAlerts.SelectedItems.Count == 0)
            {
                richTextBoxAlert.Text = "";
                return;
            }

            var alert = activeAlerts.Where(a => a.ID == listViewAlerts.SelectedItems[0].Tag.ToString()).FirstOrDefault();

            if(alert != null)
            {
                richTextBoxAlert.Text = alert.Headline + "\n\n" + alert.Description + alert.Instruction;
            }
        }

        private void listViewAlerts_DoubleClick(object sender, EventArgs e)
        {
            if (listViewAlerts.SelectedItems.Count == 0)
                return;

            propertyWindow.BrowseAlert(activeAlerts.Where(a => a.ID == listViewAlerts.SelectedItems[0].Tag.ToString()).FirstOrDefault());
            propertyWindow.Show();
        }

        private void treeViewZones_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
                return;

            foreach(TreeNode node in e.Node.Nodes)
            {
                node.Checked = e.Node.Checked;
            }
        }
    }
}
