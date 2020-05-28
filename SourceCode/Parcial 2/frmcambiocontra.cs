using System;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class frmcambiocontra : Form
    {
        public frmcambiocontra()
        {
            InitializeComponent();
        }
        private void frmcambiocontra_Load(object sender, EventArgs e)
        {
            
            cmbuser.DataSource = null;
            cmbuser.ValueMember = "contrasena";
            cmbuser.DisplayMember = "usuario";
            cmbuser.DataSource = usuarioDAO.getLista();
        }


        private void button1_Click(object sender, EventArgs e)
        {   bool actual = cmbuser.SelectedValue.Equals(textcontra.Text);
            bool nuevaconfirm = textnueva.Text.Equals(textnuevacon.Text);
            bool nuevasize = textnueva.Text.Length > 5;
            
            if (actual && nuevaconfirm && nuevasize)
            {
                try
                {
                    usuarioDAO.actualizarcontra(cmbuser.Text, textnueva.Text);
                    
                    MessageBox.Show("Su contraseña se ha actualizado!", 
                        "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al cambiar su contraseña!", 
                        "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Datos erroneos", 
                    "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bttncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}