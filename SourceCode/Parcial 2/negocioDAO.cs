using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2
{
    public class negocioDAO
    {
        public static List<negocio> getnegocio()
        {
            string sql = "SELECT * FROM BUSINESS;";
        
            DataTable dt = Conexion.realizarconsulta(sql);
        
            List<negocio> lista = new List<negocio>();
                    
            foreach (DataRow fila in dt.Rows)
            { negocio n= new negocio();
                        
                n.nombre = fila[1].ToString();
                n.idbussines = Convert.ToInt32(fila[0].ToString());
                        
        
                lista.Add(n);
            }
            return lista;
        }

        public static void agregarbusines(String nombre, String descripcion)
        {
            String sql = String.Format("INSERT INTO BUSINESS(name, description) " +
                                       "VALUES ('{0}', '{1}');", nombre, descripcion);
                Conexion.realizaraccion(sql);


        }
        public static int verificarid(String i)
        {
            
            String sql = String.Format("SELECT bs.idbusiness FROM business bs where name ='{0}';", i);
            DataTable dt =  Conexion.realizarconsulta(sql);
            var dr = dt.Rows[0];
            var prueba = Convert.ToInt32(dr[0].ToString());
            return prueba;





        }
    }
}