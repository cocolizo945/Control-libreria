using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Control_libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            
        }
        
        public void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtpws.Text;
            
            try
            {
                control ctrl = new control();
                string respuesta = ctrl.ctrlLogin(user, pass);
                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    frmPrincipal frm = new frmPrincipal();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}