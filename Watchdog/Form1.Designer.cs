namespace Watchdog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            button1 = new Button();
            refreshTimer = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            corgiIcon = new NotifyIcon(components);
            formCheck = new System.Windows.Forms.Timer(components);
            lblVersion = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.corgi;
            pictureBox1.Location = new Point(110, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 92);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "I will keep watch :3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Location = new Point(15, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(3, 86);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(244, 11);
            progressBar1.TabIndex = 4;
            progressBar1.Value = 100;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkGreen;
            lblStatus.ImageAlign = ContentAlignment.MiddleRight;
            lblStatus.Location = new Point(3, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(244, 78);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Hello!";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(15, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Options";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // refreshTimer
            // 
            refreshTimer.Tick += refreshTimer_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(190, 230);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // corgiIcon
            // 
            corgiIcon.BalloonTipIcon = ToolTipIcon.Info;
            corgiIcon.Icon = (Icon)resources.GetObject("corgiIcon.Icon");
            corgiIcon.Text = "Corgi, The Adorable Watchdog";
            corgiIcon.Visible = true;
            corgiIcon.MouseDoubleClick += corgiIcon_MouseDoubleClick;
            // 
            // formCheck
            // 
            formCheck.Tick += formCheck_Tick;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Enabled = false;
            lblVersion.Location = new Point(121, 234);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(31, 15);
            lblVersion.TabIndex = 6;
            lblVersion.Text = "1.0.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 265);
            Controls.Add(lblVersion);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Corgi. The Adorable Watchdog";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Label lblStatus;
        private System.Windows.Forms.Timer refreshTimer;
        private ProgressBar progressBar1;
        private Button button3;
        private NotifyIcon corgiIcon;
        private System.Windows.Forms.Timer formCheck;
        private Label lblVersion;
    }
}
