using Sistem_Manajemen_Hotel.Controler;
using Sistem_Manajemen_Hotel.Model.Entity;
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
    public delegate void CreateUpdateEventHandler(RoomEntity room);
    public partial class Update_Room : Form
    {
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private RoomController controller;
        private bool isNewData = true;
        private RoomEntity room;
        public Update_Room()
        {
            InitializeComponent();
        }
        public Update_Room(string title, RoomController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public Update_Room(string title, RoomEntity obj, RoomController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            room = obj;

            cmbUpdateRoomtype.Text = room.TypeRoom;
            rdbUpdateYes.Text = room.Availability;
            rdbUpdateNo.Text = room.Availability;
            txtUpdateRoomPhoneNo.Text = room.RoomNumber.ToString();
        }

        private void btnPopupUpdateRoom_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            if (isNewData)
                room = new RoomEntity();

            room.TypeRoom = cmbUpdateRoomtype.Text.Trim();
            room.Availability = cmbUpdateRoomtype.Text.Trim();
            room.Availability = cmbUpdateRoomtype.Text.Trim();
            room.RoomNumber = int.Parse(txtUpdateRoomPhoneNo.Text.Trim());

            int result = isNewData ? controller.CreateRoom(room) : controller.UpdateRoom(room);

            if (result > 0)
            {
                if (isNewData && OnCreate != null)
                {
                    OnCreate(room);
                    ResetForm();
                }
                else if (!isNewData && OnUpdate != null)
                {
                    OnUpdate(room);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Data gagal disimpan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(cmbUpdateRoomtype.Text) ||
                string.IsNullOrWhiteSpace(rdbUpdateYes.Text) ||
                string.IsNullOrWhiteSpace(rdbUpdateNo.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateRoomPhoneNo.Text))

            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ResetForm()
        {
            cmbUpdateRoomtype.SelectedIndex= -1;
            rdbUpdateYes.Checked = false;
            rdbUpdateNo.Checked = false;
            txtUpdateRoomPhoneNo.Clear();
        }
    }
}
