using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace MyMakan
{
    internal class AddAtmin
    {
        public string username;
        public string email;
        public string password_hash;
        public string phone_number;
        public string address;
        public string role;

        Koneksi koneksi = new Koneksi();

        public bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 3 || username.Contains(" "))
            {
                MessageBox.Show("Username harus minimal 3 karakter dan tidak boleh mengandung spasi!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email tidak valid!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$";
            if (string.IsNullOrWhiteSpace(password_hash) || !Regex.IsMatch(password_hash, passwordPattern))
            {
                MessageBox.Show("Password harus minimal 6 karakter dan mengandung huruf serta angka!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string phonePattern = @"^\d{10,15}$";
            if (string.IsNullOrWhiteSpace(phone_number) || !Regex.IsMatch(phone_number, phonePattern))
            {
                MessageBox.Show("Nomor telepon harus berupa angka dan minimal 10 digit!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Alamat tidak boleh kosong!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public void Create()
        {
            if (!ValidateForm())
            {
                return;
            }

            try
            {
                koneksi.bukaKoneksi();

                string checkQuery = "SELECT COUNT(*) FROM Adm.Admin WHERE username = @username OR email = @email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, koneksi.con);
                checkCmd.Parameters.AddWithValue("@username", username);
                checkCmd.Parameters.AddWithValue("@email", email);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Error: Username atau Email sudah digunakan!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string hashedPassword = HashPassword(password_hash);

                string query = "INSERT INTO Adm.Admin (username, email, password_hash, phone_number, address, role) VALUES (@username, @email, @pw, @phone, @address, @role)";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pw", hashedPassword);
                cmd.Parameters.AddWithValue("@phone", phone_number);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@role", role.ToLower());

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data gagal disimpan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
    }
}
