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
    public partial class PenganananRoti : Form
    {
        public PenganananRoti()
        {
            InitializeComponent();
        }

        public void PenganananRoti_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select r.id, r.nama, r.deskripsi, r.harga, r.stok, jr.NAMA_JENIS, r.fk_resep, r.status,r.keterangan from roti r , JENIS_ROTI jr where jr.ID= r.JENIS_ROTI and r.status=1 order by r.id desc", DB.conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtkategoriRoti = new DataTable();
            adapter.Fill(dtkategoriRoti);

            dgvKategori.DataSource = null; //untuk menghindari error, kita bisa nge-null kan dulu datasourcenya
            dgvKategori.DataSource = dtkategoriRoti; //baru diset dengan datatable yang tadi

            dgvKategori.Columns["id"].Visible = false;
            dgvKategori.Columns["status"].Visible = false;
            dgvKategori.Columns["deskripsi"].Visible = false;
            dgvKategori.Columns["fk_resep"].Visible = false;
            //dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                SqlCommand cmd = new SqlCommand("select r.id, r.nama, r.deskripsi, r.harga, r.stok, jr.NAMA_JENIS, r.fk_resep, r.status, r.keterangan from roti r , JENIS_ROTI jr where jr.ID= r.JENIS_ROTI and r.nama like '%' + @Search + '%' and r.status = 1 order by r.id desc", DB.conn);
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


                //dgvKategori.Columns["Detail"].DisplayIndex = dgvKategori.Columns.Count - 1;

            }
            catch (Exception ex)
            {
                DB.closeConnection();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
               
                    int index = e.RowIndex;
                //ini kalau mau pakai constructor buat ngisi propertiesnya bisa, tapi di sini kondisinya aku langsung ngisi propertiesnya :)

                ////Aku mau pake data table
                    DataTable dt = (DataTable)dgvKategori.DataSource;
                    lblID.Text = dt.Rows[index]["id"].ToString();
                    lblNama.Text = dt.Rows[index]["nama"].ToString();
                    lblStok.Text = (dt.Rows[index]["stok"].ToString());
                    lblHarga.Text = (dt.Rows[index]["harga"].ToString());
                    lblDeskripsi.Text = dt.Rows[index]["deskripsi"].ToString();
                    lblResep.Text = dt.Rows[index]["fk_resep"].ToString();
                    //r.KETERANGAN = dgvKategori.Rows[index].Cells["keterangan"].Value.ToString();

                    string jenis = dt.Rows[index]["nama_jenis"].ToString();
                    lblJenis.Text = jenis;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jumlah = (int)numJumlahRoti.Value;
            string alasan = txtAlasanRoti.Text;

            //SqlCommand cmd2 = new SqlCommand("update ROTI set stok=stok-@jumlah where id=@id", DB.conn);
            //cmd2.Parameters.AddWithValue("@id", lblID.Text);
            //cmd2.Parameters.AddWithValue("@jumlah", jumlah);
            //DB.openConnection();
            //cmd2.ExecuteNonQuery();
            //DB.closeConnection();

            //MessageBox.Show("Berhasil mengurangi stok roti");

            //SqlCommand cmd2 = new SqlCommand("INSERT INTO PENANGANAN_ROTI VALUES @ID,", DB.conn);
            //cmd2.Parameters.AddWithValue("@id", lblID.Text);
            //cmd2.Parameters.AddWithValue("@jumlah", jumlah);
            //DB.openConnection();
            //cmd2.ExecuteNonQuery();
            //DB.closeConnection();

            SqlCommand cmd1;
            DB.openConnection();
            cmd1 = new SqlCommand("SELECT count(*)+1 FROM PENANGANAN_ROTI;", DB.conn);
            string cek = cmd1.ExecuteScalar().ToString();
            int hasilcek = Int32.Parse(cek);
            DB.closeConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO PENANGANAN_ROTI VALUES(@ID,@TANGGAL,@FK_ROTI,@FK_JENIS_ROTI,@ALASAN,@HARGA,@QTY_STOK)", DB.conn);
            cmd.Parameters.AddWithValue("@ID", hasilcek);
            cmd.Parameters.AddWithValue("@TANGGAL", DateTime.Now.ToString());
            //cmd.Parameters.AddWithValue("@FK_ROTI", this.lblJenis);
            cmd.Parameters.AddWithValue("@FK_ROTI", '1');
            cmd.Parameters.AddWithValue("@FK_JENIS_ROTI", this.lblResep);
            cmd.Parameters.AddWithValue("@ALASAN", alasan);
            cmd.Parameters.AddWithValue("@HARGA", this.lblHarga);
            cmd.Parameters.AddWithValue("@QTY_STOK", this.lblStok);
            DB.openConnection();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            DB.closeConnection();


            this.PenganananRoti_Load(null, null);
        }
    }
}
