using System.Data;
using Npgsql;

namespace Parcial_2
{
    public class Conexion
    {
        private static string conexionbase = 
            "Server=127.0.0.1;Port=5432;User Id=postgres;Password=chavz22001;Database=parcial 2";
        public static DataTable realizarconsulta(string sql)
        {
            NpgsqlConnection con = new NpgsqlConnection(conexionbase);
            DataSet ds = new DataSet();
            con.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            da.Fill(ds);
            con.Close();
            
            return ds.Tables[0];
        }
        public static void realizaraccion(string sql)
        {
            NpgsqlConnection con = new NpgsqlConnection(conexionbase);
            
            con.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, con);
            nc.ExecuteNonQuery();
            con.Close();
        }
    }
}