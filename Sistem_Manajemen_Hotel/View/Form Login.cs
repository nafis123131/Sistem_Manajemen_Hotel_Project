using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Manajemen_Hotel.View
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void pcbShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pcbShow, "Show Password");
        }

        private void pcbHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pcbHide, "Hide Password");
        }

        private void pcbShow_Click_1(object sender, EventArgs e)
        {
            pcbShow.Hide();
            pcbShow.Show();
        }

        private void pcbHide_Click_1(object sender, EventArgs e)
        {
            pcbHide.Hide();
            pcbHide.Show();
        }
    }
}
