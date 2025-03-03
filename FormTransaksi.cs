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
using System.Xml.Linq;

namespace MyMakan
{
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void btcari_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            ArrayList item = new ArrayList();
            obj.productID = txkode.Text;
            item = obj.Cari();
            txnama.Text = item[0].ToString();
            txharga.Text = item[1].ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btco_Click(object sender, EventArgs e)
        {
            DataGridViewRow baris = new DataGridViewRow();
            baris.CreateCells(dgtransaksi);
            baris.Cells[0].Value = txnama.Text;
            baris.Cells[1].Value = cbkategori.Text;
            baris.Cells[2].Value = nujumlah.Value.ToString();
            baris.Cells[3].Value = nuharga.Text;
            dgtransaksi.Rows.Add(baris);
        }

        private void txnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuharga_ValueChanged(object sender, EventArgs e)
        {
            int jumlah = Convert.ToInt32(nujumlah.Value);
            int subtotal = jumlah * Convert.ToInt32(txharga.Text);
            txsubtotal.Text = subtotal.ToString();
        }

        private void dgtransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgitem.RowCount - 1)
            {
                DataGridViewRow row = dgitem.Rows[e.RowIndex];
                txProdID.Text = row.Cells[0].Value.ToString();
                txPname.Text = row.Cells[1].Value.ToString();
                nuprice.Text = row.Cells[3].Value.ToString();
                nustock.Text = row.Cells[4].Value.ToString();
                comboBoxCategory.SelectedValue = row.Cells[2].Value.ToString();
            }
        }
    }
}
