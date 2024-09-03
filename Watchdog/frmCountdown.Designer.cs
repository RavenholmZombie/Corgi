namespace Watchdog
{
    partial class frmCountdown
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lblHalf = new Label();
            lblCountdown = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(293, 315);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.corgi_sad;
            pictureBox1.Location = new Point(165, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 65);
            label1.Name = "label1";
            label1.Size = new Size(280, 75);
            label1.TabIndex = 2;
            label1.Text = "Your computer has lost its Internet connection.\r\nBecause of this, Corgi will automatically restart your\r\ncomputer once the timer below reaches zero.\r\n\r\nTo cancel this countdown, click the Stop button.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblHalf);
            groupBox1.Controls.Add(lblCountdown);
            groupBox1.Location = new Point(70, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Countdown";
            // 
            // lblHalf
            // 
            lblHalf.AutoSize = true;
            lblHalf.BackColor = Color.Red;
            lblHalf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHalf.ForeColor = Color.White;
            lblHalf.Location = new Point(15, 76);
            lblHalf.Name = "lblHalf";
            lblHalf.Size = new Size(211, 15);
            lblHalf.TabIndex = 4;
            lblHalf.Text = "The countdown is halfway complete!";
            // 
            // lblCountdown
            // 
            lblCountdown.Dock = DockStyle.Fill;
            lblCountdown.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCountdown.Location = new Point(3, 19);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(235, 78);
            lblCountdown.TabIndex = 0;
            lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCountdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 346);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCountdown";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Countdown";
            Load += frmCountdown_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblCountdown;
        private Label lblHalf;
    }
}