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
using MasterTokoRoti.Models;

namespace MasterTokoRoti
{
    public partial class ViewPegawai : Form
    {
        public ViewPegawai()
        {
            InitializeComponent();
        }

        public void ViewPegawai_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT id,nama,username,password,jenis_kelamin,alamat,email,no_telp,tanggal_lahir, fk_jabatan, case when fk_jabatan=1 then 'Karyawan' when fk_jabatan=2 then 'Manager' else 'Chef' END as 'Jabatan', status, keterangan from karyawan where status=1 order by id desc", DB.conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtkategoriBahan = new DataTable();
            adapter.Fill(dtkategoriBahan);

            dgvKategori.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dgvKategori.DataSource = dtkategoriBahan; //baru diset dengan datatable yang tadi

            dgvKategori.Columns["id"].Visible = false;
            dgvKategori.Columns["password"].Visible = false;
            dgvKategori.Columns["jenis_kelamin"].Visible = false;
            dgvKategori.Columns["alamat"].Visible = false;
            dgvKategori.Columns["tanggal_lahir"].Visible = false;
            dgvKategori.Columns["status"].Visible = false;
            dgvKategori.Columns["fk_jabatan"].Visible = false;
            dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("Select id,nama,username,password,jenis_kelamin,alamat,email,no_telp,tanggal_lahir, fk_jabatan, case when fk_jabatan=1 then 'Karyawan' when fk_jabatan=2 then 'Manager' else 'Chef' END as 'Jabatan', status, keterangan from karyawan where nama like '%' + @Search + '%' and status=1 order by id desc", DB.conn);
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                cmd.ExecuteNonQuery();


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvKategori.DataSource = null;
                dgvKategori.DataSource = dt;

                dgvKategori.Columns["id"].Visible = false;
                dgvKategori.Columns["password"].Visible = false;
                dgvKategori.Columns["jenis_kelamin"].Visible = false;
                dgvKategori.Columns["alamat"].Visible = false;
                dgvKategori.Columns["tanggal_lahir"].Visible = false;
                dgvKategori.Columns["status"].Visible = false;
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
            InsertPegawai i = new InsertPegawai(this);
            i.ShowDialog();
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                if (this.dgvKategori.Columns[e.ColumnIndex].Name == "Detail")
                {
                    int index = e.RowIndex;
                    Pegawai p = new Pegawai();
                    //ini kalau mau pakai constructor buat ngisi propertiesnya bisa, tapi di sini kondisinya aku langsung ngisi propertiesnya :)

                    p.ID = dgvKategori.Rows[index].Cells["id"].Value.ToString();
                    p.NAMA = dgvKategori.Rows[index].Cells["nama"].Value.ToString();
                    p.USERNAME = dgvKategori.Rows[index].Cells["username"].Value.ToString();
                    p.PASSWORD = dgvKategori.Rows[index].Cells["password"].Value.ToString();
                    p.JENISKELAMIN = Char.Parse(dgvKategori.Rows[index].Cells["jenis_kelamin"].Value.ToString());
                    p.ALAMAT = dgvKategori.Rows[index].Cells["alamat"].Value.ToString();
                    p.EMAIL = dgvKategori.Rows[index].Cells["email"].Value.ToString();
                    p.NOTELP = dgvKategori.Rows[index].Cells["no_telp"].Value.ToString();
                    p.TANGGALLAHIR = dgvKategori.Rows[index].Cells["tanggal_lahir"].Value.ToString();
                    p.FK_JABATAN = Int32.Parse(dgvKategori.Rows[index].Cells["fk_jabatan"].Value.ToString());
                    p.KETERANGAN = dgvKategori.Rows[index].Cells["keterangan"].Value.ToString();
                    DetailPegawai dp = new DetailPegawai(this,p);
                    dp.ShowDialog();
                }
            }
        }
    }
}
