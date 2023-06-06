using MasterTokoRoti.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTokoRoti
{
    public partial class FormPilihJumlahBahan : Form
    {
        public FormPilihJumlahBahan()
        {
            InitializeComponent();
        }

        public FormPilihJumlahBahan(MasterResep mr, Bahan ba)
        {
            InitializeComponent();

            parent = mr;
            bahan2 = ba;
        }

        MasterResep parent;
        Bahan bahan2;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jumlah = (int) numericUpDown1.Value;

            parent.addRow(bahan2, jumlah);

            this.Hide();
        }

        private void FormPilihJumlahBahan_Load(object sender, EventArgs e)
        {
            label4.Text = bahan2.MERK;
            label2.Text = bahan2.ID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
