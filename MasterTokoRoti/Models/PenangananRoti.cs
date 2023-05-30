using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Jangan lupa import ini
using System.Data;

namespace MasterTokoRoti.Models
{
    public class PenangananRoti
    {
        public string ID;
        public string TANGGAL;
        public int FK_ROTI;
        public int FK_JENIS_ROTI;
        public string ALASAN;
        public int HARGA;
        public int QTY_STOK;

        public void insert()
        {
            SqlCommand cmd1;
            DB.openConnection();
            cmd1 = new SqlCommand("SELECT count(*)+1 FROM PENANGANAN_ROTI;", DB.conn);
            string cek = cmd1.ExecuteScalar().ToString();
            int hasilcek = Int32.Parse(cek);
            DB.closeConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO PENANGANAN_ROTI VALUES(@ID,@TANGGAL,@FK_ROTI,@FK_JENIS_ROTI,@ALASAN,@HARGA,@QTY_STOK)", DB.conn);
            cmd.Parameters.AddWithValue("@ID", hasilcek);
            cmd.Parameters.AddWithValue("@TANGGAL", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@FK_ROTI", this.FK_ROTI);
            cmd.Parameters.AddWithValue("@FK_JENIS_ROTI", this.FK_JENIS_ROTI);
            cmd.Parameters.AddWithValue("@ALASAN", this.ALASAN);
            cmd.Parameters.AddWithValue("@HARGA", this.HARGA);
            cmd.Parameters.AddWithValue("@QTY_STOK", this.QTY_STOK);
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
