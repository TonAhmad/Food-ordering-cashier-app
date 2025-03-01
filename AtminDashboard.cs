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
                comboBoxCategory.DisplayMember = "categoryName"; // Menampilkan nama kategori
                comboBoxCategory.ValueMember = "categoryID"; // Menyimpan ID kategori
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
            cat.create();
            LoadData();
            ClearData();
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            Barang barang = new Barang();

            // Ambil data dari form input
            barang.productName = txPname.Text;
            barang.price = decimal.Parse(txPrice.Text);
            barang.stock = int.Parse(txStock.Text);

            // Ambil categoryID dari ComboBox
            if (comboBoxCategory.SelectedValue != null)
            {
                barang.categoryID = comboBoxCategory.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Silakan pilih kategori!", "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan ke database
            barang.Create();
        }
    }
}
