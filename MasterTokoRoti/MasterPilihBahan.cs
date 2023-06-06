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
    public partial class MasterPilihBahan : Form
    {
        public MasterPilihBahan()
        {
            InitializeComponent();
        }

        public MasterPilihBahan(MasterResep resep)
        {
            InitializeComponent();

            r = resep;
        }

        MasterResep r;

        DataTable db = new DataTable();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            Bahan b = new Bahan();

            if (index > -1)
            {
                b.ID = dataGridView1.Rows[index].Cells["ID"].Value.ToString();
                b.MERK = dataGridView1.Rows[index].Cells["MERK"].Value.ToString();
                b.QTY = Int32.Parse(dataGridView1.Rows[index].Cells["QTY_STOK"].Value.ToString());
            }

            FormPilihJumlahBahan fp = new FormPilihJumlahBahan(r, b);
            fp.Show();

            //r.addRow(b, jumlah);

            this.Hide();
        }

        private void MasterPilihBahan_Load(object sender, EventArgs e)
        {
            String q = "select ID, MERK, QTY_STOK, HARGA, SATUAN " +
                "from bahan where status=1";

            db = DB.get(q);

            dataGridView1.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dataGridView1.DataSource = db;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
