using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Jangan lupa import ini
using System.Data;

namespace MasterTokoRoti.Models
{
    public class Supplier
    {
        public string ID;
        public string NAMA;
        public string ALAMAT;
        public string EMAIL;
        public string NOTELP;
        public string STATUS;
        public string KETERANGAN;

        public void insert()
        {
            SqlCommand cmd1;
            DB.openConnection();
            cmd1 = new SqlCommand("SELECT count(*)+1 FROM SUPPLIER;", DB.conn);
            string cek = cmd1.ExecuteScalar().ToString();
            int hasilcek = Int32.Parse(cek);
            DB.closeConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO SUPPLIER VALUES(@ID,@NAMA,@ALAMAT,@EMAIL,@NOTELP,@status,@keterangan)", DB.conn);
            cmd.Parameters.AddWithValue("@ID", hasilcek);
            cmd.Parameters.AddWithValue("@NAMA", this.NAMA);
            cmd.Parameters.AddWithValue("@ALAMAT", this.ALAMAT);
            cmd.Parameters.AddWithValue("@EMAIL", this.EMAIL);
            cmd.Parameters.AddWithValue("@NOTELP", this.NOTELP);
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
            SqlCommand cmd = new SqlCommand("UPDATE SUPPLIER SET status=0 WHERE id=@id", DB.conn);
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
            SqlCommand cmd = new SqlCommand("UPDATE SUPPLIER SET nama = @nama, alamat=@alamat, email=@email, no_telp=@notelp, keterangan = @keterangan WHERE id=@id", DB.conn);
            cmd.Parameters.AddWithValue("@id", this.ID);
            cmd.Parameters.AddWithValue("@NAMA", this.NAMA);
            cmd.Parameters.AddWithValue("@ALAMAT", this.ALAMAT);
            cmd.Parameters.AddWithValue("@EMAIL", this.EMAIL);
            cmd.Parameters.AddWithValue("@NOTELP", this.NOTELP);
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

    }
}
