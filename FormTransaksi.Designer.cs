﻿namespace MyMakan
{
    partial class FormTransaksi
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
            this.dgtransaksi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btco = new System.Windows.Forms.Button();
            this.txnama = new System.Windows.Forms.TextBox();
            this.nuharga = new System.Windows.Forms.NumericUpDown();
            this.nujumlah = new System.Windows.Forms.NumericUpDown();
            this.txnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txkode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btcari = new System.Windows.Forms.Button();
            this.txnama2 = new System.Windows.Forms.TextBox();
            this.txharga = new System.Windows.Forms.TextBox();
            this.txsubtotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuharga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nujumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtransaksi
            // 
            this.dgtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtransaksi.Location = new System.Drawing.Point(54, 32);
            this.dgtransaksi.Name = "dgtransaksi";
            this.dgtransaksi.RowHeadersWidth = 51;
            this.dgtransaksi.RowTemplate.Height = 24;
            this.dgtransaksi.Size = new System.Drawing.Size(966, 293);
            this.dgtransaksi.TabIndex = 0;
            this.dgtransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtransaksi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // btco
            // 
            this.btco.Location = new System.Drawing.Point(66, 526);
            this.btco.Name = "btco";
            this.btco.Size = new System.Drawing.Size(326, 69);
            this.btco.TabIndex = 5;
            this.btco.Text = "Check Out";
            this.btco.UseVisualStyleBackColor = true;
            this.btco.Click += new System.EventHandler(this.btco_Click);
            // 
            // txnama
            // 
            this.txnama.Location = new System.Drawing.Point(162, 363);
            this.txnama.Name = "txnama";
            this.txnama.Size = new System.Drawing.Size(208, 22);
            this.txnama.TabIndex = 6;
            this.txnama.TextChanged += new System.EventHandler(this.txnama_TextChanged);
            // 
            // nuharga
            // 
            this.nuharga.Location = new System.Drawing.Point(162, 436);
            this.nuharga.Name = "nuharga";
            this.nuharga.Size = new System.Drawing.Size(208, 22);
            this.nuharga.TabIndex = 8;
            this.nuharga.ValueChanged += new System.EventHandler(this.nuharga_ValueChanged);
            // 
            // nujumlah
            // 
            this.nujumlah.Location = new System.Drawing.Point(162, 479);
            this.nujumlah.Name = "nujumlah";
            this.nujumlah.Size = new System.Drawing.Size(208, 22);
            this.nujumlah.TabIndex = 9;
            // 
            // txnumber
            // 
            this.txnumber.Location = new System.Drawing.Point(747, 363);
            this.txnumber.Name = "txnumber";
            this.txnumber.Size = new System.Drawing.Size(208, 22);
            this.txnumber.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nomor Transaksi";
            // 
            // txkode
            // 
            this.txkode.Location = new System.Drawing.Point(747, 402);
            this.txkode.Name = "txkode";
            this.txkode.Size = new System.Drawing.Size(208, 22);
            this.txkode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kode Product";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(162, 398);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(208, 24);
            this.cbkategori.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(630, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Product Name";
            // 
            // btcari
            // 
            this.btcari.Location = new System.Drawing.Point(976, 398);
            this.btcari.Name = "btcari";
            this.btcari.Size = new System.Drawing.Size(75, 28);
            this.btcari.TabIndex = 22;
            this.btcari.Text = "Search";
            this.btcari.UseVisualStyleBackColor = true;
            this.btcari.Click += new System.EventHandler(this.btcari_Click);
            // 
            // txnama2
            // 
            this.txnama2.Location = new System.Drawing.Point(747, 439);
            this.txnama2.Name = "txnama2";
            this.txnama2.Size = new System.Drawing.Size(208, 22);
            this.txnama2.TabIndex = 23;
            // 
            // txharga
            // 
            this.txharga.Location = new System.Drawing.Point(747, 475);
            this.txharga.Name = "txharga";
            this.txharga.Size = new System.Drawing.Size(208, 22);
            this.txharga.TabIndex = 24;
            // 
            // txsubtotal
            // 
            this.txsubtotal.Location = new System.Drawing.Point(388, 436);
            this.txsubtotal.Name = "txsubtotal";
            this.txsubtotal.Size = new System.Drawing.Size(208, 22);
            this.txsubtotal.TabIndex = 25;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 630);
            this.Controls.Add(this.txsubtotal);
            this.Controls.Add(this.txharga);
            this.Controls.Add(this.txnama2);
            this.Controls.Add(this.btcari);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txkode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txnumber);
            this.Controls.Add(this.nujumlah);
            this.Controls.Add(this.nuharga);
            this.Controls.Add(this.txnama);
            this.Controls.Add(this.btco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgtransaksi);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuharga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nujumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btco;
        private System.Windows.Forms.TextBox txnama;
        private System.Windows.Forms.NumericUpDown nuharga;
        private System.Windows.Forms.NumericUpDown nujumlah;
        private System.Windows.Forms.TextBox txnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txkode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btcari;
        private System.Windows.Forms.TextBox txnama2;
        private System.Windows.Forms.TextBox txharga;
        private System.Windows.Forms.TextBox txsubtotal;
    }
}