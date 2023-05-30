using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MasterTokoRoti.Models;

namespace MasterTokoRoti
{
    public partial class InsertBahan : Form
    {
        ViewBahan parent;
        DataTable dataJenis = new DataTable();

        public InsertBahan(ViewBahan p)
        {
            InitializeComponent();
            parent = p;
        }
        SqlConnection conn = new SqlConnection("Data Source=Server_Name;Initial Catalog=db_tokoroti;integrated security=true");
        SqlCommand cmd;
        SqlDataReader dr;


        private void InsertBahan_Load(object sender, EventArgs e)
        {
            dataJenis = DB.get("SELECT * FROM jenis_bahan where status=1");
            List<String> j = new List<string>();
            for (int i = 0; i < dataJenis.Rows.Count; i++)
            {
                DataRow dr = dataJenis.Rows[i];
                j.Add(dr.Field<string>("nama_jenis"));
            }
            cbJenisBahan.DataSource = j;
        }

        string jenis;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string merk = txtMerk.Text;
            int qty = (int)numQTY.Value;
            int harga = (int)numHarga.Value;
            string satuan = txtSatuan.Text;
            string keterangan = txtKeterangan.Text;
            int jenis_bahan = 0;

            jenis = cbJenisBahan.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandText = "select id from jenis_bahan where nama_jenis=@name";
            cmd.Parameters.AddWithValue("name", jenis);
            DB.openConnection();
            jenis_bahan = Int32.Parse( cmd.ExecuteScalar().ToString());
            DB.closeConnection();

            Bahan b = new Bahan();
            b.MERK = merk.ToUpper();
            b.QTY = qty;
            b.HARGA = harga;
            b.KETERANGAN = keterangan;
            b.SATUAN = satuan;
            b.JENIS_BAHAN = jenis_bahan;

            if (merk == "")
            {
                MessageBox.Show("Field tidak boleh kosong");
            }
            else
            {
                try
                {
                    b.insert();
                    MessageBox.Show("Berhasil insert data baru");
                    parent.ViewBahan_Load(sender, e);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }
    }
}
