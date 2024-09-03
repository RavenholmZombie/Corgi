using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watchdog
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ip = textBox1.Text;
            Properties.Settings.Default.pingOnStartup = checkBox1.Checked;
            Properties.Settings.Default.startMinimized = checkBox2.Checked;

            if(String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                Properties.Settings.Default.ip = "https://github.com/RavenholmZombie";
                MessageBox.Show("IP/URL Textfield was left empty. Using default URL", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            if(numericUpDown1.Value < 0 || numericUpDown1.Value > 25)
            {
                Properties.Settings.Default.timeToAction = 15;
                MessageBox.Show("Invalid countdown time provided. Defaulting to 15 minutes.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Properties.Settings.Default.timeToAction = numericUpDown1.Value;
            }

            Properties.Settings.Default.Save();
            MessageBox.Show($"Settings Saved. \n\nIP or URL to watch: {Properties.Settings.Default.ip} \nCountdown time: {Properties.Settings.Default.timeToAction} \nPing on startup: {Properties.Settings.Default.pingOnStartup} \nMinimize on Startup: {Properties.Settings.Default.startMinimized}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(Properties.Settings.Default.ip))
            {
                textBox1.Text = Properties.Settings.Default.ip;
            }

            if(Properties.Settings.Default.timeToAction != 0)
            {
                numericUpDown1.Value = Properties.Settings.Default.timeToAction;
            }

            checkBox1.Checked = Properties.Settings.Default.pingOnStartup;
            checkBox2.Checked = Properties.Settings.Default.startMinimized;
        }
    }
}
