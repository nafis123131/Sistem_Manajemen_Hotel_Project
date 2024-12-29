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
    //public delegate void CreateUpdateEventHandler(RoomEntity room);
    public partial class Add_Room : Form
    {
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private RoomController controller;
        private bool isNewData = true;
        private RoomEntity room;
        public Add_Room()
        {
            InitializeComponent();
        }
        public Add_Room(string title, RoomController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
        }
        public Add_Room(string title, RoomEntity obj, RoomController controller) : this()
        {
            this.Text = title;
            this.controller = controller;
            isNewData = false;
            room = obj;

            cmbAddRoomType.Text = room.TypeRoom;
            rdbAddYes.Text = room.Availability;
            rdbAddNo.Text = room.Availability;
        }

        private void btnPopupAddRoom_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            if (isNewData)
                room = new RoomEntity();

            room.TypeRoom = cmbAddRoomType.ToString();
            room.Availability = rdbAddYes.Text.Trim();
            room.Availability = rdbAddNo.Text.Trim();

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
            if (string.IsNullOrWhiteSpace(cmbAddRoomType.Text) ||
                string.IsNullOrWhiteSpace(rdbAddYes.Text) ||
                string.IsNullOrWhiteSpace(rdbAddNo.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void ResetForm()
        {
            cmbAddRoomType.SelectedIndex = -1; // Reset combo box
            rdbAddYes.Checked = false;        // Uncheck "Yes" radio button
            rdbAddNo.Checked = false;         // Uncheck "No" radio button
            txtAddRoomPhoneNo.Clear();        // Clear text box
        }
    }
}
