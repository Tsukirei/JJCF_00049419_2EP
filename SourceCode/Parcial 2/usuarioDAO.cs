using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2
{
    public class usuarioDAO
    {
        public static List<Appusuario> getLista()
        {
            string sql = "SELECT * FROM appuser";

            DataTable dt = Conexion.realizarconsulta(sql);

            List<Appusuario> lista = new List<Appusuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Appusuario u = new Appusuario();
                u.iduser = Convert.ToInt32(fila[0].ToString());
                u.usuario = fila[2].ToString();
                u.nombre = fila[1].ToString();
                u.contrasena = fila[3].ToString();
                u.admin = Convert.ToBoolean(fila[4].ToString());
                

                lista.Add(u);
            }
            return lista;
        }
        public static void actualizarcontra(string usuario, string nuevacontra)
        {
            string sql = String.Format(
                "update usuario set contrasena='{0}' where usuario='{1}';",
                nuevacontra, usuario);
            
            Conexion.realizaraccion(sql);
        }

        public static void ingresarusuario(String user, String name, String password, bool usert)
        {
            String sql = String.Format("INSERT INTO APPUSER(fullname, username, password, userType)" +
                                       " VALUES('{0}', '{1}', '{2}','{4}');", name, user, password, usert);
           Conexion.realizaraccion(sql);


        }
    }
}