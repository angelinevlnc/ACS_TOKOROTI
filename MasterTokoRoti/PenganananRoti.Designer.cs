
namespace MasterTokoRoti
{
    partial class PenganananRoti
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
            this.button1 = new System.Windows.Forms.Button();
            this.numJumlahRoti = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lblResep = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.Desk = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlasanRoti = new System.Windows.Forms.TextBox();
            this.dgvKategori = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahRoti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 83;
            this.button1.Text = "Tambahkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numJumlahRoti
            // 
            this.numJumlahRoti.Location = new System.Drawing.Point(451, 492);
            this.numJumlahRoti.Name = "numJumlahRoti";
            this.numJumlahRoti.Size = new System.Drawing.Size(120, 22);
            this.numJumlahRoti.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "Masukkan Jumlah Roti :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblJenis);
            this.groupBox1.Controls.Add(this.lb2);
            this.groupBox1.Controls.Add(this.lblResep);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblHarga);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblStok);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDeskripsi);
            this.groupBox1.Controls.Add(this.Desk);
            this.groupBox1.Controls.Add(this.lblNama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(36, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 191);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bahan Ditemukan";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(345, 69);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(0, 17);
            this.lblJenis.TabIndex = 13;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(270, 69);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(57, 17);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "Jenis  : ";
            // 
            // lblResep
            // 
            this.lblResep.AutoSize = true;
            this.lblResep.Location = new System.Drawing.Point(370, 34);
            this.lblResep.Name = "lblResep";
            this.lblResep.Size = new System.Drawing.Size(0, 17);
            this.lblResep.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kode Resep :";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(93, 142);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(0, 17);
            this.lblHarga.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Harga  : ";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(77, 106);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(0, 17);
            this.lblStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok  : ";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(349, 142);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(0, 17);
            this.lblDeskripsi.TabIndex = 5;
            // 
            // Desk
            // 
            this.Desk.AutoSize = true;
            this.Desk.Location = new System.Drawing.Point(269, 142);
            this.Desk.Name = "Desk";
            this.Desk.Size = new System.Drawing.Size(74, 17);
            this.Desk.TabIndex = 4;
            this.Desk.Text = "Deskripsi :";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(76, 69);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(0, 17);
            this.lblNama.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nama :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 31);
            this.button2.TabIndex = 80;
            this.button2.Text = "Cari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "Pengananan Roti";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Alasan :";
            // 
            // txtAlasanRoti
            // 
            this.txtAlasanRoti.Location = new System.Drawing.Point(451, 527);
            this.txtAlasanRoti.Name = "txtAlasanRoti";
            this.txtAlasanRoti.Size = new System.Drawing.Size(120, 22);
            this.txtAlasanRoti.TabIndex = 85;
            // 
            // dgvKategori
            // 
            this.dgvKategori.AllowUserToAddRows = false;
            this.dgvKategori.AllowUserToDeleteRows = false;
            this.dgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategori.Location = new System.Drawing.Point(36, 85);
            this.dgvKategori.Name = "dgvKategori";
            this.dgvKategori.ReadOnly = true;
            this.dgvKategori.RowHeadersWidth = 51;
            this.dgvKategori.RowTemplate.Height = 24;
            this.dgvKategori.Size = new System.Drawing.Size(535, 169);
            this.dgvKategori.TabIndex = 86;
            this.dgvKategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategori_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(289, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 87;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(77, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "ID :";
            // 
            // PenganananRoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 613);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvKategori);
            this.Controls.Add(this.txtAlasanRoti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numJumlahRoti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "PenganananRoti";
            this.Text = "PenganananRoti";
            this.Load += new System.EventHandler(this.PenganananRoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numJumlahRoti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numJumlahRoti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lblResep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label Desk;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAlasanRoti;
        private System.Windows.Forms.DataGridView dgvKategori;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label10;
    }
}