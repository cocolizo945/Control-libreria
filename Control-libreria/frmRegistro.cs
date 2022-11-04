using System;
using System.Windows.Forms;

namespace Control_libreria
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }


        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            usuarios usuario = new usuarios();
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConPassword = txtConPassword.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Cbo_tipo = cboTipo.SelectedIndex;

            try
            {

                control contrl = new control();
                string respuesta = contrl.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}