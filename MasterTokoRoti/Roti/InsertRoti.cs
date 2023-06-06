using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterTokoRoti
{
    public partial class InsertRoti : Form
    {
        public InsertRoti()
        {
            InitializeComponent();

        }

        ViewRoti parent;
        public InsertRoti(ViewRoti p)
        {
            InitializeComponent();
            parent = p;
        }

        DataTable jenisRoti = new DataTable();

        private void InsertRoti_Load(object sender, EventArgs e)
        {
            //Load dropdown jenis roti
            String q3 = "SELECT nama_jenis as Name from jenis_roti";
            jenisRoti = DB.get(q3);

            cbJenisRoti.DataSource = null;
            cbJenisRoti.DataSource = jenisRoti;
            cbJenisRoti.DisplayMember = "Name";
            cbJenisRoti.ValueMember = "Name";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //todo

            //validasi semuanya keisi
            String nama = txtNama.Text;
            String deskripsi = txtDeskripsi.Text;
            String keterangan = txtKeterangan.Text;
            int stok = (int)numStok.Value;
            int harga = (int)numHarga.Value;

            int selectedObj = cbJenisRoti.SelectedIndex;

            String name = jenisRoti.Rows[selectedObj]["Name"].ToString();

            if (nama.Equals(""))
            {
                MessageBox.Show("Nama kosong");
            }
            else
            {
                DataTable dtt = new DataTable();
                String q3 = $"SELECT TOP 1 ID from JENIS_ROTI where nama_jenis='{name}' and status=1";

                int idJenisRoti = Int32.Parse(DB.getScalar(q3));

                int idHResep = generateHResepId();
                String hResepNama = "Resep " + nama;

                //insert dulu ke h_resep
                DB.openConnection(); //open dulu connectionnya
                SqlTransaction transaction8 = DB.conn.BeginTransaction();

                try
                {
                    DB.openConnection(); //open dulu connectionnya
                    transaction8 = DB.conn.BeginTransaction();

                    String cmdStringHeader = $"INSERT INTO H_RESEP (ID, NAMA) VALUES({idHResep},'{hResepNama}')";

                    SqlCommand cmdHeader = new SqlCommand(cmdStringHeader, DB.conn, transaction8);

                    cmdHeader.ExecuteNonQuery();

                    transaction8.Commit();
                }
                catch (Exception ex)
                {
                    transaction8.Rollback(); //dirollback kalau error
                    MessageBox.Show(ex.Message.ToString(), "Gagal insert data h resep");
                }

                //insert dulu ke roti
                DB.openConnection(); //open dulu connectionnya
                SqlTransaction transaction2 = DB.conn.BeginTransaction();

                int idRoti = generateRotiId();
                try
                {
                    DB.openConnection(); //open dulu connectionnya
                    transaction2 = DB.conn.BeginTransaction();

                    String cmdStringHeader = $"INSERT INTO ROTI (ID, NAMA, DESKRIPSI, HARGA, STOK, STATUS, FK_JENIS_ROTI, FK_RESEP, KETERANGAN) " +
                        $" VALUES({idRoti}, '{nama}', '{deskripsi}', {harga}, {stok}, {1}, {idJenisRoti}, {idHResep}, '{keterangan}')";

                    SqlCommand cmdHeader = new SqlCommand(cmdStringHeader, DB.conn, transaction2);

                    cmdHeader.ExecuteNonQuery();

                    transaction2.Commit();

                    MessageBox.Show("Roti berhasil tersimpan");

                    parent.ViewRoti_Load(sender, e);
                }
                catch (Exception ex)
                {
                    transaction2.Rollback(); //dirollback kalau error
                    MessageBox.Show(ex.Message.ToString(), "Gagal insert data roti");
                }

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtDeskripsi.Text = "";
            numHarga.Value = 0;
            numStok.Value = 0;
            txtKeterangan.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cbJenisRoti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int generateHResepId()
        {
            String q = "select count(*)+1 from h_resep";

            int tmp = Int32.Parse(DB.getScalar(q));

            return tmp;
        }

        private int generateRotiId()
        {
            String q = "select count(*)+1 from roti";

            int tmp = Int32.Parse(DB.getScalar(q));

            return tmp;
        }

        private int getLatestHResepId()
        {
            String q = "select top 1 id from h_resep order by id desc";

            int tmp = Int32.Parse(DB.getScalar(q));

            return tmp;
        }
    }
}
