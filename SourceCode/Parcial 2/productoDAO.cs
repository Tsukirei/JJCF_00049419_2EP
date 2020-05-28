using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2
{
    public class productoDAO
    {
        public static List<producto> getproducto()
        {
            string sql = String.Format("SELECT * FROM PRODUCT;");
               
        
                    DataTable dt = Conexion.realizarconsulta(sql);
        
                    List<producto> lista = new List<producto>();
                    
                    foreach (DataRow fila in dt.Rows)
                    { producto n= new producto();
                        
                        n.nombre = fila[2].ToString();
                        n.idbussines = Convert.ToInt32(fila[1].ToString());
                        n.idproducto = Convert.ToInt32(fila[0].ToString());
                        
        
                        lista.Add(n);
                    }
                    return lista;
                }
        public static List<producto> getproducto2()
        {
            String sql =String.Format("SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = 1;");
        
            DataTable dt = Conexion.realizarconsulta(sql);
        
            List<producto> lista = new List<producto>();
                    
            foreach (DataRow fila in dt.Rows)
            { producto n= new producto();
                        
                n.nombre = fila[2].ToString();
                n.idproducto = Convert.ToInt32(fila[0].ToString());
                        
        
                lista.Add(n);
            }
            return lista;
        }
    }
}