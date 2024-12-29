using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Hotel.Controller;
using Sistem_Manajemen_Hotel.Model.Entity;
using Sistem_Manajemen_Hotel.Model.Repository;

namespace Sistem_Manajemen_Hotel.View
{
    public partial class Add_Client : Form
    {
        private List<ClientEntity> list = new List<ClientEntity>();

        public delegate void CreateUpdateEventHandler(ClientEntity client);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private ClientController _clientController;
        private bool isNewData = true;
        private ClientEntity clientEntity;

        public Add_Client()
        {
            InitializeComponent();
        }

        public Add_Client(string title, ClientController controller) : this()
        {
            this.Text = title;
            this._clientController = new ClientController();
        }
        public Add_Client(string title, ClientEntity obj, ClientController controller) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this._clientController = controller;
            isNewData = false; // set status edit data
            clientEntity = obj; // set objek mhs yang akan diedit
                                
            // untuk edit data, tampilkan data lama
            txtAddClientFirstName.Text = clientEntity.Firstname;
            txtAddClientLastName.Text = clientEntity.Lastname;
            txtAddClientPhoneNo.Text = clientEntity.Phone.ToString();
        }

        private void btnPopupAddClient_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) clientEntity = new ClientEntity();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            clientEntity.Firstname = txtAddClientFirstName.Text;
            clientEntity.Lastname = txtAddClientLastName.Text;
            clientEntity.Phone = int.Parse(txtAddClientPhoneNo.Text);

            if (isNewData) // data baru
            {
                OnCreate(clientEntity); // panggil event OnCreate
                
                // reset form input, utk persiapan input data berikutnya
                txtAddClientFirstName.Clear();
                txtAddClientLastName.Clear();
                txtAddClientPhoneNo.Clear();
                txtAddClientFirstName.Focus();
            }
            else // update
            {
                OnUpdate(clientEntity); // panggil event OnUpdate
                this.Close();
            }


            /*ClientEntity clientEntity = new ClientEntity();

            clientEntity.Firstname = txtAddClientFirstName.Text;
            clientEntity.Lastname = txtAddClientLastName.Text;
            clientEntity.Phone = int.Parse(txtAddClientPhoneNo.Text);

            list.Add(clientEntity);

            var msg = "Data Client berhasil di simpan.";

            MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetForm();*/
        }

        private bool NumericOnly(KeyPressEventArgs e)
        {
            var strValid = "0123456789";
            if (!(e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                // inputan selain angka
                if (strValid.IndexOf(e.KeyChar) < 0)
                {
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        private void txtAddClientPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = NumericOnly(e);
        }

        private void Add_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
