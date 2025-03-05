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
            this.lbtanggal = new System.Windows.Forms.Label();
            this.lbnama = new System.Windows.Forms.Label();
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
            this.txprice = new System.Windows.Forms.TextBox();
            this.txcatid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txstock = new System.Windows.Forms.TextBox();
            this.dgtransaksi = new System.Windows.Forms.DataGridView();
            this.txuangcst = new System.Windows.Forms.TextBox();
            this.txkembalian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btprint = new System.Windows.Forms.Button();
            this.bttambah = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txgrandtotal = new System.Windows.Forms.TextBox();
            this.dgitem = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nujumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.lbtanggal);
            this.panel1.Controls.Add(this.lbnama);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1769, 58);
            this.panel1.TabIndex = 0;
            // 
            // lbtanggal
            // 
            this.lbtanggal.AutoSize = true;
            this.lbtanggal.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtanggal.Location = new System.Drawing.Point(1009, 18);
            this.lbtanggal.Name = "lbtanggal";
            this.lbtanggal.Size = new System.Drawing.Size(98, 26);
            this.lbtanggal.TabIndex = 56;
            this.lbtanggal.Text = "Tanggal";
            // 
            // lbnama
            // 
            this.lbnama.AutoSize = true;
            this.lbnama.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnama.Location = new System.Drawing.Point(167, 20);
            this.lbnama.Name = "lbnama";
            this.lbnama.Size = new System.Drawing.Size(0, 23);
            this.lbnama.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 18);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(177, 28);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Cashier Name";
            // 
            // txsubtotal
            // 
            this.txsubtotal.Enabled = false;
            this.txsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txsubtotal.Location = new System.Drawing.Point(412, 762);
            this.txsubtotal.Name = "txsubtotal";
            this.txsubtotal.Size = new System.Drawing.Size(208, 30);
            this.txsubtotal.TabIndex = 45;
            // 
            // txname
            // 
            this.txname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txname.Location = new System.Drawing.Point(56, 635);
            this.txname.Name = "txname";
            this.txname.Size = new System.Drawing.Size(208, 30);
            this.txname.TabIndex = 43;
            this.txname.TextChanged += new System.EventHandler(this.txname_TextChanged);
            // 
            // btcari
            // 
            this.btcari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcari.Location = new System.Drawing.Point(270, 632);
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
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 607);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "Product Name";
            // 
            // txprodid
            // 
            this.txprodid.Enabled = false;
            this.txprodid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txprodid.Location = new System.Drawing.Point(412, 559);
            this.txprodid.Name = "txprodid";
            this.txprodid.Size = new System.Drawing.Size(208, 30);
            this.txprodid.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Kode Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nomor Transaksi";
            // 
            // txnumber
            // 
            this.txnumber.Enabled = false;
            this.txnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnumber.Location = new System.Drawing.Point(56, 559);
            this.txnumber.Name = "txnumber";
            this.txnumber.Size = new System.Drawing.Size(208, 30);
            this.txnumber.TabIndex = 35;
            // 
            // nujumlah
            // 
            this.nujumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nujumlah.Location = new System.Drawing.Point(412, 694);
            this.nujumlah.Name = "nujumlah";
            this.nujumlah.Size = new System.Drawing.Size(208, 30);
            this.nujumlah.TabIndex = 34;
            this.nujumlah.ValueChanged += new System.EventHandler(this.nujumlah_ValueChanged);
            // 
            // btco
            // 
            this.btco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btco.Location = new System.Drawing.Point(155, 517);
            this.btco.Name = "btco";
            this.btco.Size = new System.Drawing.Size(196, 54);
            this.btco.TabIndex = 31;
            this.btco.Text = "Check Out";
            this.btco.UseVisualStyleBackColor = true;
            this.btco.Click += new System.EventHandler(this.btco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 734);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 668);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Category";
            // 
            // txprice
            // 
            this.txprice.Enabled = false;
            this.txprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txprice.Location = new System.Drawing.Point(56, 762);
            this.txprice.Name = "txprice";
            this.txprice.Size = new System.Drawing.Size(208, 30);
            this.txprice.TabIndex = 46;
            this.txprice.TextChanged += new System.EventHandler(this.txprice_TextChanged_1);
            // 
            // txcatid
            // 
            this.txcatid.Enabled = false;
            this.txcatid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcatid.Location = new System.Drawing.Point(56, 693);
            this.txcatid.Name = "txcatid";
            this.txcatid.Size = new System.Drawing.Size(208, 30);
            this.txcatid.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 734);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Subtotal";
            // 
            // txstock
            // 
            this.txstock.Enabled = false;
            this.txstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txstock.Location = new System.Drawing.Point(412, 632);
            this.txstock.Name = "txstock";
            this.txstock.Size = new System.Drawing.Size(208, 30);
            this.txstock.TabIndex = 49;
            this.txstock.Text = " ";
            // 
            // dgtransaksi
            // 
            this.dgtransaksi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.ProductName,
            this.quantity,
            this.subtotal});
            this.dgtransaksi.Location = new System.Drawing.Point(1014, 168);
            this.dgtransaksi.Name = "dgtransaksi";
            this.dgtransaksi.RowHeadersWidth = 51;
            this.dgtransaksi.RowTemplate.Height = 24;
            this.dgtransaksi.Size = new System.Drawing.Size(722, 319);
            this.dgtransaksi.TabIndex = 50;
            this.dgtransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtransaksi_CellContentClick_1);
            // 
            // txuangcst
            // 
            this.txuangcst.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txuangcst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txuangcst.Location = new System.Drawing.Point(1014, 559);
            this.txuangcst.Name = "txuangcst";
            this.txuangcst.Size = new System.Drawing.Size(218, 30);
            this.txuangcst.TabIndex = 52;
            // 
            // txkembalian
            // 
            this.txkembalian.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txkembalian.Enabled = false;
            this.txkembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txkembalian.Location = new System.Drawing.Point(1269, 559);
            this.txkembalian.Name = "txkembalian";
            this.txkembalian.Size = new System.Drawing.Size(218, 30);
            this.txkembalian.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1009, 531);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Dibayar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Kembalian";
            // 
            // btprint
            // 
            this.btprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprint.Location = new System.Drawing.Point(455, 514);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(196, 54);
            this.btprint.TabIndex = 56;
            this.btprint.Text = "Print Receipt";
            this.btprint.UseVisualStyleBackColor = true;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // bttambah
            // 
            this.bttambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttambah.Location = new System.Drawing.Point(212, 715);
            this.bttambah.Name = "bttambah";
            this.bttambah.Size = new System.Drawing.Size(196, 54);
            this.bttambah.TabIndex = 57;
            this.bttambah.Text = "Tambah Produk";
            this.bttambah.UseVisualStyleBackColor = true;
            this.bttambah.Click += new System.EventHandler(this.bttambah_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1513, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Grand Total";
            // 
            // txgrandtotal
            // 
            this.txgrandtotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txgrandtotal.Enabled = false;
            this.txgrandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txgrandtotal.Location = new System.Drawing.Point(1518, 559);
            this.txgrandtotal.Name = "txgrandtotal";
            this.txgrandtotal.Size = new System.Drawing.Size(218, 30);
            this.txgrandtotal.TabIndex = 58;
            // 
            // dgitem
            // 
            this.dgitem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgitem.Location = new System.Drawing.Point(52, 168);
            this.dgitem.Name = "dgitem";
            this.dgitem.RowHeadersWidth = 51;
            this.dgitem.RowTemplate.Height = 24;
            this.dgitem.Size = new System.Drawing.Size(875, 319);
            this.dgitem.TabIndex = 61;
            this.dgitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgitem_CellContentClick);
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
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Total Price";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(407, 604);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "Stock";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 28);
            this.label12.TabIndex = 63;
            this.label12.Text = "Product Table";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1009, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 28);
            this.label13.TabIndex = 64;
            this.label13.Text = "Transaction Table";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bttambah);
            this.panel2.Location = new System.Drawing.Point(34, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 824);
            this.panel2.TabIndex = 65;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btco);
            this.panel3.Controls.Add(this.btprint);
            this.panel3.Location = new System.Drawing.Point(998, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 601);
            this.panel3.TabIndex = 66;
            // 
            // CashierPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1769, 942);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgitem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txgrandtotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txkembalian);
            this.Controls.Add(this.txuangcst);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "CashierPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CashierPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nujumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox txprice;
        private System.Windows.Forms.TextBox txcatid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txstock;
        private System.Windows.Forms.DataGridView dgtransaksi;
        private System.Windows.Forms.TextBox txuangcst;
        private System.Windows.Forms.TextBox txkembalian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbnama;
        private System.Windows.Forms.Label lbtanggal;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.Button bttambah;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txgrandtotal;
        private System.Windows.Forms.DataGridView dgitem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}