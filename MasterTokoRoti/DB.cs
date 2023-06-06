using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MasterTokoRoti
{
    class DB
    {
        private static string connString = "";
        public static SqlConnection conn = null;
        //todo
        const string NAMADB = "db_tokoroti";
        public DB()
        {
            //class ini digunakan untuk menyimpan konfigurasi database
            try
            {

                connString = $"Data Source=.;Initial Catalog={NAMADB}; Integrated Security = True";
                //connection string ini digunakan semacam identitas pengenal buat connect ke database
                //string yang ada dollarnya ($) ini untuk interpolation string, silahkan cari sendiri apa itu :)

                conn = new SqlConnection(connString);
                //ini untuk init connection, supaya kita nantinya bisa pakai connection ini dan gaperlu buat connection baru lagi.
                //dimasukkin try catch karena kalo ada error si sql bakal ngethrow error

                //PASTIKAN DI HALAMAN CONNECTION CLASS DB DI INIT, kalau gak ndabisa di open / close
            }
            catch (Exception exc)
            {
                throw new Exception("Konfigurasi gagal, " + exc.Message.ToString());
            }
        }
        //funcion2 ini dibuat static 
        public static void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            //untuk open
        }
        public static void closeConnection()
        {
            conn.Close();
            //untuk close
        }

        public static DataTable get(string query)
        {
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public static string getScalar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, DB.conn);
            DB.openConnection();
            string res = cmd.ExecuteScalar().ToString();
            DB.closeConnection();
            return res;
        }
        public static DataTable get(string select, string tableName, string[] condition, string orderBy = "")
        {
            string cmdString = builderString(select, tableName, condition, orderBy);
            SqlCommand cmd = new SqlCommand(cmdString, DB.conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        public static string getScalar(string select, string tableName, string[] condition, string orderBy = "")
        {
            string cmdString = builderString(select, tableName, condition, orderBy);
            SqlCommand cmd = new SqlCommand(cmdString, DB.conn);
            DB.openConnection();
            string res = cmd.ExecuteScalar().ToString();
            DB.closeConnection();
            return res;

        }

        private static string builderString(string select, string tableName, string[] condition, string orderBy = "")
        {
            DataSet s = new DataSet();
            string whereBuilder = " ";
            string orderBuilder = " ";
            if (condition.Length > 0)
            {
                whereBuilder += "WHERE ";
                for (int i = 0; i < condition.Length; i++)
                {
                    whereBuilder += condition[i];
                    whereBuilder += (i + 1 < condition.Length - 1) ? " and " : "";
                }
            }
            if (orderBy != "")
            {
                orderBuilder += $"order by {orderBy}";
            }
            select = select == "" ? "*" : select;
            string cmdString = $"SELECT {select} FROM {tableName}{whereBuilder}{orderBuilder}";
            return cmdString;
        }

    }
}
