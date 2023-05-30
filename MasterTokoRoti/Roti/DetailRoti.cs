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
    public partial class DetailRoti : Form
    {
        public DetailRoti(ViewRoti p , Roti r)
        {
            InitializeComponent();
            parent = p;
            roti = r;
        }
        ViewRoti parent;
        Roti roti;

        SqlCommand cmd;
        string jenis;

        private void DetailRoti_Load(object sender, EventArgs e)
        {
            txtNama.Text = roti.NAMA;
            txtDeskripsi.Text = roti.DESKRIPSI;
            txtKeterangan.Text = roti.KETERANGAN;
            numHarga.Value = roti.HARGA;
            numStok.Value = roti.STOK;
            label7.Text = roti.JENIS_ROTI_OBJ.NAMA_JENIS;
            label2.Text = roti.FK_RESEP.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string deskripsi = txtDeskripsi.Text;
            int stok = (int)numStok.Value;
            int harga = (int)numHarga.Value;
            string keterangan = txtKeterangan.Text;

            if (nama != "")
            {
                roti.NAMA = nama;
                roti.DESKRIPSI = deskripsi;
                roti.STOK = stok;
                roti.HARGA = harga;
                roti.KETERANGAN = keterangan;
                roti.JENIS_ROTI_OBJ.NAMA_JENIS = label7.Text;
                roti.FK_RESEP = int.Parse(label2.Text);

                try
                {
                    roti.update();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Apakah anda yakin mau menghapus data bahan?", "Konfirmasi", MessageBoxButtons.YesNo);
            //hasil dari tekan button di message box hasilnya berupa dialogresult
            if (conf == DialogResult.Yes)
            {
                try
                {
                    roti.delete();
                    MessageBox.Show("Berhasil delete data roti");
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void DetailRoti_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ViewRoti_Load(null, null);

        }
    }
}
