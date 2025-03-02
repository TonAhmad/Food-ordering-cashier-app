using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMakan
{
    internal class Login
    {
        Koneksi koneksi = new Koneksi();

        // Method untuk melakukan hashing password dengan SHA-256
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool Authenticate(string username, string password, string selectedRole, out string roleFromDB)
        {
            roleFromDB = null;
            try
            {
                koneksi.bukaKoneksi();

                // Query untuk mengambil hash password dan role berdasarkan username
                string query = "SELECT password_hash, role FROM Adm.Admin WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["password_hash"].ToString();
                    roleFromDB = reader["role"].ToString().ToLower(); // Ambil role dari database

                    reader.Close();

                    // Cek apakah peran yang dipilih di ComboBox sesuai dengan yang ada di database
                    if (roleFromDB != selectedRole)
                    {
                        return false; // Role tidak sesuai
                    }

                    // Hash password input dan bandingkan dengan hash di database
                    string hashedInput = HashPassword(password);
                    if (hashedInput == storedHash)
                    {
                        return true; // Login berhasil
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }

            return false; // Login gagal
        }


    }
}
