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
    public partial class frmCountdown : Form
    {
        private TimeSpan _timeRemaining;
        private TimeSpan _halfwayPoint;
        private System.Windows.Forms.Timer _countdownTimer;
        private bool _halfwayMessageShown = false;
        public frmCountdown()
        {
            InitializeComponent();
            InitializeCountdownTimer();
        }

        private void InitializeCountdownTimer()
        {
            // Retrieve countdown length from settings, default to 15 minutes if not set
            decimal countdownMinutes = Properties.Settings.Default.timeToAction;
            if (countdownMinutes <= 0)
            {
                countdownMinutes = 15; // Default failsafe value
            }

            // Set the countdown time
            _timeRemaining = TimeSpan.FromMinutes((double)countdownMinutes);

            // Calculate the halfway point
            _halfwayPoint = TimeSpan.FromMinutes((double)countdownMinutes / 2);

            // Initialize the Timer control
            _countdownTimer = new System.Windows.Forms.Timer();
            _countdownTimer.Interval = 1000; // 1 second intervals
            _countdownTimer.Tick += CountdownTimer_Tick;

            // Start the countdown
            _countdownTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _countdownTimer.Stop();
            _countdownTimer.Dispose();
            Close();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (_timeRemaining.TotalSeconds > 0)
            {
                // Reduce the remaining time by one second
                _timeRemaining = _timeRemaining.Add(TimeSpan.FromSeconds(-1));
                
                if(lblHalf.Visible)
                {
                    Console.Beep();
                }
                
                // Update the label with the remaining time
                lblCountdown.Text = _timeRemaining.ToString(@"mm\:ss");

                // Check if we've reached the halfway point
                if (!_halfwayMessageShown && _timeRemaining <= _halfwayPoint)
                {
                    _halfwayMessageShown = true;
                    ShowHalfwayMessage();
                }
            }
            else
            {
                // Stop the timer when the countdown reaches zero
                _countdownTimer.Stop();

                // Execute the action when the timer hits zero
                ExecuteOnCountdownEnd();
            }
        }

        private void ShowHalfwayMessage()
        {
            lblCountdown.ForeColor = Color.DarkRed;
            Console.Beep();
            lblHalf.Visible = true;
        }

        private void ExecuteOnCountdownEnd()
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0")
            {
                CreateNoWindow = true,
                UseShellExecute = false
            };
            Process.Start(psi);
        }

        private void frmCountdown_Load(object sender, EventArgs e)
        {
            lblHalf.Visible = false;
        }
    }
}
