using MasterTokoRoti.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterTokoRoti
{
    public partial class MasterResep : Form
    {
        public MasterResep()
        {
            InitializeComponent();
        }

        DataTable hReseps = new DataTable();

        private void MasterResep_Load(object sender, EventArgs e)
        {
            //Load dropdown jenis roti
            String q3 = "SELECT nama as Name from h_resep";
            hReseps = DB.get(q3);

            comboBox1.DataSource = null;
            comboBox1.DataSource = hReseps;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        public void addRow(Bahan b, int jumlah)
        {
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "MERK";
            dataGridView1.Columns[2].Name = "JUMLAH";

            dataGridView1.Rows.Add(b.ID, b.MERK, jumlah);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pilih bahan
            MasterPilihBahan mpb = new MasterPilihBahan(this);
            mpb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tambah ke d_resep

            int selectedObj = comboBox1.SelectedIndex;

            String name = hReseps.Rows[selectedObj]["Name"].ToString();

            String q3 = $"SELECT TOP 1 ID from H_RESEP where nama='{name}'";

            int idHResep = Int32.Parse(DB.getScalar(q3));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int id = generateDResepId();

                int idBahan = int.Parse((string)row.Cells["ID"].Value);

                Object jumlah = row.Cells["JUMLAH"].Value;

                DB.openConnection(); //open dulu connectionnya
                SqlTransaction transaction8 = DB.conn.BeginTransaction();

                try
                {
                    DB.openConnection(); //open dulu connectionnya
                    transaction8 = DB.conn.BeginTransaction();

                    String cmdStringHeader = $"INSERT INTO D_RESEP (ID, FK_ID_H_RESEP, ID_BAHAN, QTY) VALUES({id},{idHResep}, {idBahan}, {jumlah})";

                    SqlCommand cmdHeader = new SqlCommand(cmdStringHeader, DB.conn, transaction8);

                    cmdHeader.ExecuteNonQuery();

                    transaction8.Commit();
                }
                catch (Exception ex)
                {
                    transaction8.Rollback(); //dirollback kalau error
                    MessageBox.Show(ex.Message.ToString(), "Gagal insert data h resep");
                }

                MessageBox.Show("D Resep berhasil tersimpan");

                //File.AppendAllText(csvLocation, row.Cells[0].Value + "," + row.Cells[1].Value + "," + row.Cells[2].Value + "," + row.Cells[3].Value + Environment.NewLine);
            }


        }

        private int generateDResepId()
        {
            String q = "select count(*)+1 from d_resep";

            int tmp = Int32.Parse(DB.getScalar(q));

            return tmp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
