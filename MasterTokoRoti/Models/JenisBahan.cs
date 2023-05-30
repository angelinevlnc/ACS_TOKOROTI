using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Jangan lupa import ini
using System.Data;

namespace MasterTokoRoti.Models
{
    public class JenisBahan
    {
        public string ID;
        public string NAMA_JENIS;
        public string KETERANGAN;

        public JenisBahan() { }

        public JenisBahan(string id, string nama_jenis, string keterangan)
        {
            this.ID = id;
            this.NAMA_JENIS = nama_jenis;
            this.KETERANGAN = keterangan;
        }

        public static DataTable fetch()
        {
            //nantinya, dari function fetch ini akan ngembaliin sebuah datatable, yang bisa langsung dipasang jadi datasource untuk datagridview di form. Ini biar codenya jadi lebih clean dan terstruktur :)

            SqlCommand cmd = new SqlCommand("select id, nama_jenis,keterangan from jenis_bahan", DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public void insert()
        {
            SqlCommand cmd1;
            DB.openConnection();
            cmd1 = new SqlCommand("SELECT count(*)+1 FROM JENIS_BAHAN;", DB.conn);
            string cek = cmd1.ExecuteScalar().ToString();
            int hasilcek = Int32.Parse(cek);
            DB.closeConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO JENIS_BAHAN VALUES(@ID,@NAMA_JENIS,@status,@keterangan)", DB.conn);
            cmd.Parameters.AddWithValue("@ID", hasilcek);
            cmd.Parameters.AddWithValue("@NAMA_JENIS", this.NAMA_JENIS);
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
            SqlCommand cmd = new SqlCommand("UPDATE JENIS_BAHAN SET status=0 WHERE id=@id", DB.conn);
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
            SqlCommand cmd = new SqlCommand("UPDATE jenis_bahan SET nama_jenis = @nama_jenis, keterangan = @keterangan WHERE id=@id", DB.conn);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.Parameters.AddWithValue("@nama_jenis", this.NAMA_JENIS);
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
    }


}
