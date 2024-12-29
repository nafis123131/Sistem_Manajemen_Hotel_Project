using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistem_Manajemen_Hotel.View
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        public Form_Dashboard(string username)
        {
            InitializeComponent();
            lblUsernameDashboard.Text = username;
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void MovePanel(Control btn)
        {
            pnlSlide.Top = btn.Top;
            pnlSlide.Height = btn.Height;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MM-yyy hh:mm:ss tt");
        }

        private void lkbLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin untuk Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            lblUsernameDashboard.Text = "Admin";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //Form_Dashboard dashForm = dashboard as FrmDashboard;

            MovePanel(btnDashboard);
            usercontrolDashboard1.Visible = true;
            usercontrolClient1.Visible = false;
            usercontrolReservation1.Visible = false;
            usercontrolRoom1.Visible = false;
            usercontrolDashboard1.BringToFront();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
            usercontrolDashboard1.Visible = false;
            usercontrolClient1.Visible = true;
            usercontrolReservation1.Visible = false;
            usercontrolRoom1.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
            usercontrolDashboard1.Visible = false;
            usercontrolClient1.Visible = false;
            usercontrolRoom1.Visible = true;
            usercontrolReservation1.Visible = false;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            usercontrolDashboard1.Visible = false;
            usercontrolClient1.Visible = false;
            usercontrolRoom1.Visible = false;
            usercontrolReservation1.Visible = true;
        }

        private void usercontrolClient1_Load(object sender, EventArgs e)
        {

        }
    }
}