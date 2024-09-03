using System.Net;
using System.Net.NetworkInformation;

namespace Watchdog
{
    public partial class frmMain : Form
    {
        int failedAttempts = 5;
        private ContextMenuStrip trayMenu;
        public frmMain()
        {
            InitializeComponent();

            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Restore", null, Restore_Click);
            trayMenu.Items.Add("Options", null, Options_Click);
            trayMenu.Items.Add("Exit", null, Exit_Click);

            corgiIcon.ContextMenuStrip = trayMenu;
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            corgiIcon.Visible = false;
            ShowInTaskbar = true;
        }

        private void Options_Click(object sender, EventArgs e)
        {
            frmOptions f = new frmOptions();
            f.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            corgiIcon.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOptions options = new frmOptions();
            options.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;
            if(Properties.Settings.Default.pingOnStartup)
            {
                button3.PerformClick();
            }

            if(Properties.Settings.Default.startMinimized)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
        }

        private bool IsIpAddressActive(string ip)
        {
            groupBox1.Text = "Status";
            lblStatus.Text = "Pinging...";
            lblStatus.ForeColor = Color.Blue;
            try
            {
                using (Ping ping = new Ping())
                {
                    groupBox1.Text = "Status";
                    PingReply reply = ping.Send(ip, 1000); // 1000 ms timeout
                    lblStatus.ForeColor = Color.DarkGreen;
                    lblStatus.Text = "It's Alive!!";
                    failedAttempts = 5;
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.DarkRed;
                groupBox1.Text = $"Status (Attempts Left: {failedAttempts - 1})";
                lblStatus.Text = "He's dead, Jim!";
                Console.WriteLine(ex);

                if (WindowState == FormWindowState.Minimized)
                {
                    corgiIcon.BalloonTipIcon = ToolTipIcon.Error;
                    corgiIcon.BalloonTipTitle = "Arf!";
                    corgiIcon.BalloonTipText = $"Corgi was unable to ping the IP address you provided. Attempts left: {failedAttempts - 1}";
                    corgiIcon.ShowBalloonTip(1000);
                }

                failedAttempts--;
                return false;
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value--;
            
            if (progressBar1.Value <= 2)
            {
                progressBar1.Value = 100;
                IsIpAddressActive(Properties.Settings.Default.ip);
                if (failedAttempts <= 0)
                {
                    failedAttempts = 0;
                    lblStatus.Text = "Countdown Started";
                    button3.Text = "Restart";
                    refreshTimer.Stop();
                    Properties.Settings.Default.Save();
                    frmCountdown frmCountdown = new frmCountdown();
                    frmCountdown.Show();
                    formCheck.Start();
                    Hide();
                }
            }
        }

        private void executeTimer_Tick(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Start" || button3.Text == "Restart")
            {
                button3.Text = "Pause";
                refreshTimer.Start();
                lblStatus.Text = "Running";
            }
            else
            {
                button3.Text = "Start";
                refreshTimer.Stop();
                lblStatus.Text = "Paused";
            }
        }

        private void corgiIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            corgiIcon.Visible = false;
            ShowInTaskbar = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                corgiIcon.Visible = true;
                corgiIcon.BalloonTipIcon = ToolTipIcon.Info;
                corgiIcon.BalloonTipTitle = "Arf!";
                corgiIcon.BalloonTipText = "Corgi is still running in the background. To reopen the main window, double-click the Notification icon.";
                corgiIcon.ShowBalloonTip(1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            corgiIcon.Dispose();
        }

        private void formCheck_Tick(object sender, EventArgs e)
        {
            if(FormChecker.IsFormOpen("frmCountdown"))
            {
                Hide();
            }
            else
            {
                Show();
                formCheck.Stop();
                lblStatus.Text = "Countdown Stopped";
                groupBox1.Text = "Status";
                failedAttempts = 5;
            }
        }
    }
}
