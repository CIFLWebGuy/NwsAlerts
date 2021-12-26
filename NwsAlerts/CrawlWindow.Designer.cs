namespace NwsAlerts
{
    partial class CrawlWindow
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
            this.labelCrawlText = new System.Windows.Forms.Label();
            this.timerMarquee = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCrawlText
            // 
            this.labelCrawlText.AutoSize = true;
            this.labelCrawlText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrawlText.ForeColor = System.Drawing.Color.White;
            this.labelCrawlText.Location = new System.Drawing.Point(12, 17);
            this.labelCrawlText.Name = "labelCrawlText";
            this.labelCrawlText.Size = new System.Drawing.Size(48, 19);
            this.labelCrawlText.TabIndex = 0;
            this.labelCrawlText.Text = "Alert!";
            // 
            // timerMarquee
            // 
            this.timerMarquee.Enabled = true;
            this.timerMarquee.Interval = 20;
            this.timerMarquee.Tick += new System.EventHandler(this.timerMarquee_Tick);
            // 
            // CrawlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1083, 60);
            this.ControlBox = false;
            this.Controls.Add(this.labelCrawlText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CrawlWindow";
            this.ShowInTaskbar = false;
            this.Text = "Alert Crawl";
            this.Load += new System.EventHandler(this.CrawlWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCrawlText;
        private System.Windows.Forms.Timer timerMarquee;
    }
}