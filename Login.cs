﻿using System;
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

        public bool Authenticate(string username, string password, string selectedRole, out string roleFromDB, out string fullname)
        {
            roleFromDB = null;
            fullname = null;

            try
            {
                koneksi.bukaKoneksi();

                string query = "SELECT password_hash, role, username FROM Adm.Admin WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@username", username);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string storedHash = reader["password_hash"].ToString();
                    roleFromDB = reader["role"].ToString().ToLower();
                    fullname = reader["username"].ToString();
                    reader.Close();

                    if (roleFromDB != selectedRole)
                    {
                        return false;
                    }

                    string hashedInput = HashPassword(password);
                    if (hashedInput == storedHash)
                    {
                        return true;
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

            return false;
        }
    }
}
