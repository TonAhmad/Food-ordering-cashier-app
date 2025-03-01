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
        public string categoryName;

        Koneksi koneksi = new Koneksi();

        public void create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Item.Category(categoryName) VALUES (@nama)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@nama", categoryName);
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
        public DataSet Read()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "SELECT * FROM Item.Category";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(ds, "Category");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
    }
}
