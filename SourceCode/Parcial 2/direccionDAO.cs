using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_2
{
    public class direccionDAO
    {
        public static List<direccion> getLista(Appusuario u)
        {
            String sql = String.Format("SELECT ad.idaddress, ad.address FROM ADDRESS ad WHERE iduser = {0};", u.iduser);
            
            DataTable dt = Conexion.realizarconsulta(sql);

            List<direccion> lista = new List<direccion>();
            foreach (DataRow fila in dt.Rows)
            {
                direccion n = new direccion();
                n.iddireccion = Convert.ToInt32(fila[0].ToString());
                n.nombre = fila[1].ToString();


                lista.Add(n);
            }

            return lista;

        }
    }
}