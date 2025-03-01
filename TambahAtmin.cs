using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyMakan
{
    public partial class TambahAtmin : Form
    {
        Koneksi Koneksi = new Koneksi();
        public TambahAtmin()
        {
            InitializeComponent();
        }

        private void btkoneksi_Click(object sender, EventArgs e)
        {
            Koneksi.bukaKoneksi();
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Koneksi.tutupKoneksi();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            AddAtmin adm = new AddAtmin();
            adm.username = txuname.Text;
            adm.email = txemail.Text;
            adm.password_hash = txpw.Text;
            adm.phone_number = txphone.Text;
            adm.address = txaddress.Text;
            adm.Create();
        }

        private void TambahAtmin_Load(object sender, EventArgs e)
        {

        }
    }
}
