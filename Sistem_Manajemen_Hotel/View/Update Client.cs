using Sistem_Manajemen_Hotel.Model.Entity;
using Sistem_Manajemen_Hotel.Model.Repository;
using Sistem_Manajemen_Hotel.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Hotel.View;
using Sistem_Manajemen_Hotel.Controller;

namespace Sistem_Manajemen_Hotel.View
{
    public partial class Update_Client : Form
    {
        private IList<ClientEntity> listOfClientEntity = new List<ClientEntity>();

        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(ClientEntity client);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;
        // deklarasi variabel untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        // deklarasi variabel/objek mhs untuk meyimpan data mahasiswa
        private ClientEntity client1;
        private ClientController controller;
        // Constructor default
        private readonly usercontrolClient _userControl;
        private readonly ListViewItem _selectedItem;
        private readonly string connectionString = "Data Source=hotel.db;Version=3;";

        private ListView lvwClient; // Pastikan ini dideklarasikan
        private CreateUpdateEventHandler FrmUpdate_OnUpdate;

        //private List<ClientEntity> listOfClientEntity;
        // Constructor default
        public Update_Client()
        {
            InitializeComponent();
            ValidasiInput();
        }
        private bool ValidasiInput()
        {
            if (string.IsNullOrWhiteSpace(txtUpdateClientFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateClientLastName.Text) ||
                string.IsNullOrWhiteSpace(txtUpdateClientPhoneNo.ToString()))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void updateClient(ClientEntity client)
        {
            int index = lvwClient.SelectedIndices[0];
            ListViewItem itemRow = lvwClient.Items[index];
            itemRow.SubItems[1].Text = client.Firstname;
            itemRow.SubItems[2].Text = client.Lastname;
            itemRow.SubItems[3].Text = client.Phone.ToString();
        }

        // Constructor dengan parameter usercontrolClient dan ListViewItem
        public Update_Client(usercontrolClient userControl, ListViewItem selected)
        {
            LoadClientData();
            InitializeComponent();
            _userControl = userControl;
            _selectedItem = selected;
        }
        public Update_Client(string title) : this()
        {
            // ganti text/judul form
            this.Text = title;
        }

        public Update_Client(string title, ClientEntity obj) : this()
        {
            this.Text = title;
            isNewData = false;
            client1 = obj;

            // Initialize the controller
            controller = new ClientController();

            // Populate the form with client data
            txtUpdateClientFirstName.Text = client1.Firstname;
            txtUpdateClientLastName.Text = client1.Lastname;
            txtUpdateClientPhoneNo.Text = client1.Phone.ToString();
        }

        private void LoadClientData()
        {
            // Mengisi form dengan data yang dipilih
            int index = lvwClient.SelectedIndices[0];
            txtUpdateClientFirstName.Text = _selectedItem.SubItems[1].Text;
            txtUpdateClientLastName.Text = _selectedItem.SubItems[2].Text;
            txtUpdateClientPhoneNo.Text = _selectedItem.SubItems[3].Text;

            /*
            int index = lvwMahasiswa.SelectedIndices[0];

            ListViewItem itemRow = lvwMahasiswa.Items[index];
            itemRow.SubItems[1].Text = mhs.Npm;
            itemRow.SubItems[2].Text = mhs.Nama;
            itemRow.SubItems[3].Text = mhs.Angkatan;
             */
        }

        private void btnPopupUpdateClient_Click(object sender, EventArgs e)
        {
            Update_Client update = new Update_Client("Update Client");

            if (!ValidasiInput())
                return;

            if (client1 == null)
            {
                MessageBox.Show("Tidak ada data untuk diupdate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            client1.Firstname = txtUpdateClientFirstName.Text.Trim();
            client1.Lastname = txtUpdateClientLastName.Text.Trim();

            if (!int.TryParse(txtUpdateClientPhoneNo.Text, out int phone))
            {
                MessageBox.Show("Nomor telepon harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            client1.Phone = phone;

            // Ensure the controller is initialized
            if (controller == null)
            {
                MessageBox.Show("Controller belum diinisialisasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int result = controller.UpdateClient(client1);

            if (result > 0)
            {
                OnUpdate?.Invoke(client1);
                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data gagal diperbarui.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
