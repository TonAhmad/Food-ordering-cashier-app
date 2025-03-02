namespace MyMakan
{
    partial class AtminDashboard
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
            this.dgitem = new System.Windows.Forms.DataGridView();
            this.btsubmit = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.dgcategory = new System.Windows.Forms.DataGridView();
            this.btcategory = new System.Windows.Forms.Button();
            this.txcategory = new System.Windows.Forms.TextBox();
            this.txPname = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nuprice = new System.Windows.Forms.NumericUpDown();
            this.nustock = new System.Windows.Forms.NumericUpDown();
            this.txProdID = new System.Windows.Forms.TextBox();
            this.btupcat = new System.Windows.Forms.Button();
            this.btdelcat = new System.Windows.Forms.Button();
            this.txcatid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nustock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 52);
            this.panel1.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 15);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(142, 24);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Admin Name";
            // 
            // dgitem
            // 
            this.dgitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgitem.Location = new System.Drawing.Point(121, 58);
            this.dgitem.Name = "dgitem";
            this.dgitem.RowHeadersWidth = 51;
            this.dgitem.RowTemplate.Height = 24;
            this.dgitem.Size = new System.Drawing.Size(872, 320);
            this.dgitem.TabIndex = 1;
            this.dgitem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgitem_CellContentClick);
            // 
            // btsubmit
            // 
            this.btsubmit.Location = new System.Drawing.Point(27, 646);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(127, 41);
            this.btsubmit.TabIndex = 2;
            this.btsubmit.Text = "Confirm";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(160, 646);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(127, 41);
            this.btupdate.TabIndex = 3;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(293, 646);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(127, 41);
            this.btdelete.TabIndex = 4;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // dgcategory
            // 
            this.dgcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcategory.Location = new System.Drawing.Point(498, 402);
            this.dgcategory.Name = "dgcategory";
            this.dgcategory.RowHeadersWidth = 51;
            this.dgcategory.RowTemplate.Height = 24;
            this.dgcategory.Size = new System.Drawing.Size(495, 188);
            this.dgcategory.TabIndex = 5;
            this.dgcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcategory_CellContentClick);
            // 
            // btcategory
            // 
            this.btcategory.Location = new System.Drawing.Point(584, 646);
            this.btcategory.Name = "btcategory";
            this.btcategory.Size = new System.Drawing.Size(127, 41);
            this.btcategory.TabIndex = 6;
            this.btcategory.Text = "Add Category";
            this.btcategory.UseVisualStyleBackColor = true;
            this.btcategory.Click += new System.EventHandler(this.btcategory_Click);
            // 
            // txcategory
            // 
            this.txcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcategory.Location = new System.Drawing.Point(584, 610);
            this.txcategory.Name = "txcategory";
            this.txcategory.Size = new System.Drawing.Size(182, 30);
            this.txcategory.TabIndex = 7;
            // 
            // txPname
            // 
            this.txPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPname.Location = new System.Drawing.Point(189, 402);
            this.txPname.Name = "txPname";
            this.txPname.Size = new System.Drawing.Size(189, 30);
            this.txPname.TabIndex = 8;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(189, 448);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(189, 33);
            this.comboBoxCategory.TabIndex = 12;
            this.comboBoxCategory.Text = "Select";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Category";
            // 
            // nuprice
            // 
            this.nuprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuprice.Location = new System.Drawing.Point(189, 496);
            this.nuprice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nuprice.Name = "nuprice";
            this.nuprice.Size = new System.Drawing.Size(189, 30);
            this.nuprice.TabIndex = 18;
            // 
            // nustock
            // 
            this.nustock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nustock.Location = new System.Drawing.Point(189, 555);
            this.nustock.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nustock.Name = "nustock";
            this.nustock.Size = new System.Drawing.Size(189, 30);
            this.nustock.TabIndex = 19;
            // 
            // txProdID
            // 
            this.txProdID.Enabled = false;
            this.txProdID.Location = new System.Drawing.Point(353, 184);
            this.txProdID.Name = "txProdID";
            this.txProdID.Size = new System.Drawing.Size(100, 22);
            this.txProdID.TabIndex = 20;
            this.txProdID.Visible = false;
            // 
            // btupcat
            // 
            this.btupcat.Location = new System.Drawing.Point(717, 646);
            this.btupcat.Name = "btupcat";
            this.btupcat.Size = new System.Drawing.Size(127, 41);
            this.btupcat.TabIndex = 21;
            this.btupcat.Text = "Update";
            this.btupcat.UseVisualStyleBackColor = true;
            this.btupcat.Click += new System.EventHandler(this.btupcat_Click);
            // 
            // btdelcat
            // 
            this.btdelcat.Location = new System.Drawing.Point(850, 646);
            this.btdelcat.Name = "btdelcat";
            this.btdelcat.Size = new System.Drawing.Size(127, 41);
            this.btdelcat.TabIndex = 22;
            this.btdelcat.Text = "Delete";
            this.btdelcat.UseVisualStyleBackColor = true;
            this.btdelcat.Click += new System.EventHandler(this.btdelcat_Click);
            // 
            // txcatid
            // 
            this.txcatid.Enabled = false;
            this.txcatid.Location = new System.Drawing.Point(893, 406);
            this.txcatid.Name = "txcatid";
            this.txcatid.Size = new System.Drawing.Size(100, 22);
            this.txcatid.TabIndex = 23;
            this.txcatid.Visible = false;
            // 
            // AtminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 708);
            this.Controls.Add(this.btdelcat);
            this.Controls.Add(this.btupcat);
            this.Controls.Add(this.nustock);
            this.Controls.Add(this.nuprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txPname);
            this.Controls.Add(this.txcategory);
            this.Controls.Add(this.btcategory);
            this.Controls.Add(this.dgcategory);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.dgitem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txProdID);
            this.Controls.Add(this.txcatid);
            this.Name = "AtminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtminDashboard";
            this.Load += new System.EventHandler(this.AtminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nustock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DataGridView dgitem;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridView dgcategory;
        private System.Windows.Forms.Button btcategory;
        private System.Windows.Forms.TextBox txcategory;
        private System.Windows.Forms.TextBox txPname;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuprice;
        private System.Windows.Forms.NumericUpDown nustock;
        private System.Windows.Forms.TextBox txProdID;
        private System.Windows.Forms.Button btupcat;
        private System.Windows.Forms.Button btdelcat;
        private System.Windows.Forms.TextBox txcatid;
    }
}