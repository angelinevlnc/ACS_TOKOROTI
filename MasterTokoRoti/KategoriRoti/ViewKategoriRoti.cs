using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MasterTokoRoti.Models;


namespace MasterTokoRoti
{
    public partial class ViewKategoriRoti : Form
    {
        public ViewKategoriRoti()
        {
            InitializeComponent();
        }

        public void ViewKategoriRoti_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, nama_jenis,keterangan from jenis_roti where status=1 order by id desc", DB.conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtkategoriRoti = new DataTable();
            adapter.Fill(dtkategoriRoti);

            dgvKategori.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dgvKategori.DataSource = dtkategoriRoti; //baru diset dengan datatable yang tadi

            dgvKategori.Columns["id"].Visible = false;
            dgvKategori.Columns["nama_jenis"].HeaderText = "Nama";
            dgvKategori.Columns["keterangan"].HeaderText = "Keterangan";
            dgvKategori.Columns["nama_jenis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //ini gakbisa gatau kenapa
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("Select id,nama_jenis,keterangan From jenis_roti where nama_jenis like '%' + @Search + '%' and status=1 order by id desc", DB.conn);
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                cmd.ExecuteNonQuery();


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKategori.DataSource = null;
                dgvKategori.DataSource = dt;

                dgvKategori.Columns["id"].Visible = false;
                dgvKategori.Columns["nama_jenis"].HeaderText = "Nama";
                dgvKategori.Columns["keterangan"].HeaderText = "Keterangan";
                dgvKategori.Columns["nama_jenis"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            InsertKategoriRoti i = new InsertKategoriRoti(this  );
            i.ShowDialog();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvKategori.Columns[e.ColumnIndex].Name == "Detail")
                {
                    int index = e.RowIndex;
                    JenisRoti jr = new JenisRoti();
                    //ini kalau mau pakai constructor buat ngisi propertiesnya bisa, tapi di sini kondisinya aku langsung ngisi propertiesnya :)

                    jr.ID = dgvKategori.Rows[index].Cells["id"].Value.ToString();
                    jr.NAMA_JENIS = dgvKategori.Rows[index].Cells["nama_jenis"].Value.ToString();
                    jr.KETERANGAN = dgvKategori.Rows[index].Cells["keterangan"].Value.ToString();
                    DetailKategoriRoti dkr = new DetailKategoriRoti(this, jr);
                    dkr.ShowDialog();
                }
            }
        }
    }
}
