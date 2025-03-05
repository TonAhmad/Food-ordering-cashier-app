using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MyMakan;

namespace MyMakan
{
    class TransHeader
    {
        public string transID;
        public string admin_id;
        public decimal total;

        Koneksi koneksi = new Koneksi();
        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Transactions.TransHeader (transID, admin_ID, total)VALUES (@kode, @admin, @total)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@kode", transID);
                com.Parameters.AddWithValue("@admin", admin_id);
                com.Parameters.AddWithValue("@total", total);
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

        public string GetNomorTransaksi()
        {
            string no;
            int tanggal, bulan, tahun, jam, menit, detik;
            Random random = new Random();
            tanggal = Convert.ToInt32(DateTime.Now.Day.ToString());
            bulan = Convert.ToInt32(DateTime.Now.Month.ToString());
            tahun = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2));
            jam = Convert.ToInt32(DateTime.Now.Hour.ToString());
            menit = Convert.ToInt32(DateTime.Now.Minute.ToString());
            detik = Convert.ToInt32(DateTime.Now.Second.ToString());
            int hasil = (tanggal + bulan + tahun) * (jam + menit + detik);
            no = session.kodeAdmin.Substring(2) + hasil.ToString() + random.Next(100, 999);
            return no;
        }

    }
}
