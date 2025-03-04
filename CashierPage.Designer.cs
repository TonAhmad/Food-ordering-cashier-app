namespace MyMakan
{
    partial class CashierPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.txsubtotal = new System.Windows.Forms.TextBox();
            this.txname = new System.Windows.Forms.TextBox();
            this.btcari = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txprodid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txnumber = new System.Windows.Forms.TextBox();
            this.nujumlah = new System.Windows.Forms.NumericUpDown();
            this.btco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgitem = new System.Windows.Forms.DataGridView();
            this.txprice = new System.Windows.Forms.TextBox();
            this.txcatid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txstock = new System.Windows.Forms.TextBox();
            this.dgtransaksi = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsubmit = new System.Windows.Forms.Button();
            this.txuangcst = new System.Windows.Forms.TextBox();
            this.txkembalian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nujumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1532, 58);
            this.panel1.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 18);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(149, 25);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Cashier Name";
            // 
            // txsubtotal
            // 
            this.txsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txsubtotal.Location = new System.Drawing.Point(221, 676);
            this.txsubtotal.Name = "txsubtotal";
            this.txsubtotal.Size = new System.Drawing.Size(208, 30);
            this.txsubtotal.TabIndex = 45;
            // 
            // txname
            // 
            this.txname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txname.Location = new System.Drawing.Point(221, 486);
            this.txname.Name = "txname";
            this.txname.Size = new System.Drawing.Size(208, 30);
            this.txname.TabIndex = 43;
            // 
            // btcari
            // 
            this.btcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcari.Location = new System.Drawing.Point(450, 480);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(112, 36);
            this.btcari.TabIndex = 42;
            this.btcari.Text = "Search";
            this.btcari.UseVisualStyleBackColor = true;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Product Name";
            // 
            // txprodid
            // 
            this.txprodid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txprodid.Location = new System.Drawing.Point(221, 449);
            this.txprodid.Name = "txprodid";
            this.txprodid.Size = new System.Drawing.Size(208, 30);
            this.txprodid.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Kode Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nomor Transaksi";
            // 
            // txnumber
            // 
            this.txnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnumber.Location = new System.Drawing.Point(221, 410);
            this.txnumber.Name = "txnumber";
            this.txnumber.Size = new System.Drawing.Size(208, 30);
            this.txnumber.TabIndex = 35;
            // 
            // nujumlah
            // 
            this.nujumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nujumlah.Location = new System.Drawing.Point(221, 630);
            this.nujumlah.Name = "nujumlah";
            this.nujumlah.Size = new System.Drawing.Size(208, 30);
            this.nujumlah.TabIndex = 34;
            this.nujumlah.ValueChanged += new System.EventHandler(this.nujumlah_ValueChanged);
            // 
            // btco
            // 
            this.btco.Location = new System.Drawing.Point(648, 765);
            this.btco.Name = "btco";
            this.btco.Size = new System.Drawing.Size(326, 69);
            this.btco.TabIndex = 31;
            this.btco.Text = "Check Out";
            this.btco.UseVisualStyleBackColor = true;
            this.btco.Click += new System.EventHandler(this.btco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category";
            // 
            // dgitem
            // 
            this.dgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgitem.Location = new System.Drawing.Point(55, 83);
            this.dgitem.Name = "dgitem";
            this.dgitem.RowHeadersWidth = 51;
            this.dgitem.RowTemplate.Height = 24;
            this.dgitem.Size = new System.Drawing.Size(885, 293);
            this.dgitem.TabIndex = 26;
            this.dgitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtransaksi_CellContentClick);
            // 
            // txprice
            // 
            this.txprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txprice.Location = new System.Drawing.Point(221, 580);
            this.txprice.Name = "txprice";
            this.txprice.Size = new System.Drawing.Size(208, 30);
            this.txprice.TabIndex = 46;
            // 
            // txcatid
            // 
            this.txcatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcatid.Location = new System.Drawing.Point(221, 541);
            this.txcatid.Name = "txcatid";
            this.txcatid.Size = new System.Drawing.Size(208, 30);
            this.txcatid.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Subtotal";
            // 
            // txstock
            // 
            this.txstock.Location = new System.Drawing.Point(462, 452);
            this.txstock.Name = "txstock";
            this.txstock.Size = new System.Drawing.Size(100, 22);
            this.txstock.TabIndex = 49;
            this.txstock.Text = " ";
            // 
            // dgtransaksi
            // 
            this.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.ProductName,
            this.Totalprice});
            this.dgtransaksi.Location = new System.Drawing.Point(899, 396);
            this.dgtransaksi.Name = "dgtransaksi";
            this.dgtransaksi.RowHeadersWidth = 51;
            this.dgtransaksi.RowTemplate.Height = 24;
            this.dgtransaksi.Size = new System.Drawing.Size(428, 319);
            this.dgtransaksi.TabIndex = 50;
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Totalprice
            // 
            this.Totalprice.HeaderText = "Total Price";
            this.Totalprice.MinimumWidth = 6;
            this.Totalprice.Name = "Totalprice";
            this.Totalprice.Width = 125;
            // 
            // btsubmit
            // 
            this.btsubmit.Location = new System.Drawing.Point(211, 735);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(246, 76);
            this.btsubmit.TabIndex = 51;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // txuangcst
            // 
            this.txuangcst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txuangcst.Location = new System.Drawing.Point(606, 444);
            this.txuangcst.Name = "txuangcst";
            this.txuangcst.Size = new System.Drawing.Size(218, 30);
            this.txuangcst.TabIndex = 52;
            // 
            // txkembalian
            // 
            this.txkembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txkembalian.Location = new System.Drawing.Point(606, 536);
            this.txkembalian.Name = "txkembalian";
            this.txkembalian.Size = new System.Drawing.Size(218, 30);
            this.txkembalian.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Dibayar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Kembalian";
            // 
            // CashierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 902);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txkembalian);
            this.Controls.Add(this.txuangcst);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.dgtransaksi);
            this.Controls.Add(this.txstock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txcatid);
            this.Controls.Add(this.txprice);
            this.Controls.Add(this.txsubtotal);
            this.Controls.Add(this.txname);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txprodid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txnumber);
            this.Controls.Add(this.nujumlah);
            this.Controls.Add(this.btco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgitem);
            this.Controls.Add(this.panel1);
            this.Name = "CashierPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nujumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txsubtotal;
        private System.Windows.Forms.TextBox txname;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txprodid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txnumber;
        private System.Windows.Forms.NumericUpDown nujumlah;
        private System.Windows.Forms.Button btco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgitem;
        private System.Windows.Forms.TextBox txprice;
        private System.Windows.Forms.TextBox txcatid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txstock;
        private System.Windows.Forms.DataGridView dgtransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalprice;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.TextBox txuangcst;
        private System.Windows.Forms.TextBox txkembalian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}