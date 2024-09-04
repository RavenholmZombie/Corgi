using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Watchdog
{
    public partial class frmBackdrop : Form
    {
        public frmBackdrop()
        {
            InitializeComponent();
        }

        private void frmBackdrop_Load(object sender, EventArgs e)
        {
            fadeTimer.Start();
            formChecker.Start();

            frmCountdown frmCountdown = new frmCountdown();
            frmCountdown.ShowDialog();
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity > 1)
            {
                fadeTimer.Stop();
            }
        }

        private void formChecker_Tick(object sender, EventArgs e)
        {
            if (!FormChecker.IsFormOpen("frmCountdown"))
            {
                Close();
            }
        }
    }
}
