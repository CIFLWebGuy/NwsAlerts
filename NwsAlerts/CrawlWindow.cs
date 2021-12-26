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
    public partial class CrawlWindow : Form
    {
        private string crawl;

        public CrawlWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets/sets the crawl text.
        /// </summary>
        public string CrawlText
        {
            get
            {
                return crawl;
            }
            set
            {
                if (string.IsNullOrEmpty(crawl))
                {
                    labelCrawlText.Text = value;
                }

                crawl = value;
            }
        }

        /// <summary>
        /// Sets the crawl to the current text and restarts it from the right.
        /// </summary>
        public void ResetCrawl()
        {
            labelCrawlText.Text = CrawlText;
            labelCrawlText.Left = this.Width;
        }

        private void CrawlWindow_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Left = Screen.PrimaryScreen.Bounds.Left;
            this.Top = Screen.PrimaryScreen.Bounds.Bottom - this.Height - 40;
            labelCrawlText.Left = this.Width;
            labelCrawlText.Text = "";
        }

        private void timerMarquee_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CrawlText))
                return;

            labelCrawlText.Left -= 3;

            if (labelCrawlText.Left < Screen.PrimaryScreen.Bounds.Left - labelCrawlText.Width)
            {
                ResetCrawl();
            }
        }
    }
}
