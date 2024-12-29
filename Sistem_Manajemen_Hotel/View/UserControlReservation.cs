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
    public partial class usercontrolReservation : UserControl
    {
        public usercontrolReservation()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            lvwReservation.View = System.Windows.Forms.View.Details;
            lvwReservation.FullRowSelect = true;
            lvwReservation.GridLines = true;
            lvwReservation.Columns.Add("ID", 164, HorizontalAlignment.Center);
            lvwReservation.Columns.Add("Tipe Ruang", 200, HorizontalAlignment.Center);
            lvwReservation.Columns.Add("Nomor Ruang", 200, HorizontalAlignment.Center);
            lvwReservation.Columns.Add("Tanggal Masuk", 200, HorizontalAlignment.Center);
            lvwReservation.Columns.Add("Tanggal Keluar", 200, HorizontalAlignment.Center);
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {

        }
    }
}
