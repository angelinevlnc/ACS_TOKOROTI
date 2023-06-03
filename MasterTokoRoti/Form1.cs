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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnKategoriBahan_Click(object sender, EventArgs e)
        {
             ViewKategoriBahan vkb = new ViewKategoriBahan();
            vkb.ShowDialog();
        }

        private void btnBahan_Click(object sender, EventArgs e)
        {
            ViewBahan vb = new ViewBahan();
            vb.ShowDialog();
        }

        private void btnKategoriRoti_Click(object sender, EventArgs e)
        {
            ViewKategoriRoti vkb = new ViewKategoriRoti();
            vkb.ShowDialog();
        }

        private void btnRoti_Click(object sender, EventArgs e)
        {
            ViewRoti vr = new ViewRoti();
            vr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB(); //ini kita init dulu class DB nya
                DB.openConnection();
                DB.closeConnection();
                MessageBox.Show("Connection success"); //ini gunanya untuk mencoba buka connection apa bisa / tidak, kalau tidak bisa brti ada salah di konfigurasi
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            ViewPegawai vp = new ViewPegawai();
            vp.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            ViewSupplier vs = new ViewSupplier();
            vs.ShowDialog();
        }

        private void btnpRoti_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterResep mr = new MasterResep();
            mr.ShowDialog();
        }
    }
}
