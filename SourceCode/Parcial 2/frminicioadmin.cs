using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frminicioadmin : Form
    {
        private Appusuario user;

        public frminicioadmin(Appusuario usuario)
        {
            InitializeComponent();
            user = usuario;


        }


        private void poblarCombo()
        {

            comboBox2.DataSource = null;
            comboBox2.ValueMember = "contrasena";
            comboBox2.DisplayMember = "usuario";
            comboBox2.DataSource = usuarioDAO.getLista();
        }

        private void poblarCombo1()
        {
            comboBox3.DataSource = null;
            comboBox3.ValueMember = "idbussines";
            comboBox3.DisplayMember = "nombre";
            comboBox3.DataSource = negocioDAO.getnegocio();
        }

        private void poblarCombo2()
        {
            comboBox4.DataSource = null;
            comboBox4.ValueMember = "idbussines";
            comboBox4.DisplayMember = "nombre";
            comboBox4.DataSource = negocioDAO.getnegocio();
        }

        private void poblarCombo3()
        {
            comboBox5.DataSource = null;
            comboBox5.ValueMember = "idproducto";
            comboBox5.DisplayMember = "nombre";
            comboBox5.DataSource = productoDAO.getproducto();
        }


        private void frminicioadmin_Load(object sender, EventArgs e)
        {
            poblarCombo();
            poblarCombo1();
            poblarCombo2();
            poblarCombo3();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            bool tipo=true;
            if (comboBox1.SelectedIndex==0)
            {
                tipo = true;
            }
            else
            {
                tipo = false;
            }

            try
            {
                usuarioDAO.ingresarusuario(textBox1.Text, textBox2.Text, textBox1.Text, tipo);
                MessageBox.Show("Se ha guardado el usuario exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poblarCombo();
                poblarCombo1();
                poblarCombo2();
                poblarCombo3();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar el usuario",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sql = String.Format("DELETE FROM APPUSER WHERE username='{0}';", comboBox2.Text);
            try
            {
                Conexion.realizaraccion(sql);
                MessageBox.Show("Se ha borrado el usuario exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poblarCombo();
                poblarCombo1();
                poblarCombo2();
                poblarCombo3();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido borrar el usuario",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmtableadmin unaVentana = new frmtableadmin();
            unaVentana.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                negocioDAO.agregarbusines(textBox3.Text, textBox4.Text);
                MessageBox.Show("Se ha añadido el negocio exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poblarCombo();
                poblarCombo1();
                poblarCombo2();
                poblarCombo3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido agregar el negocio",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(comboBox3.SelectedValue);
            String sql = String.Format("DELETE FROM BUSINESS WHERE idbusiness = {0};", j);

            try
            {
                Conexion.realizaraccion(sql);
                MessageBox.Show("Se ha eliminado el negocio exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poblarCombo();
                poblarCombo1();
                poblarCombo2();
                poblarCombo3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar el negocio",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt16(comboBox4.SelectedValue);
            String sql = String.Format("INSERT INTO PRODUCT(idbusiness, name) VALUES({0},'{1}');", j, textBox5.Text);

            try
            {
                Conexion.realizaraccion(sql);
                MessageBox.Show("Se ha agregado el producto exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                poblarCombo();
                poblarCombo1();
                poblarCombo2();
                poblarCombo3();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido agregar el producto",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            String sql = String.Format("DELETE FROM PRODUCT WHERE idProduct = {0};", comboBox5.SelectedValue);

            try
            {
                Conexion.realizaraccion(sql);
                MessageBox.Show("Se ha eliminado el producto exitosamente",
                    "HUGO APP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar el producto",
                    "Error :c", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String sql = String.Format("SELECT * FROM APPORDER;");
            try
            {

                var dt = Conexion.realizarconsulta(sql);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Datosobtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
