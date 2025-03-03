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
        public DateTime TransDate;
        public int Total;

        Koneksi koneksi = new Koneksi();

        public void Create()
        {
            try
            {
                koneksi.bukaKoneksi();
                string query = "INSERT INTO Transactions.TransHeader VALUES (@number, @kodeadmin, @tanggal, @total)";
                SqlCommand com = new SqlCommand(query, koneksi.con);
                com.Parameters.AddWithValue("@number", transID);
                com.Parameters.AddWithValue("@kodeadmin ", admin_id);
                com.Parameters.AddWithValue("@tanggal", TransDate);
                com.Parameters.AddWithValue("@total", Total);
                int i = com.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Berhasil Dimasukkan");
                }
                else
                {
                    MessageBox.Show("Data Gagal Dimasukkan");

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
            no = GlobalVariable.kodeadmin.Substring(2) + hasil.ToString() + random.Next(100, 999);
            return no;
        }

    }
}
