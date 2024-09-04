namespace Watchdog
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage3 = new TabPage();
            linkDownload = new LinkLabel();
            lblToast = new Label();
            button4 = new Button();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.corgi;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 2;
            label1.Text = "Corgi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 37);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 3;
            label2.Text = "The adorable watchdog";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 58);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Version 0.0.0";
            // 
            // button1
            // 
            button1.Location = new Point(225, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 82);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(288, 127);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(280, 99);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "About";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(52, 62);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Issues";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 33);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "GitHub";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 6);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 4;
            label4.Text = "Developed by RavenholmZombie";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ImageLocation = "https://mc-heads.net/body/RavenholmZombie";
            pictureBox2.Location = new Point(6, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(280, 99);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "License";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(274, 93);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(linkDownload);
            tabPage3.Controls.Add(lblToast);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(280, 99);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Updates";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkDownload
            // 
            linkDownload.AutoSize = true;
            linkDownload.Location = new Point(126, 38);
            linkDownload.Name = "linkDownload";
            linkDownload.Size = new Size(61, 15);
            linkDownload.TabIndex = 4;
            linkDownload.TabStop = true;
            linkDownload.Text = "Download";
            linkDownload.LinkClicked += linkDownload_LinkClicked;
            // 
            // lblToast
            // 
            lblToast.AutoSize = true;
            lblToast.BackColor = Color.Green;
            lblToast.ForeColor = Color.White;
            lblToast.Location = new Point(11, 74);
            lblToast.Name = "lblToast";
            lblToast.Size = new Size(123, 15);
            lblToast.TabIndex = 3;
            lblToast.Text = "New Version Available";
            // 
            // button4
            // 
            button4.Location = new Point(145, 70);
            button4.Name = "button4";
            button4.Size = new Size(129, 23);
            button4.TabIndex = 2;
            button4.Text = "Check for Updates";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 39);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 1;
            label6.Text = "Latest Version: 0.0.0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 16);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 0;
            label5.Text = "Current Version: 0.0.0";
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 250);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "About Corgi";
            Load += frmAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label label6;
        private Label label5;
        private Button button4;
        private Label lblToast;
        private LinkLabel linkDownload;
    }
}