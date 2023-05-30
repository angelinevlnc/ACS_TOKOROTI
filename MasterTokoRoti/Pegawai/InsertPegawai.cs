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
    public partial class InsertPegawai : Form
    {
        ViewPegawai parent;
        public InsertPegawai(ViewPegawai p)
        {
            InitializeComponent();
            parent = p;
        }

        private void InsertPegawai_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
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
            if (jabatan=="KARYAWAN")
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

            Pegawai p = new Pegawai();
            p.NAMA = nama;
            p.USERNAME = username;
            p.PASSWORD = password;
            p.ALAMAT = alamat;
            p.EMAIL = email;
            p.NOTELP = notelp;
            p.KETERANGAN = keterangan;
            p.JENISKELAMIN = jeniskelamin;
            p.TANGGALLAHIR = tanggallahir;
            p.FK_JABATAN = fk_jabatan;

            if (nama == "" || alamat == "" || notelp == "")
            {
                MessageBox.Show("Field tidak boleh kosong");
            }
            else
            {
                try
                {
                   p.insert();
                    MessageBox.Show("Berhasil insert data baru");
                    parent.ViewPegawai_Load(sender, e);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtNotelp.Text = "";
            txtAlamat.Text = "";
            txtKeterangan.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
