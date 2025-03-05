using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyMakan
{
    internal class TransDetail
    {
        public string transID;
        public string productID;
        public int quantity;
        public decimal subtotal;

        Koneksi koneksi = new Koneksi();

        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Transactions.TransDetail (transID, productID, quantity, subtotal) VALUES (@transID, @productID, @quantity, @subtotal)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@transID", transID);
                com.Parameters.AddWithValue("@productID", productID);
                com.Parameters.AddWithValue("@quantity", quantity);
                com.Parameters.AddWithValue("@subtotal", subtotal);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data berhasil dimasukkan");
                }
                else
                {
                    MessageBox.Show("Data gagal dimasukkan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }
    }
}
