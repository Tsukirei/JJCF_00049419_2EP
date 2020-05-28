using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmtablaus : Form
    {
        private Appusuario user;
        public frmtablaus(Appusuario sr)
        {
            InitializeComponent();
            user = sr;
        }
        
        
        
          

        private void button1_Click(object sender, EventArgs e)
        {
            String sql=String.Format("SELECT ao.idorder, ao.createdate, pr.name, au.fullname, ad.address"+
                                  " FROM apporder ao, address ad, product pr, appuser au"+
                                  " WHERE ao.idproduct = pr.idproduct" +
                                  " AND ao.idaddress = ad.idaddress"+
                                  " AND ad.iduser = au.iduser "+
                                  "AND au.iduser = {0};", user.iduser);
            try{
            
                var dt = Conexion.realizarconsulta(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Datosobtenidos exitosamente");
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}