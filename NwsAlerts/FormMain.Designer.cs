
namespace NwsAlerts
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabelUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelAvailable = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelAlerts = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelRetrieve = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxState = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCrawl = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxCrawl = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSendCrawl = new System.Windows.Forms.ToolStripSplitButton();
            this.sendToCrawlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAndSendToCrawlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxMessageType = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxEvent = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxSeverity = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LocationName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewAlerts = new System.Windows.Forms.DataGridView();
            this.AlertType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxAlert = new System.Windows.Forms.RichTextBox();
            this.listViewZones = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabelExportWarning = new System.Windows.Forms.LinkLabel();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlerts)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelUpdate,
            this.statusLabelAvailable,
            this.statusLabelActive,
            this.statusLabelAlerts,
            this.statusLabelRetrieve,
            this.statusLabelError});
            this.statusStrip.Location = new System.Drawing.Point(0, 778);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1038, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabelUpdate
            // 
            this.statusLabelUpdate.Image = global::NwsAlerts.Properties.Resources.Disconnect_16x;
            this.statusLabelUpdate.Name = "statusLabelUpdate";
            this.statusLabelUpdate.Size = new System.Drawing.Size(169, 19);
            this.statusLabelUpdate.Text = "Last update: Not connected";
            // 
            // statusLabelAvailable
            // 
            this.statusLabelAvailable.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelAvailable.Name = "statusLabelAvailable";
            this.statusLabelAvailable.Size = new System.Drawing.Size(108, 19);
            this.statusLabelAvailable.Text = "Available events: 0";
            // 
            // statusLabelActive
            // 
            this.statusLabelActive.Name = "statusLabelActive";
            this.statusLabelActive.Size = new System.Drawing.Size(52, 19);
            this.statusLabelActive.Text = "Active: 0";
            // 
            // statusLabelAlerts
            // 
            this.statusLabelAlerts.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelAlerts.Name = "statusLabelAlerts";
            this.statusLabelAlerts.Size = new System.Drawing.Size(89, 19);
            this.statusLabelAlerts.Text = "Active Alerts: 0";
            // 
            // statusLabelRetrieve
            // 
            this.statusLabelRetrieve.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelRetrieve.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelRetrieve.Image")));
            this.statusLabelRetrieve.Name = "statusLabelRetrieve";
            this.statusLabelRetrieve.Size = new System.Drawing.Size(115, 20);
            this.statusLabelRetrieve.Text = "Retrieving data...";
            this.statusLabelRetrieve.Visible = false;
            // 
            // statusLabelError
            // 
            this.statusLabelError.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelError.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelError.Image")));
            this.statusLabelError.Name = "statusLabelError";
            this.statusLabelError.Size = new System.Drawing.Size(149, 20);
            this.statusLabelError.Text = "Unable to retrieve data.";
            this.statusLabelError.Visible = false;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBoxState,
            this.toolStripSeparator2,
            this.toolStripButtonConnect,
            this.toolStripButtonRefresh,
            this.toolStripSeparator1,
            this.toolStripButtonCrawl,
            this.toolStripLabel2,
            this.toolStripTextBoxCrawl,
            this.toolStripButtonSendCrawl,
            this.toolStripSeparator3,
            this.toolStripButtonSettings});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1038, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Area:";
            // 
            // toolStripComboBoxState
            // 
            this.toolStripComboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxState.Name = "toolStripComboBoxState";
            this.toolStripComboBoxState.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBoxState.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxState_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.CheckOnClick = true;
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect.Image")));
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonConnect.Text = "Connect";
            this.toolStripButtonConnect.CheckedChanged += new System.EventHandler(this.toolStripButtonConnect_CheckedChanged);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Get data";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCrawl
            // 
            this.toolStripButtonCrawl.CheckOnClick = true;
            this.toolStripButtonCrawl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrawl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCrawl.Image")));
            this.toolStripButtonCrawl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrawl.Name = "toolStripButtonCrawl";
            this.toolStripButtonCrawl.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCrawl.Text = "Connect to crawl";
            this.toolStripButtonCrawl.Click += new System.EventHandler(this.toolStripButtonCrawl_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel2.Text = "Crawl text:";
            // 
            // toolStripTextBoxCrawl
            // 
            this.toolStripTextBoxCrawl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxCrawl.Name = "toolStripTextBoxCrawl";
            this.toolStripTextBoxCrawl.Size = new System.Drawing.Size(600, 25);
            // 
            // toolStripButtonSendCrawl
            // 
            this.toolStripButtonSendCrawl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSendCrawl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToCrawlToolStripMenuItem,
            this.resetAndSendToCrawlToolStripMenuItem,
            this.toolStripSeparator4,
            this.resetToDefaultToolStripMenuItem});
            this.toolStripButtonSendCrawl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSendCrawl.Image")));
            this.toolStripButtonSendCrawl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSendCrawl.Name = "toolStripButtonSendCrawl";
            this.toolStripButtonSendCrawl.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonSendCrawl.Text = "Send text to crawl";
            this.toolStripButtonSendCrawl.Click += new System.EventHandler(this.toolStripButtonSendCrawl_Click);
            // 
            // sendToCrawlToolStripMenuItem
            // 
            this.sendToCrawlToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sendToCrawlToolStripMenuItem.Name = "sendToCrawlToolStripMenuItem";
            this.sendToCrawlToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sendToCrawlToolStripMenuItem.Text = "Send to crawl";
            this.sendToCrawlToolStripMenuItem.Click += new System.EventHandler(this.sendToCrawlToolStripMenuItem_Click);
            // 
            // resetAndSendToCrawlToolStripMenuItem
            // 
            this.resetAndSendToCrawlToolStripMenuItem.Name = "resetAndSendToCrawlToolStripMenuItem";
            this.resetAndSendToCrawlToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.resetAndSendToCrawlToolStripMenuItem.Text = "Reset and send to crawl";
            this.resetAndSendToCrawlToolStripMenuItem.Click += new System.EventHandler(this.resetAndSendToCrawlToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // resetToDefaultToolStripMenuItem
            // 
            this.resetToDefaultToolStripMenuItem.Name = "resetToDefaultToolStripMenuItem";
            this.resetToDefaultToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.resetToDefaultToolStripMenuItem.Text = "Reset to default";
            this.resetToDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message type:";
            // 
            // checkedListBoxMessageType
            // 
            this.checkedListBoxMessageType.CheckOnClick = true;
            this.checkedListBoxMessageType.FormattingEnabled = true;
            this.checkedListBoxMessageType.Items.AddRange(new object[] {
            "Alert",
            "Update",
            "Cancel"});
            this.checkedListBoxMessageType.Location = new System.Drawing.Point(12, 60);
            this.checkedListBoxMessageType.Name = "checkedListBoxMessageType";
            this.checkedListBoxMessageType.Size = new System.Drawing.Size(151, 94);
            this.checkedListBoxMessageType.TabIndex = 2;
            // 
            // checkedListBoxEvent
            // 
            this.checkedListBoxEvent.CheckOnClick = true;
            this.checkedListBoxEvent.FormattingEnabled = true;
            this.checkedListBoxEvent.Location = new System.Drawing.Point(181, 60);
            this.checkedListBoxEvent.Name = "checkedListBoxEvent";
            this.checkedListBoxEvent.Size = new System.Drawing.Size(287, 256);
            this.checkedListBoxEvent.TabIndex = 4;
            this.checkedListBoxEvent.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxEvent_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event:";
            // 
            // checkedListBoxSeverity
            // 
            this.checkedListBoxSeverity.CheckOnClick = true;
            this.checkedListBoxSeverity.FormattingEnabled = true;
            this.checkedListBoxSeverity.Items.AddRange(new object[] {
            "Unknown",
            "Minor",
            "Moderate",
            "Severe",
            "Extreme"});
            this.checkedListBoxSeverity.Location = new System.Drawing.Point(12, 186);
            this.checkedListBoxSeverity.Name = "checkedListBoxSeverity";
            this.checkedListBoxSeverity.Size = new System.Drawing.Size(151, 130);
            this.checkedListBoxSeverity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Severity:";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Active Events:";
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.Group,
            this.LocationName});
            this.dataGridViewEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewEvents.Location = new System.Drawing.Point(487, 42);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.RowHeadersVisible = false;
            this.dataGridViewEvents.Size = new System.Drawing.Size(539, 274);
            this.dataGridViewEvents.TabIndex = 13;
            this.dataGridViewEvents.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEvents_CellEndEdit);
            // 
            // EventName
            // 
            this.EventName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventName.HeaderText = "Event";
            this.EventName.MinimumWidth = 290;
            this.EventName.Name = "EventName";
            this.EventName.ReadOnly = true;
            this.EventName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.EventName.Width = 290;
            // 
            // Group
            // 
            this.Group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Group.HeaderText = "Group";
            this.Group.MinimumWidth = 150;
            this.Group.Name = "Group";
            this.Group.Width = 150;
            // 
            // LocationName
            // 
            this.LocationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LocationName.HeaderText = "Location";
            this.LocationName.Name = "LocationName";
            // 
            // dataGridViewAlerts
            // 
            this.dataGridViewAlerts.AllowUserToAddRows = false;
            this.dataGridViewAlerts.AllowUserToDeleteRows = false;
            this.dataGridViewAlerts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlertType,
            this.EffectiveDate,
            this.ExpireDate,
            this.Area});
            this.dataGridViewAlerts.Location = new System.Drawing.Point(12, 581);
            this.dataGridViewAlerts.MultiSelect = false;
            this.dataGridViewAlerts.Name = "dataGridViewAlerts";
            this.dataGridViewAlerts.ReadOnly = true;
            this.dataGridViewAlerts.RowHeadersVisible = false;
            this.dataGridViewAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlerts.Size = new System.Drawing.Size(456, 184);
            this.dataGridViewAlerts.TabIndex = 15;
            this.dataGridViewAlerts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAlerts_CellMouseDoubleClick);
            this.dataGridViewAlerts.SelectionChanged += new System.EventHandler(this.dataGridViewAlerts_SelectionChanged);
            // 
            // AlertType
            // 
            this.AlertType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AlertType.HeaderText = "Alert";
            this.AlertType.MinimumWidth = 100;
            this.AlertType.Name = "AlertType";
            this.AlertType.ReadOnly = true;
            // 
            // EffectiveDate
            // 
            this.EffectiveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "MM/dd/yy hh:mm tt";
            dataGridViewCellStyle1.NullValue = null;
            this.EffectiveDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.EffectiveDate.HeaderText = "Effective";
            this.EffectiveDate.MinimumWidth = 100;
            this.EffectiveDate.Name = "EffectiveDate";
            this.EffectiveDate.ReadOnly = true;
            this.EffectiveDate.Visible = false;
            // 
            // ExpireDate
            // 
            this.ExpireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "MM/dd/yy hh:mm tt";
            this.ExpireDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExpireDate.HeaderText = "Expires";
            this.ExpireDate.MinimumWidth = 100;
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 200;
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alert text:";
            // 
            // richTextBoxAlert
            // 
            this.richTextBoxAlert.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAlert.Location = new System.Drawing.Point(487, 355);
            this.richTextBoxAlert.Name = "richTextBoxAlert";
            this.richTextBoxAlert.ReadOnly = true;
            this.richTextBoxAlert.Size = new System.Drawing.Size(539, 410);
            this.richTextBoxAlert.TabIndex = 18;
            this.richTextBoxAlert.Text = "";
            // 
            // listViewZones
            // 
            this.listViewZones.CheckBoxes = true;
            this.listViewZones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewZones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewZones.HideSelection = false;
            this.listViewZones.Location = new System.Drawing.Point(12, 355);
            this.listViewZones.Name = "listViewZones";
            this.listViewZones.Size = new System.Drawing.Size(456, 220);
            this.listViewZones.TabIndex = 21;
            this.listViewZones.UseCompatibleStateImageBehavior = false;
            this.listViewZones.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "County";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "State";
            this.columnHeader3.Width = 57;
            // 
            // linkLabelExportWarning
            // 
            this.linkLabelExportWarning.AutoSize = true;
            this.linkLabelExportWarning.Location = new System.Drawing.Point(916, 337);
            this.linkLabelExportWarning.Name = "linkLabelExportWarning";
            this.linkLabelExportWarning.Size = new System.Drawing.Size(110, 15);
            this.linkLabelExportWarning.TabIndex = 22;
            this.linkLabelExportWarning.TabStop = true;
            this.linkLabelExportWarning.Text = "Export warning text";
            this.linkLabelExportWarning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExportWarning_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1038, 802);
            this.Controls.Add(this.linkLabelExportWarning);
            this.Controls.Add(this.listViewZones);
            this.Controls.Add(this.richTextBoxAlert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewAlerts);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBoxSeverity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxEvent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxMessageType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NWS Alert Reciever";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlerts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUpdate;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelRetrieve;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelError;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxMessageType;
        private System.Windows.Forms.CheckedListBox checkedListBoxEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeverity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelAvailable;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelActive;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DataGridView dataGridViewAlerts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlertType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelAlerts;
        private System.Windows.Forms.ListView listViewZones;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Group;
        private System.Windows.Forms.DataGridViewComboBoxColumn LocationName;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrawl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxCrawl;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonSendCrawl;
        private System.Windows.Forms.ToolStripMenuItem sendToCrawlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAndSendToCrawlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabelExportWarning;
    }
}

