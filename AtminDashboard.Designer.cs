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
            this.txPrice = new System.Windows.Forms.TextBox();
            this.txStock = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategory)).BeginInit();
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
            this.dgitem.Location = new System.Drawing.Point(466, 230);
            this.dgitem.Name = "dgitem";
            this.dgitem.RowHeadersWidth = 51;
            this.dgitem.RowTemplate.Height = 24;
            this.dgitem.Size = new System.Drawing.Size(663, 320);
            this.dgitem.TabIndex = 1;
            // 
            // btsubmit
            // 
            this.btsubmit.Location = new System.Drawing.Point(27, 609);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(127, 41);
            this.btsubmit.TabIndex = 2;
            this.btsubmit.Text = "Confirm";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(160, 609);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(127, 41);
            this.btupdate.TabIndex = 3;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(293, 609);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(127, 41);
            this.btdelete.TabIndex = 4;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // dgcategory
            // 
            this.dgcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcategory.Location = new System.Drawing.Point(466, 87);
            this.dgcategory.Name = "dgcategory";
            this.dgcategory.RowHeadersWidth = 51;
            this.dgcategory.RowTemplate.Height = 24;
            this.dgcategory.Size = new System.Drawing.Size(663, 124);
            this.dgcategory.TabIndex = 5;
            // 
            // btcategory
            // 
            this.btcategory.Location = new System.Drawing.Point(62, 136);
            this.btcategory.Name = "btcategory";
            this.btcategory.Size = new System.Drawing.Size(105, 30);
            this.btcategory.TabIndex = 6;
            this.btcategory.Text = "Add Category";
            this.btcategory.UseVisualStyleBackColor = true;
            this.btcategory.Click += new System.EventHandler(this.btcategory_Click);
            // 
            // txcategory
            // 
            this.txcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcategory.Location = new System.Drawing.Point(188, 136);
            this.txcategory.Name = "txcategory";
            this.txcategory.Size = new System.Drawing.Size(126, 30);
            this.txcategory.TabIndex = 7;
            // 
            // txPname
            // 
            this.txPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPname.Location = new System.Drawing.Point(160, 327);
            this.txPname.Name = "txPname";
            this.txPname.Size = new System.Drawing.Size(189, 30);
            this.txPname.TabIndex = 8;
            // 
            // txPrice
            // 
            this.txPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPrice.Location = new System.Drawing.Point(160, 420);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(189, 30);
            this.txPrice.TabIndex = 9;
            // 
            // txStock
            // 
            this.txStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txStock.Location = new System.Drawing.Point(160, 456);
            this.txStock.Name = "txStock";
            this.txStock.Size = new System.Drawing.Size(189, 30);
            this.txStock.TabIndex = 10;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(188, 390);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // AtminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 708);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txStock);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.txPname);
            this.Controls.Add(this.txcategory);
            this.Controls.Add(this.btcategory);
            this.Controls.Add(this.dgcategory);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.dgitem);
            this.Controls.Add(this.panel1);
            this.Name = "AtminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtminDashboard";
            this.Load += new System.EventHandler(this.AtminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategory)).EndInit();
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
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.TextBox txStock;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}