using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlertCrawl
{
    public partial class CrawlWindow : Form
    {
        private int crawlSpeed;
        private string crawl;
        private int crawlX;
        private int crawlY;
        private Font crawlFont;
        private Size crawlSize;
        private string newCrawl;
        private NamedPipeServerStream pipe;
        private Thread pipeThread;
        private bool shutdownCrawl;

        public CrawlWindow()
        {
            InitializeComponent();

            pipeThread = new Thread(PipeThread);
            pipeThread.IsBackground = true;
            pipeThread.Start();

            shutdownCrawl = false;
        }

        private void PipeThread()
        {
            PipeSecurity pipeSecurity = new PipeSecurity();
            PipeAccessRule psEveryone = new PipeAccessRule("Everyone", PipeAccessRights.FullControl, System.Security.AccessControl.AccessControlType.Allow);

            pipeSecurity.AddAccessRule(psEveryone);

            using (pipe = new NamedPipeServerStream("AlertCrawl", PipeDirection.InOut, 1, PipeTransmissionMode.Message))
            {
                while (!shutdownCrawl)
                {

                    try
                    {
                        if (!pipe.IsConnected)
                            pipe.WaitForConnection();

                        StringBuilder builder = new StringBuilder();

                        do
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead = pipe.Read(buffer, 0, buffer.Length);

                            builder.Append(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                        }
                        while (!pipe.IsMessageComplete);

                        newCrawl = builder.ToString();

                        if (newCrawl.StartsWith("!RESET!"))
                        {
                            newCrawl = newCrawl.Substring(7);
                            ResetCrawl();
                        }
                    }
                    catch (IOException ex)
                    {
                        if(pipe.IsConnected)
                            MessageBox.Show($"A problem was encountered while retrieving alert data: {ex.Message}", "Alert Crawl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Sets the crawl to the current text and restarts it from the right.
        /// </summary>
        private void ResetCrawl()
        {
            if (!string.IsNullOrEmpty(newCrawl))
            {
                crawl = newCrawl;
            }

            // Determine text size
            crawlSize = TextRenderer.MeasureText(crawl, crawlFont);

            // reset crawl position
            crawlX = ClientRectangle.Width + 5;
            crawlY = (ClientRectangle.Height - crawlSize.Height) / 2;

            // clear crawl window
            using (Graphics g = CreateGraphics())
            {
                g.FillRectangle(Brushes.Black, ClientRectangle);
            }
        }
        private void CrawlWindow_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Left = Screen.PrimaryScreen.Bounds.Left;
            this.Top = Screen.PrimaryScreen.Bounds.Bottom - this.Height - 40;

            crawlFont = new Font(Properties.Settings.Default.FontName, Properties.Settings.Default.FontSize, FontStyle.Bold);
            crawlSpeed = Properties.Settings.Default.CrawlSpeed;
            crawl = "SEVERE WEATHER IS POSSIBLE TODAY.  PLEASE REMAIN ALERT FOR CHANGING CONDITIONS.";

            fileSystemWatcher.Path = Properties.Settings.Default.DataPath;

            ResetCrawl();
        }

        private void timerCrawl_Tick(object sender, EventArgs e)
        {
            WinApi.ScrollWindowEx(Handle, -crawlSpeed, 0, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, WinApi.SW_INVALIDATE | WinApi.SW_ERASE);
            crawlX -= crawlSpeed;

            if (crawlX < -crawlSize.Width)
                ResetCrawl();
        }

        private void CrawlWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(crawl, crawlFont, Brushes.White, crawlX, crawlY);
        }

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            //try
            //{
            //    newCrawl = File.ReadAllText(e.FullPath);
            //}
            //catch (UnauthorizedAccessException)
            //{

            //}
            //catch (IOException)
            //{

            //}

            //if (newCrawl.StartsWith("!RESET!"))
            //{
            //    newCrawl = newCrawl.Substring(7);
            //    ResetCrawl();
            //}
        }

        private void CrawlWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            shutdownCrawl = true;
            Application.Exit();
        }
    }
}
