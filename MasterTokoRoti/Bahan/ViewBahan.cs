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
using System.Data.Sql;
using System.Data.SqlClient;

namespace MasterTokoRoti
{
    public partial class ViewBahan : Form
    {
        public ViewBahan()
        {
            InitializeComponent();
        }


        public void ViewBahan_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT b.ID,b.MERK,jb.NAMA_JENIS,b.QTY_STOK,b.HARGA,b.SATUAN,b.keterangan from bahan b, JENIS_BAHAN jb where b.status = 1 and b.FK_JENIS_BAHAN = jb.ID order by b.id desc", DB.conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtkategoriRoti = new DataTable();
            adapter.Fill(dtkategoriRoti);

            dgvKategori.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dgvKategori.DataSource = dtkategoriRoti; //baru diset dengan datatable yang tadi

            dgvKategori.Columns["id"].Visible = false;
            //dgvKategori.Columns["b.status"].Visible = false;
            dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT b.ID,b.MERK,jb.NAMA_JENIS,b.QTY_STOK,b.HARGA,b.SATUAN,b.keterangan from bahan b, JENIS_BAHAN jb where b.merk like '%' + @Search + '%' and b.status = 1 and b.JENIS_BAHAN = jb.ID order by b.id desc", DB.conn);
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                cmd.ExecuteNonQuery();


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKategori.DataSource = null;
                dgvKategori.DataSource = dt;

                dgvKategori.Columns["id"].Visible = false;
                dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;

            }
            catch (Exception ex)
            {
                DB.closeConnection();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InsertBahan i = new InsertBahan(this);
            i.ShowDialog();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvKategori.Columns[e.ColumnIndex].Name == "Detail")
                {
                    int index = e.RowIndex;
                    Bahan b = new Bahan();
                    //ini kalau mau pakai constructor buat ngisi propertiesnya bisa, tapi di sini kondisinya aku langsung ngisi propertiesnya :)

                    ////Aku mau pake data table
                    DataTable dt = (DataTable)dgvKategori.DataSource;

                    b.ID = dt.Rows[index]["id"].ToString();
                    b.MERK = dt.Rows[index]["merk"].ToString();
                    b.QTY = int.Parse(dt.Rows[index]["qty_stok"].ToString());
                    b.HARGA = int.Parse(dt.Rows[index]["harga"].ToString());
                    b.SATUAN = dt.Rows[index]["satuan"].ToString();
                    b.KETERANGAN = dgvKategori.Rows[index].Cells["keterangan"].Value.ToString();

                    string jenis = dt.Rows[index]["nama_jenis"].ToString();
                    b.GetJenisBahan(jenis);

                    DetailBahan db = new DetailBahan(this, b);
                    db.ShowDialog();
                }
            }
        }
    }
}
