using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frminiciousuario : Form
    {
        private Appusuario usr;
        private int id;
        public frminiciousuario(Appusuario usuario)
        {
            InitializeComponent();
            usr = usuario;
            id = usr.iduser;
        }
         
         private void poblarCombo()
         {
            
             comboBox4.DataSource = null;
             comboBox4.ValueMember = "idproducto";
             comboBox4.DisplayMember = "nombre";
             comboBox4.DataSource = productoDAO.getproducto();
         }
         private void poblarComboa()
         {

             comboBox5.DataSource = null;
             comboBox5.ValueMember ="iddireccion";
             comboBox5.DisplayMember ="nombre";
             comboBox5.DataSource = direccionDAO.getLista(usr);
         }
         private void poblarCombob()
         {

             comboBox1.DataSource = null;
             comboBox1.ValueMember = "iddireccion";
             comboBox1.DisplayMember = "nombre";
             comboBox1.DataSource = direccionDAO.getLista(usr);
         }
         
         
         private void poblarComboc()
         {

             comboBox2.DataSource = null;
             comboBox2.ValueMember = "iddireccion";
             comboBox2.DisplayMember = "nombre";
             comboBox2.DataSource = direccionDAO.getLista(usr);
         }
         
         private void poblarCombod()
         {

             
         }
         private void frminiciousuario_Load(object sender, EventArgs e)
         {
             poblarComboa();
             poblarCombob();
             poblarComboc();
             poblarCombod();
             poblarCombo();

         }


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var date = DateTime.Today;
                
                String sql = String.Format("insert into APPORDER(createDate,idproduct, idaddress) values ('{0}', {1},{2});",
                    date,comboBox4.SelectedValue, comboBox5.SelectedValue);
                Conexion.realizaraccion(sql);
                poblarComboa();
                poblarCombob();
                poblarComboc();
                poblarCombod();
                MessageBox.Show("¡Se ha guardado el pedido!",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            { MessageBox.Show("No se ha podido hacer su pedido",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { String sql = String.Format(
                    "DELETE FROM ADDRESS WHERE idAddress={0}",
                    comboBox1.SelectedValue);
               
                Conexion.realizaraccion(sql);
                poblarComboa();
                poblarCombob();
                poblarComboc();
                poblarCombod();
              
                
                MessageBox.Show("¡Se ha borrado la dirección!",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido eliminar la dirección",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

      

        private void button4_Click(object sender, EventArgs e)
        { try
            {
                String sql = String.Format(
                    "UPDATE ADDRESS SET address = '{0}' WHERE idAddress = {1}",
                    textBox2.Text, comboBox2.SelectedValue);
                Conexion.realizaraccion(sql);
                poblarComboa();
                poblarCombob();
                poblarComboc();
                poblarCombod();
                
                MessageBox.Show("¡Se ha guardado la direccion nueva!",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch (Exception)
            {
                MessageBox.Show("No se ha guardado el cambio",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            
        }
        
        private void button25_Click(object sender, EventArgs e)
        {  frmtablaus unaVentana = new frmtablaus(usr);
            unaVentana.ShowDialog();
            
            
        }

        

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {   
                String sql = String.Format(
                    "INSERT INTO address(iduser, address) VALUES({0},'{1}');",
                    usr.iduser, textBox1.Text);
                Conexion.realizaraccion(sql);
                poblarComboa();
                poblarCombob();
                poblarComboc();
                poblarCombod();
                
                MessageBox.Show("¡Se ha guardado la dirección!",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show("¡Ha ocurrido un error, dirección no guardada!",
                "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.DataSource = null;
        }

       
        


        
    }
}