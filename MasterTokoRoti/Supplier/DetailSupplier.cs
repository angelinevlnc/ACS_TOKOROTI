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
    public partial class DetailSupplier : Form
    {
        public DetailSupplier(ViewSupplier v, Supplier s)
        {
            InitializeComponent();
            parent = v;
            supplier = s;
        }
        ViewSupplier parent;
        Supplier supplier;

        private void DetailSupplier_Load(object sender, EventArgs e)
        {
            txtNama.Text = supplier.NAMA;
            txtAlamat.Text = supplier.ALAMAT;
            txtEmail.Text = supplier.EMAIL;
            txtNotelp.Text = supplier.NOTELP;
            txtKeterangan.Text = supplier.KETERANGAN;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Apakah anda yakin mau menghapus data supplier?", "Konfirmasi", MessageBoxButtons.YesNo);
            //hasil dari tekan button di message box hasilnya berupa dialogresult
            if (conf == DialogResult.Yes)
            {
                try
                {
                    supplier.delete();
                    MessageBox.Show("Berhasil delete data supplier");
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
            string alamat = txtAlamat.Text;
            string email = txtEmail.Text;
            string notelp = txtNotelp.Text;
            string keterangan = txtKeterangan.Text;

            if (nama != "")
            {
                supplier.NAMA = nama;
                supplier.ALAMAT = alamat;
                supplier.EMAIL = email;
                supplier.NOTELP = notelp;
                supplier.KETERANGAN = keterangan;

                try
                {
                    supplier.update();
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

        private void DetailSupplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ViewSupplier_Load(null, null);
        }
    }
}
