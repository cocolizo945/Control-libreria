using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Control_libreria
{
    public partial class frmPrincipal : Form
    {
        int userType;
        public frmPrincipal()
        {
            InitializeComponent();
            userType = sesion.id_tipo;

            if (userType == 1)
            {
                this.strpadminusers.Visible = true;
                this.stripAudito.Visible = true;
                
            }
            else
            {
                this.strpadminusers.Visible = false;
                this.stripAudito.Visible = false;
            }
        }

        private void subStripRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Visible = true;
           
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.dgvGen.Visible = true;
            string load = "select * from usuarios ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            conexion.conex().Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            conexion.conex().Close();
            this.Close();
            Form1 frm = new Form1();
            frm.Visible = true;

            sesion ss = new sesion();
        }
    }
}