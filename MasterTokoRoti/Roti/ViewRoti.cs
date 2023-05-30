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
    public partial class ViewRoti : Form
    {
        public ViewRoti()
        {
            InitializeComponent();
        }

        public void ViewRoti_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select r.id, r.nama, r.deskripsi, r.harga, r.stok, jr.NAMA_JENIS, r.status,r.keterangan, r.fk_resep from roti r , JENIS_ROTI jr where jr.ID= r.FK_JENIS_ROTI and r.status=1 order by r.id desc", DB.conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtkategoriRoti = new DataTable();
            adapter.Fill(dtkategoriRoti);

            dgvKategori.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dgvKategori.DataSource = dtkategoriRoti; //baru diset dengan datatable yang tadi

            dgvKategori.Columns["id"].Visible = false;
            dgvKategori.Columns["status"].Visible = false;
            dgvKategori.Columns["deskripsi"].Visible = false;
            dgvKategori.Columns["fk_resep"].Visible = false;
            dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("select r.id, r.nama, r.deskripsi, r.harga, r.stok, jr.NAMA_JENIS, r.status, r.keterangan, r.fk_resep from roti r , JENIS_ROTI jr where jr.ID= r.JENIS_ROTI and r.nama like '%' + @Search + '%' and r.status = 1 order by r.id desc", DB.conn);
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                cmd.ExecuteNonQuery();


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKategori.DataSource = null;
                dgvKategori.DataSource = dt;

                dgvKategori.Columns["id"].Visible = false;
                dgvKategori.Columns["status"].Visible = false;
                dgvKategori.Columns["deskripsi"].Visible = false;
                dgvKategori.Columns["fk_resep"].Visible = false;

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

        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvKategori.Columns[e.ColumnIndex].Name == "Detail")
                {
                    int index = e.RowIndex;
                    Roti r = new Roti();
                    //ini kalau mau pakai constructor buat ngisi propertiesnya bisa, tapi di sini kondisinya aku langsung ngisi propertiesnya :)

                    ////Aku mau pake data table
                    DataTable dt = (DataTable)dgvKategori.DataSource;

                    r.ID = dt.Rows[index]["id"].ToString();
                    r.NAMA = dt.Rows[index]["nama"].ToString();
                    r.DESKRIPSI = dt.Rows[index]["deskripsi"].ToString();
                    r.STOK = int.Parse(dt.Rows[index]["stok"].ToString());
                    r.HARGA = int.Parse(dt.Rows[index]["harga"].ToString());
                    r.KETERANGAN = dt.Rows[index]["keterangan"].ToString();
                    r.FK_RESEP = int.Parse(dt.Rows[index]["fk_resep"].ToString());

                    string jenis = dt.Rows[index]["nama_jenis"].ToString();
                    r.GetJenisRoti(jenis);

                    DetailRoti dr = new DetailRoti(this, r);
                    dr.ShowDialog();
                }
            }
        }
    }
}
