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
    public partial class DetailPegawai : Form
    {
        public DetailPegawai(ViewPegawai v, Pegawai p)
        {
            InitializeComponent();
            parent = v;
            pegawai = p;
        }
        ViewPegawai parent;
        Pegawai pegawai;

        private void DetailPegawai_Load(object sender, EventArgs e)
        {
            txtNama.Text = pegawai.NAMA;
            txtUsername.Text = pegawai.USERNAME;
            txtPassword.Text = pegawai.PASSWORD;
            txtAlamat.Text = pegawai.ALAMAT;
            txtEmail.Text = pegawai.EMAIL;
            txtNotelp.Text = pegawai.NOTELP;
            txtKeterangan.Text = pegawai.KETERANGAN;

            if (pegawai.JENISKELAMIN == 'L')
            {
                rdbLaki.Checked = true;
                rdbPerempuan.Checked = false;
                rdbLaki.Enabled = true;
            }
            if (pegawai.JENISKELAMIN == 'P')
            {
                rdbPerempuan.Checked = true;
                rdbPerempuan.Enabled = true;
            }

            if (pegawai.FK_JABATAN==1)
            {
                comboBox1.Text = comboBox1.Items[0].ToString();
            }
            if (pegawai.FK_JABATAN == 2)
            {
                comboBox1.Text = comboBox1.Items[1].ToString();

            }
            if (pegawai.FK_JABATAN == 3)
            {
                comboBox1.Text = comboBox1.Items[2].ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string alamat = txtAlamat.Text;
            string email = txtEmail.Text;
            string notelp = txtNotelp.Text;
            string keterangan = txtKeterangan.Text;
            string tanggallahir = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string jabatan = comboBox1.Text;

            int fk_jabatan = 0;
            if (jabatan == "KARYAWAN")
            {
                fk_jabatan = 1;
            }
            if (jabatan == "MANAGER")
            {
                fk_jabatan = 2;
            }
            if (jabatan == "CHEF")
            {
                fk_jabatan = 3;
            }


            char jeniskelamin = 'L';
            if (rdbPerempuan.Checked)
            {
                jeniskelamin = 'P';
            }
            else if (rdbLaki.Checked)
            {
                jeniskelamin = 'L';
            }

            if (nama != "")
            {
                pegawai.NAMA = nama;
                pegawai.USERNAME = username;
                pegawai.PASSWORD = password;
                pegawai.JENISKELAMIN = jeniskelamin;
                pegawai.ALAMAT = alamat;
                pegawai.EMAIL = email;
                pegawai.NOTELP = notelp;
                pegawai.KETERANGAN = keterangan;
                pegawai.TANGGALLAHIR = tanggallahir;
                pegawai.FK_JABATAN = fk_jabatan;

                try
                {
                    pegawai.update();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Apakah anda yakin mau menghapus data supplier?", "Konfirmasi", MessageBoxButtons.YesNo);
            //hasil dari tekan button di message box hasilnya berupa dialogresult
            if (conf == DialogResult.Yes)
            {
                try
                {
                    pegawai.delete();
                    MessageBox.Show("Berhasil delete data supplier");
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void DetailPegawai_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.ViewPegawai_Load(null, null);
        }
    }
}
