using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            poblarCombo();
        }

        private void poblarCombo()
        {

            cmbusuario.DataSource = null;
            cmbusuario.ValueMember = "contrasena";
            cmbusuario.DisplayMember = "usuario";
            cmbusuario.DataSource = usuarioDAO.getLista();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbusuario.SelectedValue.Equals(txtcontra.Text))
            {
                Appusuario u = (Appusuario) cmbusuario.SelectedItem;

                
                   

                    if (u.admin)
                    {

                        MessageBox.Show("¡Bienvenido Administrador!" ,"HUGO APP",MessageBoxButtons.OK , MessageBoxIcon.Information);
                        frminicioadmin ventana = new frminicioadmin(u);
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("¡Bienvenido " + u.usuario + "!" + "\nDisfruta de nuestras promociones para " +
                                        "la cuarentena", "HUGO APP" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frminiciousuario ventana = new frminiciousuario(u);
                        ventana.Show();
                        this.Hide();
                    }


                
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "ERROR :(",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        { frmcambiocontra unaVentana = new frmcambiocontra();
            unaVentana.ShowDialog();
            
        }
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
        }
    }
}