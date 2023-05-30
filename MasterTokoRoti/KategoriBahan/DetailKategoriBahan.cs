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

namespace MasterTokoRoti
{
    public partial class DetailKategoriBahan : Form
    {
        
        public DetailKategoriBahan(ViewKategoriBahan v , JenisBahan jb)
        {
            parent = v;
            jenisbahan = jb;
            InitializeComponent();
        }
        ViewKategoriBahan parent;
        JenisBahan jenisbahan;

        private void DetailKategoriBahan_Load(object sender, EventArgs e)
        {
            txtNama.Text = jenisbahan.NAMA_JENIS;
            txtKeterangan.Text = jenisbahan.KETERANGAN;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Apakah anda yakin mau menghapus data jenis bahan?", "Konfirmasi", MessageBoxButtons.YesNo);
            //hasil dari tekan button di message box hasilnya berupa dialogresult
            if (conf == DialogResult.Yes)
            {
                try
                {
                    jenisbahan.delete();
                    MessageBox.Show("Berhasil delete data bahan");
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void DetailKategoriBahan_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ViewKategoriBahan_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string keterangan = txtKeterangan.Text;


            if (nama != "")
            {
                jenisbahan.NAMA_JENIS = nama.ToUpper();
                jenisbahan.KETERANGAN = keterangan;

                try
                {
                    jenisbahan.update();
                    MessageBox.Show("Berhasil update data jenis bahan baru");
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
    }
}
