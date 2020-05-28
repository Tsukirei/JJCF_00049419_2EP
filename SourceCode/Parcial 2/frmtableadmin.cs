using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmtableadmin : Form
    {
        public frmtableadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            
                var dt = Conexion.realizarconsulta("SELECT * FROM APPUSER;");
                dataGridView1.DataSource = dt;
                MessageBox.Show("Datosobtenidos exitosamente");
            }catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}