using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyMakan
{
    public partial class CashierPage : Form
    {
        string cashierName;
        public CashierPage(string name)
        {
            InitializeComponent();
            cashierName = name;
        }

        private void CashierPage_Load(object sender, EventArgs e)
        {
            lblname.Text = "Welcome, " + cashierName + "!";
            LoadProduct();
            TransHeader th = new TransHeader();
            lbtanggal.Text = DateTime.Now.ToLongDateString();
            txnumber.Text = th.GetNomorTransaksi();
        }

        void LoadProduct()
        {
            Barang brg = new Barang();
            DataSet ds = brg.Read();
            dgitem.DataSource = ds;
            dgitem.DataMember = "Product";
        }

        private void dgtransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Barang brg = new Barang();

        }

        private void btcari_Click(object sender, EventArgs e)
        {
            string namaProduk = txname.Text.Trim(); // Ambil nama produk dari TextBox pencarian

            if (string.IsNullOrWhiteSpace(namaProduk))
            {
                MessageBox.Show("Silakan masukkan nama produk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buat instance class pencarian produk
            Barang barang = new Barang();
            ArrayList hasil = barang.Cari(namaProduk);

            if (hasil.Count > 0)
            {
                txprodid.Text = hasil[0].ToString();
                txname.Text = hasil[1].ToString();
                txcatid.Text = hasil[2].ToString();
                txprice.Text = hasil[3].ToString();
                txstock.Text = hasil[4].ToString();
            }
            else
            {
                MessageBox.Show("Produk tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kosongkan TextBox jika tidak ditemukan
                txprodid.Clear();
                txname.Clear();
                txcatid.Clear();
                txprice.Clear();
                txstock.Clear();
            }
        }

        private void nujumlah_ValueChanged(object sender, EventArgs e)
        {
            decimal jumlah = Convert.ToDecimal(nujumlah.Value);
            decimal subtotal = jumlah * Convert.ToDecimal(txprice.Text);
            txsubtotal.Text = subtotal.ToString();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgtransaksi);
            row.Cells[0].Value = txprodid.Text;
            row.Cells[1].Value = txname.Text;
            row.Cells[2].Value = nujumlah.Text;
            row.Cells[3].Value = txsubtotal.Text;
            dgtransaksi.Rows.Add(row);
        }

        private void btco_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil nilai total belanja dan uang customer dari TextBox
                decimal totalBelanja = Convert.ToDecimal(txsubtotal.Text);
                decimal uangCustomer = Convert.ToDecimal(txuangcst.Text);

                // Pastikan uang customer cukup untuk membayar
                if (uangCustomer < totalBelanja)
                {
                    MessageBox.Show("Uang yang diberikan tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hitung kembalian
                decimal kembalian = uangCustomer - totalBelanja;

                // Tampilkan hasil di TextBox atau Label
                txkembalian.Text = kembalian.ToString("N2"); // Format angka desimal 2 digit
            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgtransaksi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btprint_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan input sudah diisi
                if (string.IsNullOrWhiteSpace(txname.Text) ||
                    string.IsNullOrWhiteSpace(txsubtotal.Text) ||
                    string.IsNullOrWhiteSpace(txuangcst.Text) ||
                    string.IsNullOrWhiteSpace(txkembalian.Text))
                {
                    MessageBox.Show("Silakan hitung kembalian terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ambil data transaksi
                string tanggal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string namaBarang = txname.Text;
                string totalBelanja = txsubtotal.Text;
                string uangCustomer = txuangcst.Text;

                string kembalian = txkembalian.Text;

                // Format struk transaksi
                string struk = $"======== STRUK TRANSAKSI ========\n" +
                               $"Tanggal        : {tanggal}\n" +
                               $"Nama Produk    : {namaBarang}\n"+
                               $"Total          : Rp {totalBelanja}\n" +
                               $"Uang           : Rp {uangCustomer}\n" +
                               $"Kembalian      : Rp {kembalian}\n" +
                               $"=================================\n" +
                               $"Terima kasih telah berbelanja!";

                // Dialog untuk menyimpan file
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files (*.txt)|*.txt";
                saveFile.FileName = "Struk_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // Simpan struk ke file .txt
                    File.WriteAllText(saveFile.FileName, struk);
                    MessageBox.Show("Struk berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
