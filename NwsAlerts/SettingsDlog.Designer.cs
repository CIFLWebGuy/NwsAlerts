namespace NwsAlerts
{
    partial class SettingsDlog
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("API settings");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("HTML output");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("General", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Groups");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Event Icons");
            this.treeViewNav = new Windows.Controls.TreeView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelPages = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewNav
            // 
            this.treeViewNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewNav.FullRowSelect = true;
            this.treeViewNav.HideSelection = false;
            this.treeViewNav.Location = new System.Drawing.Point(0, 0);
            this.treeViewNav.Name = "treeViewNav";
            treeNode6.Name = "Node6";
            treeNode6.Text = "API settings";
            treeNode7.Name = "Node8";
            treeNode7.Text = "HTML output";
            treeNode8.Name = "Node0";
            treeNode8.Text = "General";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Groups";
            treeNode10.Name = "NodeIcons";
            treeNode10.Text = "Event Icons";
            this.treeViewNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeViewNav.ShowLines = false;
            this.treeViewNav.Size = new System.Drawing.Size(163, 332);
            this.treeViewNav.TabIndex = 2;
            this.treeViewNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNav_AfterSelect);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(458, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(539, 12);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelPages
            // 
            this.panelPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPages.Location = new System.Drawing.Point(163, 0);
            this.panelPages.Name = "panelPages";
            this.panelPages.Size = new System.Drawing.Size(463, 332);
            this.panelPages.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCancel);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 47);
            this.panel2.TabIndex = 6;
            // 
            // SettingsDlog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(626, 379);
            this.Controls.Add(this.panelPages);
            this.Controls.Add(this.treeViewNav);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDlog";
            this.Text = "Settings";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Controls.TreeView treeViewNav;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelPages;
        private System.Windows.Forms.Panel panel2;
    }
}