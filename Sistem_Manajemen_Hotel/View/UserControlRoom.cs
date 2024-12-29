using Sistem_Manajemen_Hotel.Controller;
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
using Sistem_Manajemen_Hotel.Model.Repository;
using Sistem_Manajemen_Hotel.Controler;

namespace Sistem_Manajemen_Hotel.View
{
    public partial class usercontrolRoom : UserControl
    {
        private List<RoomEntity> ListOfRoom = new List<RoomEntity>();
        private RoomController controller;
        public usercontrolRoom()
        {
            InitializeComponent();
            controller = new RoomController();
            InisialisasiListView();
            LoadDataRoom();

            //listRoom.SelectedIndexChanged += listRoom_SelectedIndexChanged;
        }

        private void LoadDataRoom()
        {
            // kosongkan listview
            lvwRoom.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            ListOfRoom = controller.ReadAll();
            // ekstrak objek mhs dari collection
            foreach (var room in ListOfRoom)
            {
                var noRoom = lvwRoom.Items.Count + 1;
                var item = new ListViewItem(noRoom.ToString());
                item.SubItems.Add(room.IdRoom.ToString());
                item.SubItems.Add(room.RoomNumber.ToString());
                item.SubItems.Add(room.Availability);
                item.SubItems.Add(room.TypeRoom);
                lvwRoom.Items.Add(item);
            }
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
        }
        private void InisialisasiListView()
        {
            lvwRoom.View = System.Windows.Forms.View.Details;
            lvwRoom.FullRowSelect = true;
            lvwRoom.GridLines = true;
            lvwRoom.Columns.Add("No.", 70, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Tipe Ruang", 300, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Phone No", 300, HorizontalAlignment.Center);
            lvwRoom.Columns.Add("Status Kamar", 300, HorizontalAlignment.Center);
        }
        private void listBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwRoom.SelectedItems.Count > 0)
            {
                var selectedItem = lvwRoom.SelectedItems[0];
                lvwRoom.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void usercontrolRoom_OnCreate(RoomEntity room)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            ListOfRoom.Add(room);

            int noUrut = lvwRoom.Items.Count + 1;

            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());

            item.SubItems.Add(room.IdRoom.ToString());
            item.SubItems.Add(room.RoomNumber.ToString());
            item.SubItems.Add(room.Availability);
            item.SubItems.Add(room.TypeRoom);
            lvwRoom.Items.Add(item);
        }
        private void OnUpdateEventHandler(RoomEntity room)
        {

            int index = lvwRoom.SelectedIndices[0];

            ListViewItem itemRow = lvwRoom.Items[index];
            itemRow.SubItems[1].Text = room.TypeRoom;
            itemRow.SubItems[2].Text = room.Availability;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Add_Room add_Room = new Add_Room("Tambah Room",controller);
            add_Room.OnCreate += usercontrolRoom_OnCreate;
            add_Room.ShowDialog();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (lvwRoom.SelectedItems.Count > 0)
            {
                RoomEntity mhs = ListOfRoom[lvwRoom.SelectedIndices[0]];
                Update_Room frmUpdate = new Update_Room("Edit Data Mahasiswa", mhs, controller);
                frmUpdate.OnUpdate += OnUpdateEventHandler;
                frmUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
               MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchRoom.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Masukkan nama mahasiswa yang ingin dicari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoomController controller = new RoomController();
                List<RoomEntity> roomEntity = controller.ReadByNama(searchText);

                lvwRoom.Items.Clear();

                if (roomEntity.Count > 0)
                {
                    foreach (RoomEntity room in roomEntity)
                    {
                        ListOfRoom.Add(room);
                        int noUrut = lvwRoom.Items.Count + 1;
                        ListViewItem item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(room.IdRoom.ToString());
                        item.SubItems.Add(room.RoomNumber.ToString());
                        item.SubItems.Add(room.Availability);
                        item.SubItems.Add(room.TypeRoom);
                        lvwRoom.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Nama ruang tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
