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
using static System.Collections.Specialized.BitVector32;

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

        }

        private void btcari_Click(object sender, EventArgs e)
        {
            string namaProduk = txname.Text.Trim();

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
            if (string.IsNullOrWhiteSpace(txprice.Text))
            {
                txsubtotal.Text = "0.00";
                return;
            }

            decimal jumlah = Convert.ToDecimal(nujumlah.Value);
            decimal harga;

            if (decimal.TryParse(txprice.Text, out harga))
            {
                decimal subtotal = jumlah * harga;
                txsubtotal.Text = subtotal.ToString("N2");
            }
            else
            {
                txsubtotal.Text = "0.00"; // Jika harga tidak valid, set subtotal ke 0
            }
        }

        private void HitungGrandTotal()
        {
            decimal grandTotal = daftarProduk.Sum(item => item.Item4); // Total semua subtotal produk
            txgrandtotal.Text = grandTotal.ToString("N2");
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
        }

        private void btco_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah admin_id tersedia
                if (string.IsNullOrWhiteSpace(session.kodeAdmin))
                {
                    MessageBox.Show("Admin ID tidak valid! Harap login ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal grandTotal;
                decimal uangCustomer;

                // Cek apakah nilai yang dimasukkan valid
                if (!decimal.TryParse(txgrandtotal.Text, out grandTotal) || !decimal.TryParse(txuangcst.Text, out uangCustomer))
                {
                    MessageBox.Show("Masukkan angka yang valid pada total atau uang customer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (uangCustomer < grandTotal)
                {
                    MessageBox.Show("Uang yang diberikan tidak cukup!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal kembalian = uangCustomer - grandTotal;
                txkembalian.Text = kembalian.ToString("N2");


            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                try
                {
                    decimal total = 0;

                    for (int i = 0; i < dgtransaksi.RowCount - 1; i++)
                    {
                        // Periksa apakah data di kolom 3 valid sebelum dikonversi
                        if (dgtransaksi.Rows[i].Cells[3].Value != null &&
                            decimal.TryParse(dgtransaksi.Rows[i].Cells[3].Value.ToString(), out decimal harga))
                        {
                            total += harga;
                        }
                        else
                        {
                            MessageBox.Show($"Data pada baris {i + 1} tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    TransHeader th = new TransHeader();
                    th.transID = txnumber.Text;
                    th.admin_id = session.kodeAdmin;
                    th.total = total;
                    th.Create();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("nahloh: " + ex.Message);
                }
                try
                {
                    for (int j = 0; j < dgtransaksi.RowCount - 1; j++)
                    {
                        string kode = dgtransaksi.Rows[j].Cells[0].Value.ToString();
                        int jumlah = Convert.ToInt32(dgtransaksi.Rows[j].Cells[2].Value.ToString());
                        decimal subtotal = Convert.ToDecimal(dgtransaksi.Rows[j].Cells[3].Value);
                        TransDetail td = new TransDetail();
                        td.transID = txnumber.Text;
                        td.productID = kode;
                        td.quantity = jumlah;
                        td.subtotal = subtotal;
                        td.Create();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("nahloh:" + ex.Message);
                }
                MessageBox.Show("Transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan transaksi: " + ex.Message);
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
                dgtransaksi.Rows.Clear();
                txgrandtotal.Clear();
                txuangcst.Clear();
                txkembalian.Clear();
                LoadProduct();
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
                // Validasi apakah nama produk dan harga sudah diisi
                if (string.IsNullOrWhiteSpace(txname.Text) || string.IsNullOrWhiteSpace(txprice.Text))
                {
                    MessageBox.Show("Harap masukkan nama produk dan harga!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi harga: Pastikan bisa dikonversi ke decimal dan lebih besar dari 0
                if (!decimal.TryParse(txprice.Text, out decimal hargaProduk) || hargaProduk <= 0)
                {
                    MessageBox.Show("Harga harus berupa angka dan lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi jumlah: Pastikan jumlah lebih dari 0
                if (nujumlah.Value <= 0)
                {
                    MessageBox.Show("Jumlah produk harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi stok: Periksa apakah jumlah yang dimasukkan tidak melebihi stok yang tersedia
                if (!int.TryParse(txstock.Text, out int stokTersedia))
                {
                    MessageBox.Show("Stok produk tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int jumlahProduk = Convert.ToInt32(nujumlah.Value);

                if (jumlahProduk > stokTersedia)
                {
                    MessageBox.Show($"Stok tidak mencukupi! Stok tersedia: {stokTersedia}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hitung subtotal berdasarkan jumlah dan harga
                decimal subtotal = hargaProduk * jumlahProduk;

                // Tambah ke DataGridView
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgtransaksi);
                row.Cells[0].Value = txprodid.Text;
                row.Cells[1].Value = txname.Text;
                row.Cells[2].Value = jumlahProduk;
                row.Cells[3].Value = subtotal;
                dgtransaksi.Rows.Add(row);

                // Tambahkan produk ke daftarProduk
                string namaProduk = txname.Text;
                daftarProduk.Add(Tuple.Create(namaProduk, hargaProduk, jumlahProduk, subtotal));

                // Tambahkan produk ke daftarStruk (agar bisa diproses saat print)
                daftarStruk.Add($"{namaProduk.PadRight(12)} {jumlahProduk}  Rp{hargaProduk:N2}  Rp{subtotal:N2}");

                // Update Grand Total setiap kali ada produk baru
                HitungGrandTotal();

                // Bersihkan input setelah menambahkan produk
                txprodid.Clear();
                txname.Clear();
                txcatid.Clear();
                txprice.Text = "0"; // Set harga ke 0 agar tidak error
                txstock.Clear();
                txsubtotal.Clear();
                nujumlah.Value = 1; // Default ke 1 agar tidak error

                MessageBox.Show("Produk berhasil ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txprice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dgitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgitem.RowCount - 1)
            {
                DataGridViewRow row = dgitem.Rows[e.RowIndex];
                txprodid.Text = row.Cells[0].Value.ToString();
                txname.Text = row.Cells[1].Value.ToString();
                txcatid.Text = row.Cells[2].Value.ToString();
                txprice.Text = row.Cells[3].Value.ToString();
                txstock.Text = row.Cells[4].Value.ToString();
            }

        }
    }
}
