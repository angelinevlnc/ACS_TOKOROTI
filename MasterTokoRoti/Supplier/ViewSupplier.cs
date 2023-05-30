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
    public partial class ViewSupplier : Form
    {
        public ViewSupplier()
        {
            InitializeComponent();
        }

        public void ViewSupplier_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id, NAMA, ALAMAT,EMAIL,NO_TELP,keterangan from SUPPLIER where status=1 order by id desc", DB.conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtkategoriRoti = new DataTable();
            adapter.Fill(dtkategoriRoti);

            dgvKategori.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dgvKategori.DataSource = dtkategoriRoti; //baru diset dengan datatable yang tadi

            dgvKategori.Columns["id"].Visible = false;
            dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("SELECT id, NAMA, ALAMAT,EMAIL,NO_TELP,keterangan from SUPPLIER where nama like '%' + @Search + '%' and status=1 order by id desc", DB.conn);
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
            InsertSupplier i = new InsertSupplier(this);
            i.ShowDialog();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvKategori.Columns[e.ColumnIndex].Name == "Detail")
                {
                    int index = e.RowIndex;
                    Supplier s = new Supplier();
                    //ini kalau mau pakai constructor buat ngisi propertiesnya bisa, tapi di sini kondisinya aku langsung ngisi propertiesnya :)

                    s.ID = dgvKategori.Rows[index].Cells["id"].Value.ToString();
                    s.NAMA = dgvKategori.Rows[index].Cells["nama"].Value.ToString();
                    s.ALAMAT = dgvKategori.Rows[index].Cells["alamat"].Value.ToString();
                    s.EMAIL = dgvKategori.Rows[index].Cells["email"].Value.ToString();
                    s.NOTELP = dgvKategori.Rows[index].Cells["no_telp"].Value.ToString();
                    s.KETERANGAN = dgvKategori.Rows[index].Cells["keterangan"].Value.ToString();
                    DetailSupplier ds = new DetailSupplier(this, s);
                    ds.ShowDialog();
                }
            }
        }
    }
}
