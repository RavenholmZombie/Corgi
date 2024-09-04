using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchdog
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            label3.Text = "Version " + Application.ProductVersion;
            label5.Text = "Current Version: " + Application.ProductVersion;
            lblToast.Visible = false;
            linkDownload.Visible = false;

            CheckForUpdatesAsync("https://raw.githubusercontent.com/RavenholmZombie/Corgi/main/ver.txt");
        }

        public void SetTabPage(int index)
        {
            tabControl1.SelectedIndex = index;
        }

        public async Task CheckForUpdatesAsync(string url)
        {
            try
            {
                lblToast.Text = "Checking...";
                lblToast.BackColor = Color.Purple;
                using (HttpClient client = new HttpClient())
                {
                    string latestVersion = await client.GetStringAsync(url);
                    latestVersion = latestVersion.Trim(); // Remove any extra spaces or newlines
                    label6.Text = $"Latest Version: {latestVersion}";

                    string currentVersion = Application.ProductVersion;

                    if (IsNewVersionAvailable(currentVersion, latestVersion))
                    {
                        lblToast.Visible = true;
                        lblToast.Text = "New Version Available";
                        lblToast.BackColor = Color.Green;
                        linkDownload.Visible = true;
                    }
                    else
                    {
                        lblToast.Visible = true;
                        lblToast.Text = "No Updates Available";
                        lblToast.BackColor = Color.Blue;
                        linkDownload.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                lblToast.Visible = true;
                lblToast.BackColor = Color.Red;
                lblToast.Text = "Unable to check.";
                linkDownload.Visible = false;
            }
        }

        private bool IsNewVersionAvailable(string currentVersion, string latestVersion)
        {
            Version current = new Version(currentVersion);
            Version latest = new Version(latestVersion);

            return latest > current;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/RavenholmZombie/Corgi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/RavenholmZombie/Corgi/issues");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckForUpdatesAsync("https://raw.githubusercontent.com/RavenholmZombie/Corgi/main/ver.txt");
        }

        private void linkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/RavenholmZombie/Corgi/releases/latest");
            Properties.Settings.Default.Save();
            Application.Exit();
        }
    }
}
