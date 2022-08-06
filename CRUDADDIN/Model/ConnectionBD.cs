using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDADDIN.Model
{
    public static class ConnectionBD
    {
        public static string connectionString { get; set; }
        static SqlConnection con;

        public static void OpenConnect() { 
            con = new SqlConnection(connectionString);
            con.Open();
        }
        public static void CloseConnect() {
            con.Close();
        }
        public static void ExecuteSql(string Sql)
        {
            OpenConnect();

            SqlCommand cmd = new SqlCommand(Sql);
            cmd.ExecuteNonQuery();
        }
        public static SqlDataReader DataReader (string Sql)
        {
            OpenConnect();

            SqlCommand cmd = new SqlCommand(Sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public static object SqlScalar(string Sql)
        {
            OpenConnect();

            SqlDataAdapter dr = new SqlDataAdapter(Sql, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public static bool StatusConexao()
        {
            if (con != null && con.State.ToString() == "Open")
            {
                return true;
            }
            else { return false; }
        }
    }
}



