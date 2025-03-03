using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMakan
{
    internal class Koneksi
    {
        string source;
        public SqlConnection con;

        public Koneksi()
        {
            try
            {
                source = "Integrated Security=true;Initial Catalog=db_makan;Data Source=.";
                con = new SqlConnection(source);
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message);
            }
        }

        public void bukaKoneksi()
        {
            try
            {
                con.Open();
                //MessageBox.Show("Buka Koneksi Berhasil");
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message);
            }
        }

        public void tutupKoneksi()
        {
            try
            {
                con.Close();
                //MessageBox.Show("Tutup Koneksi Berhasil");
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Error : " + sqle.Message);
            }
        }
    }
}
