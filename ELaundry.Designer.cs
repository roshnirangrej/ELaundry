namespace ELaundry
{
    partial class ELaundry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ELaundry));
            this.buisnessName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logoimage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Subscription = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.pickUps = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.rewards = new System.Windows.Forms.Button();
            this.hfooter = new System.Windows.Forms.Panel();
            this.developerName = new System.Windows.Forms.Label();
            this.cross = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoimage)).BeginInit();
            this.hfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buisnessName
            // 
            this.buisnessName.AutoSize = true;
            this.buisnessName.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buisnessName.ForeColor = System.Drawing.Color.Transparent;
            this.buisnessName.Location = new System.Drawing.Point(104, 258);
            this.buisnessName.Name = "buisnessName";
            this.buisnessName.Size = new System.Drawing.Size(295, 37);
            this.buisnessName.TabIndex = 1;
            this.buisnessName.Text = "E Laundry Services";
            this.buisnessName.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.logoimage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Subscription);
            this.panel1.Controls.Add(this.buisnessName);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.pickUps);
            this.panel1.Controls.Add(this.Services);
            this.panel1.Controls.Add(this.rewards);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 729);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 695);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 34);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // logoimage
            // 
            this.logoimage.Image = global::ELaundry.Properties.Resources.Screenshot_2023_11_12_091128;
            this.logoimage.Location = new System.Drawing.Point(166, 114);
            this.logoimage.Name = "logoimage";
            this.logoimage.Size = new System.Drawing.Size(166, 128);
            this.logoimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoimage.TabIndex = 7;
            this.logoimage.TabStop = false;
            this.logoimage.Click += new System.EventHandler(this.logoimage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(502, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1414, 50);
            this.panel2.TabIndex = 10;
            // 
            // Subscription
            // 
            this.Subscription.BackColor = System.Drawing.Color.LavenderBlush;
            this.Subscription.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subscription.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subscription.Location = new System.Drawing.Point(111, 629);
            this.Subscription.Name = "Subscription";
            this.Subscription.Size = new System.Drawing.Size(271, 57);
            this.Subscription.TabIndex = 5;
            this.Subscription.Text = "Subscription";
            this.Subscription.UseVisualStyleBackColor = false;
            this.Subscription.Click += new System.EventHandler(this.Subscription_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Home.Location = new System.Drawing.Point(111, 339);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(271, 57);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.button3_Click);
            // 
            // pickUps
            // 
            this.pickUps.BackColor = System.Drawing.Color.LavenderBlush;
            this.pickUps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickUps.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickUps.Location = new System.Drawing.Point(111, 441);
            this.pickUps.Name = "pickUps";
            this.pickUps.Size = new System.Drawing.Size(271, 57);
            this.pickUps.TabIndex = 3;
            this.pickUps.Text = "Schedule Pick-ups";
            this.pickUps.UseVisualStyleBackColor = false;
            this.pickUps.Click += new System.EventHandler(this.pickUps_Click);
            // 
            // Services
            // 
            this.Services.BackColor = System.Drawing.Color.LavenderBlush;
            this.Services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Services.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Location = new System.Drawing.Point(111, 538);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(271, 57);
            this.Services.TabIndex = 4;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = false;
            this.Services.Click += new System.EventHandler(this.button6_Click);
            // 
            // rewards
            // 
            this.rewards.BackColor = System.Drawing.Color.LavenderBlush;
            this.rewards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rewards.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewards.Location = new System.Drawing.Point(111, 734);
            this.rewards.Name = "rewards";
            this.rewards.Size = new System.Drawing.Size(271, 57);
            this.rewards.TabIndex = 6;
            this.rewards.Text = "About us";
            this.rewards.UseVisualStyleBackColor = false;
            this.rewards.Click += new System.EventHandler(this.rewards_Click);
            // 
            // hfooter
            // 
            this.hfooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.hfooter.Controls.Add(this.developerName);
            this.hfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hfooter.Location = new System.Drawing.Point(496, 694);
            this.hfooter.Name = "hfooter";
            this.hfooter.Size = new System.Drawing.Size(1317, 35);
            this.hfooter.TabIndex = 12;
            // 
            // developerName
            // 
            this.developerName.AutoSize = true;
            this.developerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.developerName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerName.ForeColor = System.Drawing.Color.LavenderBlush;
            this.developerName.Location = new System.Drawing.Point(518, 7);
            this.developerName.Name = "developerName";
            this.developerName.Size = new System.Drawing.Size(226, 19);
            this.developerName.TabIndex = 0;
            this.developerName.Text = "Developed by Roshni Rangrej";
            // 
            // cross
            // 
            this.cross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cross.Image = ((System.Drawing.Image)(resources.GetObject("cross.Image")));
            this.cross.Location = new System.Drawing.Point(1758, 6);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(43, 37);
            this.cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cross.TabIndex = 13;
            this.cross.TabStop = false;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Welcome to E Laundry: Your Premier Online Laundry Solution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1116, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "At E Laundry, we bring the power of technology to your laundry needs, revolutioni" +
    "zing the way you experience cleanliness and convenience.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Elevating Laundry Through Innovation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(18, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1111, 44);
            this.label4.TabIndex = 17;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(663, 454);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1138, 484);
            this.panel4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(22, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Why Choose E Laundry?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(23, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = " Effortless Service:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(22, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = " Quality Assured:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(22, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = " Time Efficiency: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(202, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(880, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Say goodbye to laundry hassles. Our user-friendly interface lets you schedule pic" +
    "kups and many more features.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(173, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(952, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = " Trust our skilled professionals to treat your garments with utmost care, ensurin" +
    "g impeccable cleanliness and freshness..";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(173, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(749, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "We value your time. Our prompt services ensure that your laundry is returned to y" +
    "ou promptly.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(21, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 23);
            this.label12.TabIndex = 25;
            this.label12.Text = "Join the E Laundry Experience";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(21, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1085, 44);
            this.label13.TabIndex = 26;
            this.label13.Text = "Discover the freedom of a laundry service that adapts to your schedule. Let E Lau" +
    "ndry handle your laundry needs while you focus on the \r\nmoments that truly matte" +
    "r.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rage Italic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(21, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(425, 28);
            this.label14.TabIndex = 27;
            this.label14.Text = "E Laundry - Where Technology Meets Cleanliness.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ELaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1813, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.hfooter);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ELaundry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elaundry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ELaundry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoimage)).EndInit();
            this.hfooter.ResumeLayout(false);
            this.hfooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label buisnessName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Subscription;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button pickUps;
        private System.Windows.Forms.Button rewards;
        private System.Windows.Forms.PictureBox logoimage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel hfooter;
        private System.Windows.Forms.Label developerName;
        private System.Windows.Forms.PictureBox cross;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

