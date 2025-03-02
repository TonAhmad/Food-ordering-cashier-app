using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MyMakan
{
    internal class Category
    {
        public string categoryID;
        public string categoryName;
        Koneksi koneksi = new Koneksi();

        public bool ValidateCategory()
        {
            if (string.IsNullOrWhiteSpace(categoryName) || categoryName.Length < 3)
            {
                MessageBox.Show("Nama kategori harus minimal 3 karakter dan tidak boleh kosong!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Cek apakah kategori sudah ada di database
            try
            {
                koneksi.bukaKoneksi();
                string checkQuery = "SELECT COUNT(*) FROM Item.Category WHERE categoryName = @nama";
                SqlCommand checkCmd = new SqlCommand(checkQuery, koneksi.con);
                checkCmd.Parameters.AddWithValue("@nama", categoryName);
                int count = (int)checkCmd.ExecuteScalar();
                koneksi.tutupKoneksi();

                if (count > 0)
                {
                    MessageBox.Show("Kategori sudah ada!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat validasi: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void Create()
        {
            if (!ValidateCategory())
            {
                return;
            }

            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Item.Category(categoryName) VALUES (@nama)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", categoryName);
                int i = com.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dimasukkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data gagal dimasukkan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        public DataSet Read()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT * FROM Item.Category";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Category");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
            return ds;
        }
        public void Update()
        {
            if (!ValidateCategory())
            {
                return;
            }
            try
            {
                koneksi.bukaKoneksi();
                string query = "UPDATE Item.Category SET categoryName = @nama WHERE categoryID = @id";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", categoryName);
                com.Parameters.AddWithValue("@id", categoryID);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data gagal diubah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        public void Delete()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "DELETE FROM Item.Category WHERE categoryID = @id";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@id", categoryID);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
