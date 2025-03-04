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
        List<Tuple<string, decimal, int, decimal>> daftarProduk = new List<Tuple<string, decimal, int, decimal>>();

        private void nujumlah_ValueChanged(object sender, EventArgs e)
        {
            decimal jumlah = Convert.ToDecimal(nujumlah.Value);
            decimal subtotal = jumlah * Convert.ToDecimal(txprice.Text);
            txsubtotal.Text = subtotal.ToString("N2");
        }

        private void HitungGrandTotal()
        {
            decimal grandTotal = daftarProduk.Sum(item => item.Item4); // Total semua subtotal produk
            txgrandtotal.Text = grandTotal.ToString("N2");
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
                // Ambil nilai Grand Total dan uang customer dari TextBox
                decimal grandTotal = Convert.ToDecimal(txgrandtotal.Text); // Semua produk dalam transaksi
                decimal uangCustomer = Convert.ToDecimal(txuangcst.Text);

                // Pastikan uang customer cukup untuk membayar
                if (uangCustomer < grandTotal)
                {
                    MessageBox.Show("Uang yang diberikan tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hitung kembalian
                decimal kembalian = uangCustomer - grandTotal;

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
                if (daftarStruk.Count == 0)
                {
                    MessageBox.Show("Tambahkan minimal satu produk sebelum mencetak struk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txgrandtotal.Text) || string.IsNullOrWhiteSpace(txuangcst.Text))
                {
                    MessageBox.Show("Harap masukkan total belanja dan uang customer!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal totalBelanja = Convert.ToDecimal(txgrandtotal.Text); // Ambil Grand Total dari semua produk
                decimal uangCustomer = Convert.ToDecimal(txuangcst.Text);
                decimal kembalian = uangCustomer - totalBelanja;
                string tanggal = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Format struk
                string struk = "======== STRUK TRANSAKSI ========\n";
                struk += $"Tanggal    : {tanggal}\n";
                struk += "---------------------------------\n";
                struk += "Produk          Qty   Harga   Subtotal\n";
                struk += "---------------------------------\n";

                // Tambahkan semua produk yang ada dalam daftar
                foreach (var item in daftarStruk)
                {
                    struk += item + "\n";
                }

                // Tambahkan total, uang customer, dan kembalian
                struk += "---------------------------------\n";
                struk += $"Grand Total : Rp {totalBelanja:N2}\n";
                struk += $"Uang        : Rp {uangCustomer:N2}\n";
                struk += $"Kembalian   : Rp {kembalian:N2}\n";
                struk += "=================================\n";
                struk += "Terima kasih telah berbelanja!\n";

                // Simpan struk ke file .txt
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files (*.txt)|*.txt";
                saveFile.FileName = "Struk_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, struk);
                    MessageBox.Show("Struk berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reset daftar produk dan input setelah transaksi
                daftarStruk.Clear();
                daftarProduk.Clear(); // Tambahkan ini agar daftarProduk juga kosong setelah transaksi
                txgrandtotal.Clear();
                txuangcst.Clear();
                txkembalian.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txsubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txname_TextChanged(object sender, EventArgs e)
        {

        }
        private List<string> daftarStruk = new List<string>();
        private void bttambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txname.Text) || string.IsNullOrWhiteSpace(txprice.Text))
                {
                    MessageBox.Show("Harap masukkan nama produk dan harga!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string namaProduk = txname.Text;
                decimal hargaProduk = Convert.ToDecimal(txprice.Text);
                int jumlahProduk = Convert.ToInt32(nujumlah.Value);
                decimal subtotal = Convert.ToDecimal(txsubtotal.Text);

                // Tambahkan produk ke daftarProduk
                daftarProduk.Add(Tuple.Create(namaProduk, hargaProduk, jumlahProduk, subtotal));

                // Tambahkan produk ke daftarStruk (agar bisa diproses saat print)
                daftarStruk.Add($"{namaProduk.PadRight(12)} {jumlahProduk}  Rp{hargaProduk:N2}  Rp{subtotal:N2}");

                // Update Grand Total setiap kali ada produk baru
                HitungGrandTotal();

                // Bersihkan input setelah menambahkan produk
                txname.Clear();
                txprice.Clear();
                txsubtotal.Clear();
                nujumlah.Value = 1;

                MessageBox.Show("Produk berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
