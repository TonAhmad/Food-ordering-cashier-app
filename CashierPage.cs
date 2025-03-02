using System;
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
        public CashierPage(string name)
        {
            InitializeComponent();
            cashierName = name;
        }

        private void CashierPage_Load(object sender, EventArgs e)
        {
            lblname.Text = "Welcome, " + cashierName + "!";
        }
    }
}
