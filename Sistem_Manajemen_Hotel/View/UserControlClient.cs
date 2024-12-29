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

namespace Sistem_Manajemen_Hotel.View
{
    public partial class usercontrolClient : UserControl
    {
        private IList<ClientEntity> listOfClientEntity = new List<ClientEntity>();

        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(ClientController client);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;
        private ClientEntity entity;

        // deklarasi field untuk meyimpan objek mahasiswa
        private ClientController client;

        public usercontrolClient()
        {
            InitializeComponent();
            InisialisasiListView();
            LoadDataClient();
        }
        private void InisialisasiListView()
        {
            lvwClient.View = System.Windows.Forms.View.Details;
            lvwClient.FullRowSelect = true;
            lvwClient.GridLines = true;
            lvwClient.Columns.Add("ID", 165, HorizontalAlignment.Center);
            lvwClient.Columns.Add("First Name", 261, HorizontalAlignment.Center);
            lvwClient.Columns.Add("Last Name", 261, HorizontalAlignment.Center);
            lvwClient.Columns.Add("Phone No", 261, HorizontalAlignment.Center);
        }

        private void LoadDataClient()
        {
            lvwClient.Items.Clear();
            ClientController clientController = new ClientController();
            listOfClientEntity = clientController.ReadAllClient(); // Ensure this returns List<ClientEntity>
            

            foreach (ClientEntity client in listOfClientEntity) // Ensure client is of type ClientEntity
            {
                var noUrut = lvwClient.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(client.Firstname); // Accessing Firstname from ClientEntity
                item.SubItems.Add(client.Lastname);
                item.SubItems.Add(client.Phone.ToString()); // Accessing Phone from ClientEntity
                lvwClient.Items.Add(item);
            }
        }

        /*private void LoadDataClient()
        {
            lvwClient.Items.Clear();
            listOfClientEntity = clientEntity.ReadAll();
            foreach (var client in listOfClientEntity)
            {
                var noUrut = lvwClient.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(client.Firstname);
                item.SubItems.Add(client.Lastname);
                item.SubItems.Add(client.Phone.ToString());
                lvwClient.Items.Add(item);
            }
        }*/

        // method event handler untuk merespon event OnCreate,
        // ketika di panggil dari form entry mahasiswa
        private void usercontrolClient_OnCreate(ClientEntity clientEntity)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfClientEntity.Add(clientEntity);

            int noUrut = lvwClient.Items.Count + 1;

            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());

            item.SubItems.Add(clientEntity.Firstname);
            item.SubItems.Add(clientEntity.Lastname);
            item.SubItems.Add(clientEntity.Phone.ToString());
            lvwClient.Items.Add(item);
        }
        // method event handler untuk merespon event OnUpdate,
        // ketika di panggil dari form entry mahasiswa
        private void usercontrolClient_OnUpdate(ClientEntity clientEntity)
        {
            // ambil baris data mhs yang edit
            int row = lvwClient.SelectedIndices[0];
            // update informasi mhs di listview
            ListViewItem itemRow = lvwClient.Items[row];
            itemRow.SubItems[1].Text = clientEntity.Firstname;
            itemRow.SubItems[2].Text = clientEntity.Lastname;
            itemRow.SubItems[3].Text = clientEntity.Phone.ToString();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Add_Client add_Client = new Add_Client("Tambah Client");

            add_Client.OnCreate += usercontrolClient_OnCreate;

            add_Client.ShowDialog();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (lvwClient.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data client ingin dihapus ? ", "Konfirmasi",
               
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index list yang di pilih
                    var index = lvwClient.SelectedIndices[0];
                    // hapus objek mahasiswa dari list
                    listOfClientEntity.RemoveAt(index);
                    // refresh tampilan listivew
                    lvwClient.Items.RemoveAt(index);
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data client belum dipilih !!!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /*private void btnSearchClient_Click(object sender, EventArgs e)
        {
            if (lvwClient.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                ClientEntity clientEntity = listOfClientEntity[lvwClient.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                Update_Client update_Client = new Update_Client("Edit Data Mahasiswa", clientEntity);

               // mendaftarkan method event handler utk merespon event OnUpdate (subscribe)
                client.UpdateClient(clientEntity) += usercontrolClient_OnUpdate;

                // tampilkan form entry mahasiswa
                update_Client.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }*/

        private void lvwClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            Update_Client update_Client = new Update_Client("Update Client");
            update_Client.OnUpdate += usercontrolClient_OnUpdate;
            update_Client.ShowDialog();
            if (lvwClient.SelectedItems.Count > 0)
            {
                ClientEntity entity = listOfClientEntity[lvwClient.SelectedIndices[0]];
                Update_Client frmUpdate = new Update_Client("Edit Data Mahasiswa", entity);
                frmUpdate.OnUpdate += usercontrolClient_OnUpdate;
                frmUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
        }


        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchClient.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Masukkan nama client yang ingin dicari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ClientController clientController = new ClientController();
                List<ClientEntity> clientEntityList = clientController.ReadAllClient();
                lvwClient.Items.Clear();

                if (listOfClientEntity.Count > 0)
                {
                    foreach (ClientEntity client in listOfClientEntity)
                    {
                        var noUrut = lvwClient.Items.Count + 1;
                        var item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(client.Firstname); // Accessing Firstname from ClientEntity
                        item.SubItems.Add(client.Lastname);
                        item.SubItems.Add(client.Phone.ToString());
                        lvwClient.Items.Add(item);
                    }

                    /*foreach (ClientController client in clientList)
                    {
                        listOfClientEntity.Add(clientController);
                        int noUrut = lvwClient.Items.Count + 1;
                        ListViewItem item = new ListViewItem(noUrut.ToString());
                        item.SubItems.Add(client.Firstname);
                        item.SubItems.Add(client.Lastname);
                        item.SubItems.Add(client.Phone.ToString());
                        lvwClient.Items.Add(item);
                    }*/
                }
                else
                {
                    MessageBox.Show("Nama mahasiswa tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
