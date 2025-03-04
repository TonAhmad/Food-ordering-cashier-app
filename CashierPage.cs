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

namespace MyMakan
{
    public partial class CashierPage : Form
    {
        string cashierName;
        public CashierPage()
        {
            InitializeComponent();
            //cashierName = name;
        }

        private void CashierPage_Load(object sender, EventArgs e)
        {
            lblname.Text = "Welcome, " + cashierName + "!";
            LoadProduct();
            TransHeader th = new TransHeader();
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
            row.Cells[2].Value = txsubtotal.Text;
            dgtransaksi.Rows.Add(row);
        }
    }
}
