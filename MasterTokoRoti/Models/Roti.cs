using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Jangan lupa import ini
using System.Data;

namespace MasterTokoRoti.Models
{
    public class Roti
    {
        public string ID;
        public string NAMA;
        public string DESKRIPSI;
        public int HARGA;
        public int STOK;
        public string STATUS;
        public int JENIS_ROTI;
        public int FK_RESEP;
        public string KETERANGAN;
        public JenisRoti JENIS_ROTI_OBJ;

        public void insert()
        {
            SqlCommand cmd1;
            DB.openConnection();
            cmd1 = new SqlCommand("SELECT count(*)+1 FROM ROTI;", DB.conn);
            string cek = cmd1.ExecuteScalar().ToString();
            int hasilcek = Int32.Parse(cek);
            DB.closeConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO ROTI VALUES(@ID,@NAMA,@DESKRIPSI,@HARGA,@STOK,@status,,@JENIS_ROTI,@FK_RESEP,@keterangan)", DB.conn);
            cmd.Parameters.AddWithValue("@ID", hasilcek);
            cmd.Parameters.AddWithValue("@NAMA", this.NAMA);
            cmd.Parameters.AddWithValue("@DESKRIPSI", this.DESKRIPSI);
            cmd.Parameters.AddWithValue("@HARGA", this.HARGA);
            cmd.Parameters.AddWithValue("@STOK", this.STOK);
            cmd.Parameters.AddWithValue("@JENIS_ROTI", this.JENIS_ROTI);
            cmd.Parameters.AddWithValue("@FK_RESEP", this.FK_RESEP);
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
            SqlCommand cmd = new SqlCommand("UPDATE ROTI SET status=0 WHERE id=@id", DB.conn);
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
            SqlCommand cmd = new SqlCommand("UPDATE ROTI SET nama=@NAMA, deskripsi=@DESKRIPSI, harga=@HARGA, stok=@STOK, status=@status, fk_jenis_roti=@JENIS_ROTI, fk_resep = @FK_RESEP, keterangan=@keterangan WHERE id=@id", DB.conn);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.Parameters.AddWithValue("@NAMA", this.NAMA);
            cmd.Parameters.AddWithValue("@DESKRIPSI", this.DESKRIPSI);
            cmd.Parameters.AddWithValue("@HARGA", this.HARGA);
            cmd.Parameters.AddWithValue("@STOK", this.STOK);
            cmd.Parameters.AddWithValue("@JENIS_ROTI", this.JENIS_ROTI_OBJ.ID);
            cmd.Parameters.AddWithValue("@FK_RESEP", this.FK_RESEP);
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

        public void GetJenisRoti(string nama)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandText = "select * from jenis_roti where nama_jenis=@name";
            cmd.Parameters.AddWithValue("name", nama);
            DB.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DB.closeConnection();

            JenisRoti jr = new JenisRoti(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString()
            );

            this.JENIS_ROTI_OBJ = jr;
        }

        public void GetJenisBahan(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DB.conn;
            cmd.CommandText = "select * from jenis_roti where id=@id";
            cmd.Parameters.AddWithValue("id", id);
            DB.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            DB.closeConnection();

            JenisRoti jr = new JenisRoti(
                dt.Rows[0][0].ToString(),
                dt.Rows[0][1].ToString(),
                dt.Rows[0][2].ToString()
            );

            this.JENIS_ROTI_OBJ = jr;
        }

    }
}
