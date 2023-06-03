
namespace MasterTokoRoti
{
    partial class Form1
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
            this.btnKategoriBahan = new System.Windows.Forms.Button();
            this.btnBahan = new System.Windows.Forms.Button();
            this.btnKategoriRoti = new System.Windows.Forms.Button();
            this.btnRoti = new System.Windows.Forms.Button();
            this.btnPegawai = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategoriBahan
            // 
            this.btnKategoriBahan.Location = new System.Drawing.Point(15, 35);
            this.btnKategoriBahan.Name = "btnKategoriBahan";
            this.btnKategoriBahan.Size = new System.Drawing.Size(136, 36);
            this.btnKategoriBahan.TabIndex = 0;
            this.btnKategoriBahan.Text = "Kategori Bahan";
            this.btnKategoriBahan.UseVisualStyleBackColor = true;
            this.btnKategoriBahan.Click += new System.EventHandler(this.btnKategoriBahan_Click);
            // 
            // btnBahan
            // 
            this.btnBahan.Location = new System.Drawing.Point(169, 35);
            this.btnBahan.Name = "btnBahan";
            this.btnBahan.Size = new System.Drawing.Size(108, 36);
            this.btnBahan.TabIndex = 1;
            this.btnBahan.Text = "Bahan";
            this.btnBahan.UseVisualStyleBackColor = true;
            this.btnBahan.Click += new System.EventHandler(this.btnBahan_Click);
            // 
            // btnKategoriRoti
            // 
            this.btnKategoriRoti.Location = new System.Drawing.Point(15, 39);
            this.btnKategoriRoti.Name = "btnKategoriRoti";
            this.btnKategoriRoti.Size = new System.Drawing.Size(136, 36);
            this.btnKategoriRoti.TabIndex = 2;
            this.btnKategoriRoti.Text = "Kategori Roti";
            this.btnKategoriRoti.UseVisualStyleBackColor = true;
            this.btnKategoriRoti.Click += new System.EventHandler(this.btnKategoriRoti_Click);
            // 
            // btnRoti
            // 
            this.btnRoti.Location = new System.Drawing.Point(169, 39);
            this.btnRoti.Name = "btnRoti";
            this.btnRoti.Size = new System.Drawing.Size(108, 36);
            this.btnRoti.TabIndex = 3;
            this.btnRoti.Text = "Roti";
            this.btnRoti.UseVisualStyleBackColor = true;
            this.btnRoti.Click += new System.EventHandler(this.btnRoti_Click);
            // 
            // btnPegawai
            // 
            this.btnPegawai.Location = new System.Drawing.Point(23, 294);
            this.btnPegawai.Name = "btnPegawai";
            this.btnPegawai.Size = new System.Drawing.Size(136, 36);
            this.btnPegawai.TabIndex = 4;
            this.btnPegawai.Text = "Pegawai";
            this.btnPegawai.UseVisualStyleBackColor = true;
            this.btnPegawai.Click += new System.EventHandler(this.btnPegawai_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(192, 294);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(136, 36);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Master Program";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKategoriBahan);
            this.groupBox1.Controls.Add(this.btnBahan);
            this.groupBox1.Location = new System.Drawing.Point(23, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master Bahan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKategoriRoti);
            this.groupBox2.Controls.Add(this.btnRoti);
            this.groupBox2.Location = new System.Drawing.Point(23, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Master Roti";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Master Resep";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnPegawai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKategoriBahan;
        private System.Windows.Forms.Button btnBahan;
        private System.Windows.Forms.Button btnKategoriRoti;
        private System.Windows.Forms.Button btnRoti;
        private System.Windows.Forms.Button btnPegawai;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

