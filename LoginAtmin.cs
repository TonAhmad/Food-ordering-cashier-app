using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMakan
{
    public partial class LoginAtmin : Form
    {
        public LoginAtmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            string roleFromDB;
            string fullname;

            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih peran!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = comboBoxRole.SelectedItem.ToString().ToLower(); // Ambil role dari ComboBox

            if (login.Authenticate(txtUsername.Text, txtPassword.Text, selectedRole, out roleFromDB, out fullname))
            {
                MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (roleFromDB == "admin")
                {
                    AtminDashboard dashboard = new AtminDashboard(fullname);
                    dashboard.Show();
                }
                else if (roleFromDB == "cashier")
                {
                    CashierPage cashierPage = new CashierPage(fullname);
                    cashierPage.Show();
                }

                this.Hide(); // Menyembunyikan form login setelah berhasil
            }
            else
            {
                MessageBox.Show("Username, password, atau peran salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
