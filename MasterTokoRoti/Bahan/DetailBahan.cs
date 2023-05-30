using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterTokoRoti.Models;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MasterTokoRoti
{
    public partial class DetailBahan : Form
    {
        public DetailBahan(ViewBahan v , Bahan b )
        {
            InitializeComponent();
            parent = v;
            bahan = b;
        }
        DataTable dataJenis = new DataTable();
        ViewBahan parent;
        Bahan bahan;

        SqlCommand cmd;
        string jenis;

        private void DetailBahan_Load(object sender, EventArgs e)
        {
            txtMerk.Text = bahan.MERK;
            txtSatuan.Text = bahan.SATUAN;
            txtKeterangan.Text = bahan.KETERANGAN;
            numHarga.Value = bahan.HARGA;
            numQTY.Value = bahan.QTY;
            label7.Text = bahan.JENIS_BAHAN_OBJ.NAMA_JENIS;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Apakah anda yakin mau menghapus data bahan?", "Konfirmasi", MessageBoxButtons.YesNo);
            //hasil dari tekan button di message box hasilnya berupa dialogresult
            if (conf == DialogResult.Yes)
            {
                try
                {
                    bahan.delete();
                    MessageBox.Show("Berhasil delete data bahan");
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string merk = txtMerk.Text;
            int qty = (int)numQTY.Value;
            int harga = (int)numHarga.Value;
            string satuan = txtSatuan.Text;
            string keterangan = txtKeterangan.Text;

            if (merk != "")
            {
                bahan.MERK = merk;
                bahan.QTY = qty;
                bahan.HARGA = harga;
                bahan.SATUAN = satuan;
                bahan.KETERANGAN = keterangan;
                bahan.JENIS_BAHAN_OBJ.NAMA_JENIS = label7.Text;

                try
                {
                    bahan.update();
                    MessageBox.Show("Berhasil update data bahan baru");
                    this.Close(); //untuk tutup form ini, otomatis dia akan memanggil function DetailSupplier_FormClosed
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Field tidak boleh kosong");
            }
        }

        private void DetailBahan_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ViewBahan_Load(null, null);
        }
    }
}
