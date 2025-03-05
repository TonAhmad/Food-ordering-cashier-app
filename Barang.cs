using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMakan
{
    internal class Barang
    {
        public string productID;
        public string productName;
        public string categoryID;
        public decimal price;
        public int stock;

        Koneksi koneksi = new Koneksi();

        public bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(productName) || productName.Length < 3)
            {
                MessageBox.Show("Nama produk harus minimal 3 karakter!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(categoryID))
            {
                MessageBox.Show("Kategori harus dipilih!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show("Harga harus lebih dari 0!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stok tidak boleh negatif!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

                string query = "INSERT INTO item.product (productName, categoryID, price, stock) VALUES (@name, @category, @price, @stock)";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@name", productName);
                cmd.Parameters.AddWithValue("@category", categoryID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan produk!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kesalahan Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "SELECT * FROM item.Product";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Product");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        public void Update()
        {
            try
            {
                // Validasi input sebelum eksekusi query
                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Nama produk tidak boleh kosong!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (price <= 0)
                {
                    MessageBox.Show("Harga harus lebih dari 0!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (stock < 0)
                {
                    MessageBox.Show("Stok tidak boleh negatif!", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                koneksi.bukaKoneksi();
                string query = "UPDATE item.Product SET productName = @name, categoryID = @category, price = @price, stock = @stock WHERE productID = @id";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@id", productID);
                cmd.Parameters.AddWithValue("@name", productName);
                cmd.Parameters.AddWithValue("@category", categoryID);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@stock", stock);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Produk berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal mengubah produk! Produk mungkin tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kesalahan Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "DELETE FROM item.Product WHERE productID = @id";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                cmd.Parameters.AddWithValue("@id", productID);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Produk berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus produk!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kesalahan Database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
        public ArrayList Cari(string namaProduk)
        {
            ArrayList item = new ArrayList();
            try
            {
                koneksi.bukaKoneksi();
                string query = "SELECT productID, productName, categoryID, price, stock FROM item.Product WHERE productName = @namaProduk";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@namaProduk", namaProduk);
                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    item.Add(dr["productID"].ToString());   // Menyimpan ID Produk
                    item.Add(dr["productName"].ToString()); // Menyimpan Nama Produk
                    item.Add(dr["categoryID"].ToString());  // Menyimpan ID Kategori
                    item.Add(dr["price"].ToString());       // Menyimpan Harga
                    item.Add(dr["stock"].ToString());       // Menyimpan Stok
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Pencarian Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
            return item;
        }
    }
}
