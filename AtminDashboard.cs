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
    public partial class AtminDashboard : Form
    {
        Koneksi koneksi = new Koneksi();
        public AtminDashboard()
        {
            InitializeComponent();
        }

        private void AtminDashboard_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategory();
            LoadProduct();
        }
        void LoadData()
        {
            Category cat = new Category();
            DataSet ds = cat.Read();
            dgcategory.DataSource = ds;
            dgcategory.DataMember = "Category";
        }

        void ClearData()
        {
            txcategory.Text = "";
        }
        void ClearProduct()
        {
            txPname.Text = "";
            nuprice.Text = "";
            nustock.Text = "";
        }

        void LoadCategory()
        {
            try
            {
                koneksi.bukaKoneksi();

                string query = "SELECT categoryID, categoryName FROM item.category";
                SqlCommand cmd = new SqlCommand(query, koneksi.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Set ComboBox Data Source
                comboBoxCategory.DataSource = dt;
                comboBoxCategory.DisplayMember = "categoryName";
                comboBoxCategory.ValueMember = "categoryID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Gagal mengambil data kategori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.tutupKoneksi();
            }
        }


        void LoadProduct()
        {
            Barang brg = new Barang();
            DataSet ds = brg.Read();
            dgitem.DataSource = ds;
            dgitem.DataMember = "Product";
        }

        private void btcategory_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.categoryName = txcategory.Text;
            cat.Create();
            LoadData();
            ClearData();
            LoadCategory();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();

            barang.productName = txPname.Text;
            barang.price = decimal.Parse(nuprice.Text);
            barang.stock = int.Parse(nustock.Text);

            if (comboBoxCategory.SelectedValue != null)
            {
                barang.categoryID = comboBoxCategory.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Silakan pilih kategori!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            barang.Create();
            LoadProduct();
            ClearProduct();
        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.productID = txProdID.Text;
            barang.productName = txPname.Text;
            barang.price = decimal.Parse(nuprice.Text);
            barang.stock = int.Parse(nustock.Text);
            if (comboBoxCategory.SelectedValue != null)
            {
                barang.categoryID = comboBoxCategory.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Silakan pilih kategori!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            barang.Update();
            LoadProduct();
            ClearProduct();
        }

        private void dgitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btdelete_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();
            barang.productID = txProdID.Text;
            barang.Delete();
            LoadProduct();
            ClearProduct();
        }

        private void dgcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgcategory.RowCount - 1)
            {
                DataGridViewRow row = dgcategory.Rows[e.RowIndex];
                txcatid.Text = row.Cells[0].Value.ToString();
                txcategory.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btupcat_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.categoryID = txcatid.Text;
            cat.categoryName = txcategory.Text;
            cat.Update();
            LoadData();
            ClearData();
            LoadCategory();
        }

        private void btdelcat_Click(object sender, EventArgs e)
        {
            Category cat = new Category();
            cat.categoryID = txcatid.Text;
            cat.Delete();
            LoadData();
            ClearData();
            LoadCategory();
        }
    }
}
