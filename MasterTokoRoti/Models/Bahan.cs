using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Jangan lupa import ini
using System.Data;

namespace MasterTokoRoti.Models
{
    public class Bahan
    {
        public string ID;
        public string MERK;
        public int QTY;
        public int HARGA;
        public string SATUAN;
        public int JENIS_BAHAN;
        public string STATUS;
        public string KETERANGAN;
        public JenisBahan JENIS_BAHAN_OBJ;

        //public Bahan(string id, string merk, int qty, int harga, string satuan, int jenis_bahan, string status, string keterangan)
        //{
        //    this.ID = id;
        //    this.MERK = merk;
        //    this.QTY = qty;
        //    this.HARGA = harga;
        //    this.SATUAN = satuan;
        //    this.JENIS_BAHAN = jenis_bahan;
        //    this.GetJenisBahan(jenis_bahan); //ini mendapatkan objek jenis bahan
        //    this.STATUS = status;
        //    this.KETERANGAN = keterangan;
        //}

        public void insert()
        {
            SqlCommand cmd1;
            DB.openConnection();
            cmd1 = new SqlCommand("SELECT count(*)+1 FROM BAHAN;", DB.conn);
            string cek = cmd1.ExecuteScalar().ToString();
            int hasilcek = Int32.Parse(cek);
            DB.closeConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO BAHAN VALUES(@ID,@MERK,@QTY,@HARGA,@SATUAN,@JENIS_BAHAN,@status,@keterangan)", DB.conn);
            cmd.Parameters.AddWithValue("@ID", hasilcek);
            cmd.Parameters.AddWithValue("@MERK", this.MERK);
            cmd.Parameters.AddWithValue("@QTY", this.QTY);
            cmd.Parameters.AddWithValue("@HARGA", this.HARGA);
            cmd.Parameters.AddWithValue("@SATUAN", this.SATUAN);
            cmd.Parameters.AddWithValue("@JENIS_BAHAN", this.JENIS_BAHAN);
            cmd.Parameters.AddWithValue("@status", '1');
            cmd.Parameters.AddWithValue("@keterangan", this.KETERANGAN);
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
        }

        public void delete()
        {
            SqlCommand cmd = new SqlCommand("UPDATE BAHAN SET status=0 WHERE id=@id", DB.conn);
            cmd.Parameters.AddWithValue("@id", this.ID);
            //SqlCommand cmd2 = new SqlCommand("DELETE FROM notification WHERE N_ID=@idN", DB.conn);
            //cmd2.Parameters.AddWithValue("@idN", this.ID);
            //SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE U_ID=@id", DB.conn);
            //cmd.Parameters.AddWithValue("@id", this.ID);

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
        }

        public void update()
        {
            SqlCommand cmd = new SqlCommand("UPDATE BAHAN SET qty_STOK = @qty, merk=@merk, harga=@harga, satuan=@satuan, fk_jenis_bahan = @jenis_bahan, status=@status, keterangan=@keterangan WHERE id=@id", DB.conn);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.Parameters.AddWithValue("@MERK", this.MERK);
            cmd.Parameters.AddWithValue("@QTY", this.QTY);
            cmd.Parameters.AddWithValue("@HARGA", this.HARGA);
            cmd.Parameters.AddWithValue("@SATUAN", this.SATUAN);
            cmd.Parameters.AddWithValue("@JENIS_BAHAN", this.JENIS_BAHAN_OBJ.ID);
            cmd.Parameters.AddWithValue("@status", '1');
            cmd.Parameters.AddWithValue("@keterangan", this.KETERANGAN);

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
        }

        public void GetJenisBahan(string nama)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandText = "select * from jenis_bahan where nama_jenis=@name";
            cmd.Parameters.AddWithValue("name", nama);
            DB.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DB.closeConnection();

            JenisBahan jb = new JenisBahan(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString()
            );

            this.JENIS_BAHAN_OBJ = jb;
        }

        public void GetJenisBahan(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandText = "select * from jenis_bahan where id=@id";
            cmd.Parameters.AddWithValue("id", id);
            DB.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DB.closeConnection();

            JenisBahan jb = new JenisBahan(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString()
            );

            this.JENIS_BAHAN_OBJ = jb;
        }

        //public static Bahan get(int id)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = DB.conn;
        //    cmd.CommandText = "select * from bahan where id=@id";
        //    cmd.Parameters.AddWithValue("id", id);
        //    DB.openConnection();

        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);

        //    Bahan b = new Bahan(
        //        dt.Rows[0]["id"].ToString()
        //    );

        //    return b;
        //}
    }
}
