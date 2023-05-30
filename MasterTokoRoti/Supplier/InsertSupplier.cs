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
    public partial class InsertSupplier : Form
    {
        ViewSupplier parent;
        public InsertSupplier(ViewSupplier p)
        {
            InitializeComponent();
            parent = p;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string alamat = txtAlamat.Text;
            string email = txtEmail.Text;
            string notelp = txtNotelp.Text;
            string keterangan = txtKeterangan.Text;

            Supplier s = new Supplier();
            s.NAMA = nama;
            s.ALAMAT = alamat;
            s.EMAIL = email;
            s.NOTELP = notelp;
            s.KETERANGAN = keterangan;

            if (nama == "" || alamat=="" || notelp=="")
            {
                MessageBox.Show("Field tidak boleh kosong");
            }
            else
            {
                try
                {
                    s.insert();
                    MessageBox.Show("Berhasil insert data baru");
                    parent.ViewSupplier_Load(sender, e);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtEmail.Text = "";
            txtNotelp.Text = "";
            txtAlamat.Text = "";
            txtKeterangan.Text = "";
        }

        private void InsertSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
