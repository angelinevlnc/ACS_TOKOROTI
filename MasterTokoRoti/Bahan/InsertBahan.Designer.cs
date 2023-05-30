
namespace MasterTokoRoti
{
    partial class InsertBahan
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSatuan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbJenisBahan = new System.Windows.Forms.ComboBox();
            this.numQTY = new System.Windows.Forms.NumericUpDown();
            this.numHarga = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Keterangan :";
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(116, 286);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(226, 22);
            this.txtKeterangan.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Insert Bahan";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(110, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 34);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(196, 332);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(149, 34);
            this.btnInsert.TabIndex = 63;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(23, 332);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 34);
            this.buttonClear.TabIndex = 62;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Merk :";
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(119, 82);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(226, 22);
            this.txtMerk.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "QTY :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 71;
            this.label5.Text = "Harga :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 73;
            this.label6.Text = "Satuan ;";
            // 
            // txtSatuan
            // 
            this.txtSatuan.Location = new System.Drawing.Point(120, 207);
            this.txtSatuan.Name = "txtSatuan";
            this.txtSatuan.Size = new System.Drawing.Size(226, 22);
            this.txtSatuan.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 98;
            this.label10.Text = "Jenis Bahan :";
            // 
            // cbJenisBahan
            // 
            this.cbJenisBahan.FormattingEnabled = true;
            this.cbJenisBahan.Items.AddRange(new object[] {
            "KARYAWAN",
            "MANAGER",
            "CHEF"});
            this.cbJenisBahan.Location = new System.Drawing.Point(119, 246);
            this.cbJenisBahan.Name = "cbJenisBahan";
            this.cbJenisBahan.Size = new System.Drawing.Size(223, 24);
            this.cbJenisBahan.TabIndex = 97;
            // 
            // numQTY
            // 
            this.numQTY.Location = new System.Drawing.Point(119, 122);
            this.numQTY.Name = "numQTY";
            this.numQTY.Size = new System.Drawing.Size(223, 22);
            this.numQTY.TabIndex = 99;
            // 
            // numHarga
            // 
            this.numHarga.Location = new System.Drawing.Point(119, 167);
            this.numHarga.Name = "numHarga";
            this.numHarga.Size = new System.Drawing.Size(223, 22);
            this.numHarga.TabIndex = 100;
            // 
            // InsertBahan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 402);
            this.Controls.Add(this.numHarga);
            this.Controls.Add(this.numQTY);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbJenisBahan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSatuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMerk);
            this.Name = "InsertBahan";
            this.Text = "InsertBahan";
            this.Load += new System.EventHandler(this.InsertBahan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSatuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbJenisBahan;
        private System.Windows.Forms.NumericUpDown numQTY;
        private System.Windows.Forms.NumericUpDown numHarga;
    }
}