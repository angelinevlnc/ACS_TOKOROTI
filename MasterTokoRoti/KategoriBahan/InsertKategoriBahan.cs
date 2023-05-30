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
    public partial class InsertKategoriBahan : Form
    {
        ViewKategoriBahan parent;
        public InsertKategoriBahan(ViewKategoriBahan p)
        {
            InitializeComponent();
            parent = p;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string keterangan = txtKeterangan.Text;

            JenisBahan jb = new JenisBahan();
            jb.NAMA_JENIS = nama.ToUpper();
            jb.KETERANGAN = keterangan;

            if (nama == "")
            {
                MessageBox.Show("Field tidak boleh kosong");
            }
            else
            {
                try
                {
                    jb.insert();
                    MessageBox.Show("Berhasil insert data baru");
                    parent.ViewKategoriBahan_Load(sender, e);
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void InsertKategoriBahan_Load(object sender, EventArgs e)
        {

        }
    }
}
