using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistem_Manajemen_Hotel.Controler;
using Sistem_Manajemen_Hotel.Model.Entity;
using System.Data.SQLite;
using System.Data.SqlClient;
using Dapper;

namespace Sistem_Manajemen_Hotel.View
{
    public partial class Form_Login : Form
    {
        private SQLiteConnection _conn;
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                string dbName = @"D:\SEMESTER 3\Pemrograman Lanjut\Pengumpulan Tugas\Fp beneran\Sistem_Manajemen_Hotel_Final_Project-master\Sistem_Manajemen_Hotel\bin\Debug\database.db";

                string connectionString = string.Format("Data Source={0};FailIfMissing=True", dbName);

                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }
            return conn;
        }
            
        public Form_Login()
        {
            InitializeComponent();
            txtUsername.KeyPress += new KeyPressEventHandler(txtUsername_KeyPress);
            txtPassword.KeyPress += new KeyPressEventHandler(txtPassword_KeyPress);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Menahan karakter 'Enter' agar tidak ditampilkan di TextBox username
                txtPassword.Focus(); // Pindah fokus ke TextBox password
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick(); // Simulasikan klik pada tombol login
            }
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
            txtPassword.UseSystemPasswordChar = false; 
            pcbShow.Hide(); 
            pcbHide.Show();
        }

        private void pcbHide_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pcbHide.Hide();
            pcbShow.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Koneksi ke database SQLite
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=D:\\SEMESTER 3\\Pemrograman Lanjut\\Materi\\Sistem_Manajemen_Hotel_Final_Project-master\\Sistem_Manajemen_Hotel\\bin\\Debug\\database.db"))
                {
                    conn.Open(); // Membuka koneksi

                    if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        MessageBox.Show("Nama dan Password harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Query SQL untuk memverifikasi login
                    string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Menambahkan parameter
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        // Menjalankan query dan mendapatkan hasil
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Membuka form dashboard
                            Form_Dashboard form_Dashboard = new Form_Dashboard();
                            form_Dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Menangani error koneksi atau query
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            /*LoginEntity userlogin = new LoginEntity();

            userlogin.username = txtUsername.Text; // Ambil teks dari input username
            userlogin.password = txtPassword.Text;

            LoginController validateLogin = new LoginController();

            // Validasi sederhana
            if (string.IsNullOrWhiteSpace(userlogin.username))
            {
                MessageBox.Show("Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            validateLogin.AuthUserLogin(userlogin);

            //Form_Dashboard dashboard = new Form_Dashboard(username);
            //dashboard.Show();
            this.Hide();*/
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pcbHide.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
