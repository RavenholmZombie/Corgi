namespace Watchdog
{
    partial class frmBackdrop
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
            components = new System.ComponentModel.Container();
            fadeTimer = new System.Windows.Forms.Timer(components);
            formChecker = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // fadeTimer
            // 
            fadeTimer.Interval = 25;
            fadeTimer.Tick += fadeTimer_Tick;
            // 
            // formChecker
            // 
            formChecker.Tick += formChecker_Tick;
            // 
            // frmBackdrop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBackdrop";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBackdrop";
            WindowState = FormWindowState.Maximized;
            Load += frmBackdrop_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.Timer formChecker;
    }
}