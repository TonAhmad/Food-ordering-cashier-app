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
            Barang obj = new Barang();
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

        }
    }
}
