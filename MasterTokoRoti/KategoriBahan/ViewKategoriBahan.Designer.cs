
namespace MasterTokoRoti
{
    partial class ViewKategoriBahan
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvKategori = new System.Windows.Forms.DataGridView();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(22, 71);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 33);
            this.btnTambah.TabIndex = 14;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(638, 71);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 31);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(424, 75);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // dgvKategori
            // 
            this.dgvKategori.AllowUserToAddRows = false;
            this.dgvKategori.AllowUserToDeleteRows = false;
            this.dgvKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail});
            this.dgvKategori.Location = new System.Drawing.Point(22, 123);
            this.dgvKategori.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKategori.Name = "dgvKategori";
            this.dgvKategori.ReadOnly = true;
            this.dgvKategori.RowHeadersWidth = 51;
            this.dgvKategori.Size = new System.Drawing.Size(716, 391);
            this.dgvKategori.TabIndex = 11;
            this.dgvKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategori_CellClick);
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detail";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Master Kategori Bahan";
            // 
            // ViewKategoriBahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvKategori);
            this.Name = "ViewKategoriBahan";
            this.Text = "ViewKategoriBahan";
            this.Load += new System.EventHandler(this.ViewKategoriBahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvKategori;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Label label1;
    }
}