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
    public partial class DetailKategoriRoti : Form
    {
        public DetailKategoriRoti(ViewKategoriRoti v , JenisRoti jr)
        {
            parent = v;
            jenisroti = jr;
            InitializeComponent();
        }
        ViewKategoriRoti parent;
        JenisRoti jenisroti;

        private void DetailKategoriRoti_Load(object sender, EventArgs e)
        {
            txtNama.Text = jenisroti.NAMA_JENIS;
            txtKeterangan.Text = jenisroti.KETERANGAN;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Apakah anda yakin mau menghapus data jenis roti?", "Konfirmasi", MessageBoxButtons.YesNo);
            //hasil dari tekan button di message box hasilnya berupa dialogresult
            if (conf == DialogResult.Yes)
            {
                try
                {
                    jenisroti.delete();
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
            string nama = txtNama.Text;
            string keterangan = txtKeterangan.Text;

            if (nama != "")
            {
                jenisroti.NAMA_JENIS = nama.ToUpper();
                jenisroti.KETERANGAN = keterangan;

                try
                {
                    jenisroti.update();
                    MessageBox.Show("Berhasil update data jenis roti baru");
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

        private void DetailKategoriRoti_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ViewKategoriRoti_Load(null, null);
        }
    }
}
