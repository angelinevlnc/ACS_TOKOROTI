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
    
    public partial class InsertKategoriRoti : Form
    {
        ViewKategoriRoti parent;
        public InsertKategoriRoti(ViewKategoriRoti p)
        {
            InitializeComponent();
            parent = p;
        }

        private void InsertKategoriRoti_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string keterangan = txtKeterangan.Text;

            JenisRoti jr = new JenisRoti();
            jr.NAMA_JENIS = nama.ToUpper();
            jr.KETERANGAN = keterangan;

            if (nama == "")
            {
                MessageBox.Show("Field tidak boleh kosong");
            }
            else
            {
                try
                {
                    jr.insert();
                    MessageBox.Show("Berhasil insert data baru");
                    parent.ViewKategoriRoti_Load(sender, e);
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
            txtKeterangan.Text = "";
        }
    }
}
