﻿namespace Sistem_Manajemen_Hotel.View
{
    partial class Form_Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsernameDashboard = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lkbLogout = new System.Windows.Forms.LinkLabel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usercontrolDashboard1 = new Sistem_Manajemen_Hotel.View.usercontrolDashboard();
            this.usercontrolClient1 = new Sistem_Manajemen_Hotel.View.usercontrolClient();
            this.usercontrolRoom1 = new Sistem_Manajemen_Hotel.View.usercontrolRoom();
            this.usercontrolReservation1 = new Sistem_Manajemen_Hotel.View.usercontrolReservation();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pnlSlide);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 642);
            this.panel1.TabIndex = 0;
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.White;
            this.pnlSlide.Location = new System.Drawing.Point(0, 186);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(11, 65);
            this.pnlSlide.TabIndex = 2;
            // 
            // btnReservation
            // 
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Group_2;
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(12, 399);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(288, 65);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "       Reservation";
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Group_5;
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(12, 328);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(288, 65);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "       Room";
            this.btnRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Vector;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(12, 257);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(288, 65);
            this.btnClient.TabIndex = 2;
            this.btnClient.Text = "        Client";
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Dashboard__2_;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(12, 186);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(288, 65);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "       Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistem Manajemen Hotel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.Icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblUsernameDashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 174);
            this.panel2.TabIndex = 1;
            // 
            // lblUsernameDashboard
            // 
            this.lblUsernameDashboard.AutoSize = true;
            this.lblUsernameDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDashboard.ForeColor = System.Drawing.Color.White;
            this.lblUsernameDashboard.Location = new System.Drawing.Point(110, 126);
            this.lblUsernameDashboard.Name = "lblUsernameDashboard";
            this.lblUsernameDashboard.Size = new System.Drawing.Size(18, 19);
            this.lblUsernameDashboard.TabIndex = 0;
            this.lblUsernameDashboard.Text = "?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lkbLogout);
            this.panel3.Controls.Add(this.lblDateTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 93);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sistem_Manajemen_Hotel.Properties.Resources.profile__1_;
            this.pictureBox2.Location = new System.Drawing.Point(809, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lkbLogout
            // 
            this.lkbLogout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lkbLogout.AutoSize = true;
            this.lkbLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkbLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lkbLogout.Location = new System.Drawing.Point(869, 41);
            this.lkbLogout.Name = "lkbLogout";
            this.lkbLogout.Size = new System.Drawing.Size(65, 21);
            this.lkbLogout.TabIndex = 1;
            this.lkbLogout.TabStop = true;
            this.lkbLogout.Text = "Logout";
            this.lkbLogout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lkbLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbLogout_LinkClicked);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.lblDateTime.Location = new System.Drawing.Point(17, 42);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(18, 19);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME : ";
            // 
            // usercontrolDashboard1
            // 
            this.usercontrolDashboard1.BackColor = System.Drawing.Color.White;
            this.usercontrolDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrolDashboard1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercontrolDashboard1.Location = new System.Drawing.Point(300, 174);
            this.usercontrolDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.usercontrolDashboard1.Name = "usercontrolDashboard1";
            this.usercontrolDashboard1.Size = new System.Drawing.Size(1034, 468);
            this.usercontrolDashboard1.TabIndex = 3;
            // 
            // usercontrolClient1
            // 
            this.usercontrolClient1.BackColor = System.Drawing.Color.White;
            this.usercontrolClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrolClient1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercontrolClient1.Location = new System.Drawing.Point(300, 174);
            this.usercontrolClient1.Margin = new System.Windows.Forms.Padding(4);
            this.usercontrolClient1.Name = "usercontrolClient1";
            this.usercontrolClient1.Size = new System.Drawing.Size(1034, 468);
            this.usercontrolClient1.TabIndex = 2;
            this.usercontrolClient1.Load += new System.EventHandler(this.usercontrolClient1_Load);
            // 
            // usercontrolRoom1
            // 
            this.usercontrolRoom1.BackColor = System.Drawing.Color.White;
            this.usercontrolRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrolRoom1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercontrolRoom1.Location = new System.Drawing.Point(300, 174);
            this.usercontrolRoom1.Margin = new System.Windows.Forms.Padding(5);
            this.usercontrolRoom1.Name = "usercontrolRoom1";
            this.usercontrolRoom1.Size = new System.Drawing.Size(1034, 468);
            this.usercontrolRoom1.TabIndex = 4;
            // 
            // usercontrolReservation1
            // 
            this.usercontrolReservation1.BackColor = System.Drawing.Color.White;
            this.usercontrolReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usercontrolReservation1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usercontrolReservation1.Location = new System.Drawing.Point(300, 174);
            this.usercontrolReservation1.Margin = new System.Windows.Forms.Padding(4);
            this.usercontrolReservation1.Name = "usercontrolReservation1";
            this.usercontrolReservation1.Size = new System.Drawing.Size(1034, 468);
            this.usercontrolReservation1.TabIndex = 5;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 642);
            this.Controls.Add(this.usercontrolReservation1);
            this.Controls.Add(this.usercontrolRoom1);
            this.Controls.Add(this.usercontrolDashboard1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsernameDashboard;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lkbLogout;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnReservation;
        private usercontrolClient usercontrolClient1;
        private usercontrolDashboard usercontrolDashboard1;
        private usercontrolRoom usercontrolRoom1;
        private usercontrolReservation usercontrolReservation1;
    }
}