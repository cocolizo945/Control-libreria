using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;

namespace Control_libreria
{
    public partial class frmPrincipal : Form
    {
        int userType;
        string tablas;
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
            bntCreate.Enabled = false;
            ocultar();
            principal.Tablas = "usuarios";
            tablas = "usuarios";
 
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();
            //text box and combo box visible 
            
            //change text
            lbl1.Text = "Id";
            btnUpdate.Enabled = true;
            clear();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            conexion.conex().Close();
            this.Close();
            Form1 frm = new Form1();
            frm.Visible = true;

            sesion ss = new sesion();
        }
        
        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = true;
            ocultar();
            tablas = "tb_autores";
            principal.Tablas = tablas;
            //llenado de tabla
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();
           
            btnUpdate.Enabled = true;
            clear();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = true;
            ocultar();
            tablas = "tb_libros";
            principal.Tablas = tablas;
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();
            btnUpdate.Enabled = true;
            clear();

        }


        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = true;
            ocultar();;
            tablas = "tb_temas";
            principal.Tablas = tablas;
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();
            
            btnUpdate.Enabled = true;
            clear();

        }

        private void nacionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = true;
            ocultar();
            tablas = "tb_nacionalidad";
            principal.Tablas = tablas;
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();
            btnUpdate.Enabled = true;
           clear();
            
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = true;
            ocultar();
            tablas = "tb_editoriales";
            principal.Tablas = tablas;
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();
            btnUpdate.Enabled = true;
            clear();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = false;
            ocultar();
            tablas = "tb_auditoria";
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.AutoResizeColumns();
            conexion.conex().Close();

            btnUpdate.Enabled = false;
            clear();
        }

        private void eliminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bntCreate.Enabled = false;
            ocultar();
            tablas = "tb_eliminados";
            string load = "select * from "+tablas+" ;";
            MySqlCommand cmdld = new MySqlCommand(load ,conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            conexion.conex().Close();
            btnUpdate.Enabled = false;
            clear();
        }

        private void dgvGen_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.ReadOnly = true;
            btnBorrar.Enabled = true;
            bntCreate.Enabled = true;
            switch (tablas)
            {
                case "usuarios":

                    txt1.Text=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text1=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text2=dgvGen.Rows[e.RowIndex].Cells[1].Value.ToString();
                    principal.Text4=dgvGen.Rows[e.RowIndex].Cells[3].Value.ToString();
                    principal.UserType=(int)dgvGen.Rows[e.RowIndex].Cells[4].Value;
                    break;
                case "tb_autores":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text1=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text2=dgvGen.Rows[e.RowIndex].Cells[1].Value.ToString();
                    principal.Text3=dgvGen.Rows[e.RowIndex].Cells[2].Value.ToString();
                    principal.Text4=dgvGen.Rows[e.RowIndex].Cells[3].Value.ToString();
                    break;
                case "tb_editoriales":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text1=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text2=dgvGen.Rows[e.RowIndex].Cells[1].Value.ToString();
                    principal.Text3=dgvGen.Rows[e.RowIndex].Cells[2].Value.ToString();
                    principal.Text4=dgvGen.Rows[e.RowIndex].Cells[3].Value.ToString();
                    principal.Text5=dgvGen.Rows[e.RowIndex].Cells[4].Value.ToString();
                   break;
                case "tb_temas":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text1=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text2=dgvGen.Rows[e.RowIndex].Cells[1].Value.ToString();
                    break;
                case "tb_libros":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text1=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text2=dgvGen.Rows[e.RowIndex].Cells[1].Value.ToString();
                    principal.Text3=dgvGen.Rows[e.RowIndex].Cells[2].Value.ToString();
                    principal.Text4=dgvGen.Rows[e.RowIndex].Cells[3].Value.ToString();
                    principal.Text5=dgvGen.Rows[e.RowIndex].Cells[4].Value.ToString();
                    principal.Text6=dgvGen.Rows[e.RowIndex].Cells[5].Value.ToString();
                    principal.Text7=dgvGen.Rows[e.RowIndex].Cells[6].Value.ToString();
                    principal.Text8=dgvGen.Rows[e.RowIndex].Cells[7].Value.ToString();
                   break;
                case "tb_nacionalidad":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text1=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    principal.Text2=dgvGen.Rows[e.RowIndex].Cells[1].Value.ToString();
                    
                    break;
                case "tb_auditoria":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "tb_eliminados":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
            }
        }

        private void ocultar()
        {
            txt1.ReadOnly = false;
            lbl1.Visible = false;
            txt1.Visible = false;
        }

        private void clear()
        {
            btnBorrar.Enabled = false;
            txt1.Text = "";
  
        }


        private void bntCreate_Click(object sender, EventArgs e)
        {
            principal.Action = 1;
            frmCreate frmCreate = new frmCreate();
            frmCreate.Visible = true;
            frmCreate.Text = "Ingresar Datos";
            
        }
        
        public void updatedvg()
        {
            
            conexion.conex().Open();
            string load = "select * from " + principal.Tablas + " ;";
            MySqlCommand cmdld = new MySqlCommand(load, conexion.conex());
            MySqlDataAdapter adp = new MySqlDataAdapter();
            adp.SelectCommand = cmdld;
            DataTable tabla1 = new DataTable();
            adp.Fill(tabla1);
            dgvGen.DataSource = tabla1;
            dgvGen.Update();
            conexion.conex().Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = conexion.conex();
            conn.Open();
            DialogResult seg = MessageBox.Show("¿Seguro que desea eliminar estos datos? \n id "+txt1.Text, "Eliminar datos",
                MessageBoxButtons.YesNo);
            if (seg == DialogResult.Yes)
            { 
                switch (tablas)
                {
                    case "usuarios":
                        try
                        {
                            string dlt = "delete from usuarios where id=@id;";
                            MySqlCommand cmd1 = new MySqlCommand(dlt, conn);
                            cmd1.Parameters.AddWithValue("@id", txt1.Text);
                            cmd1.ExecuteNonQuery();
                            
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }
                        string load1 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld1 = new MySqlCommand(load1, conexion.conex());
                        MySqlDataAdapter adp1 = new MySqlDataAdapter();
                        adp1.SelectCommand = cmdld1;
                        DataTable tabla1 = new DataTable();
                        adp1.Fill(tabla1);
                        dgvGen.DataSource = tabla1;
                        conn.Close();
                        clear();
                        MessageBox.Show("Datos Eliminados");
                        break;

                    case "tb_autores":
                       
                            try
                            {
                                string upd2 =
                                    "delete from tb_autores where id_aut=@aut;";
                                MySqlCommand cmd2 = new MySqlCommand(upd2, conn);
                                cmd2.Parameters.AddWithValue("@aut", txt1.Text);
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }

                            string load2 = "select * from " + tablas + " ;";
                            MySqlCommand cmdld2 = new MySqlCommand(load2, conexion.conex());
                            MySqlDataAdapter adp2 = new MySqlDataAdapter();
                            adp2.SelectCommand = cmdld2;
                            DataTable tabla2 = new DataTable();
                            adp2.Fill(tabla2);
                            dgvGen.DataSource = tabla2;
                            conn.Close();
                            clear();
                            MessageBox.Show("Datos Eliminados");

                            break;

                    case "tb_editoriales":
                        try
                            {
                                string upd4 =
                                    "delete from tb_editoriales where id_edito=@idedito;";
                                MySqlCommand cmd3 = new MySqlCommand(upd4, conn);
                                cmd3.Parameters.AddWithValue("@idedito", txt1.Text);
                                cmd3.ExecuteNonQuery();
                                conn.Close();

                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }

                            string load4 = "select * from " + tablas + " ;";
                            MySqlCommand cmdld4 = new MySqlCommand(load4, conexion.conex());
                            MySqlDataAdapter adp4 = new MySqlDataAdapter();
                            adp4.SelectCommand = cmdld4;
                            DataTable tabla4 = new DataTable();
                            adp4.Fill(tabla4);
                            dgvGen.DataSource = tabla4;
                            conn.Close();
                            MessageBox.Show("Datos eliminados");
                            clear();

                        break;

                    case "tb_temas":
                        try
                            {
                                string upd3 = "delete from tb_temas where id_tema = @idtema ;";
                                MySqlCommand cmd3 = new MySqlCommand(upd3, conn);
                                cmd3.Parameters.AddWithValue("@idtema", txt1.Text);
                                cmd3.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }

                            string load3 = "select * from " + tablas + " ;";
                            MySqlCommand cmdld3 = new MySqlCommand(load3, conexion.conex());
                            MySqlDataAdapter adp3 = new MySqlDataAdapter();
                            adp3.SelectCommand = cmdld3;
                            DataTable tabla3 = new DataTable();
                            adp3.Fill(tabla3);
                            dgvGen.DataSource = tabla3;
                            conn.Close();
                            clear();
                            MessageBox.Show("Datos eliminados");
                       
                        break;

                    case "tb_libros":
                            try
                            {
                                string upd4 =
                                    "delete from tb_libros where id_libro=@libro;";
                                MySqlCommand cmd4 = new MySqlCommand(upd4, conn);
                                cmd4.Parameters.AddWithValue("@libro", txt1.Text);
                                cmd4.ExecuteNonQuery();
                                conn.Close();

                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }

                            MessageBox.Show("Datos Ingresados");
                            clear();
                            string load5 = "select * from " + tablas + " ;";
                            MySqlCommand cmdld5 = new MySqlCommand(load5, conexion.conex());
                            MySqlDataAdapter adp5 = new MySqlDataAdapter();
                            adp5.SelectCommand = cmdld5;
                            DataTable tabla5 = new DataTable();
                            adp5.Fill(tabla5);
                            dgvGen.DataSource = tabla5;
                            conn.Close();
                            
                        break;
                    
                    case "tb_nacionalidad":
                            try
                            {
                                string upd6 = "delete from tb_nacionalidad where id_nac=@idnac;";
                                MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                                cmd6.Parameters.AddWithValue("@idnac", txt1.Text);
                                cmd6.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }

                            clear();
                            string load7 = "select * from " + tablas + " ;";
                            MySqlCommand cmdld7 = new MySqlCommand(load7, conexion.conex());
                            MySqlDataAdapter adp7 = new MySqlDataAdapter();
                            adp7.SelectCommand = cmdld7;
                            DataTable tabla7 = new DataTable();
                            adp7.Fill(tabla7);
                            dgvGen.DataSource = tabla7;
                            conn.Close();
                            MessageBox.Show("Datos Eliminados");
                       

                        break;
                    
                    case "tb_auditoria":
                        try
                        {
                            string upd6 = "delete from tb_auditoria where id=@id;";
                            MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                            cmd6.Parameters.AddWithValue("@id", txt1.Text);
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        clear();
                        string load8 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld8 = new MySqlCommand(load8, conexion.conex());
                        MySqlDataAdapter adp8 = new MySqlDataAdapter();
                        adp8.SelectCommand = cmdld8;
                        DataTable tabla8 = new DataTable();
                        adp8.Fill(tabla8);
                        dgvGen.DataSource = tabla8;
                        conn.Close();
                        MessageBox.Show("Datos Eliminados");
                        
                        break;
                    
                    case "tb_eliminados":
                        try
                        {
                            string upd6 = "delete from tb_eliminados where id_=@id;";
                            MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                            cmd6.Parameters.AddWithValue("@id", txt1.Text);
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        clear();
                        string load9 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld9 = new MySqlCommand(load9, conexion.conex());
                        MySqlDataAdapter adp9 = new MySqlDataAdapter();
                        adp9.SelectCommand = cmdld9;
                        DataTable tabla9 = new DataTable();
                        adp9.Fill(tabla9);
                        dgvGen.DataSource = tabla9;
                        conn.Close();
                        MessageBox.Show("Datos Eliminados");
                        
                        break;

                }

                txt1.ReadOnly = false;
            }
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
			
            PrintPreviewDialog ppd = new PrintPreviewDialog {Document = doc};
            ((Form)ppd).WindowState = FormWindowState.Maximized;
			
            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep){
                const int DVG_ALTO=35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;
				
                foreach (DataGridViewColumn col in dgvGen.Columns){
                    ep.Graphics.DrawString(col.HeaderText, new Font("Times New Roman",16,FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width+35;
                }
                left=ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right-left, 3);
                top +=43;
				
                foreach (DataGridViewRow row in dgvGen.Rows){
                    if(row.Index == dgvGen.RowCount-1)break;
                    left =ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells){
                        ep.Graphics.DrawString(Convert.ToString(cell.Value),new Font("Segoe UI", 10),Brushes.Black, left, top+4);
                        //left+=cell.OwningColumn.Width;
                        left+=cell.OwningColumn.Width+35;
                    }
                    top+=DVG_ALTO;
                }
            };
            ppd.ShowDialog();
        }
            
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            principal.Action = 2;
            frmCreate frmCreate = new frmCreate();
            frmCreate.Visible = true;
            frmCreate.Text = "Actualizar Datos";
            

        }

        private void dgvGen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == (char)Keys.Delete)
            {
                MySqlConnection conn = conexion.conex();
            conn.Open();
            DialogResult seg = MessageBox.Show("¿Seguro que desea eliminar estos datos? \n id "+txt1.Text, "Eliminar datos",
                MessageBoxButtons.YesNo);
            if (seg == DialogResult.Yes && txt1.Text != "")
            {
                switch (tablas)
                {
                    case "usuarios":
                        try
                        {
                            string dlt = "delete from usuarios where id=@id;";
                            MySqlCommand cmd1 = new MySqlCommand(dlt, conn);
                            cmd1.Parameters.AddWithValue("@id", txt1.Text);
                            cmd1.ExecuteNonQuery();

                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        string load1 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld1 = new MySqlCommand(load1, conexion.conex());
                        MySqlDataAdapter adp1 = new MySqlDataAdapter();
                        adp1.SelectCommand = cmdld1;
                        DataTable tabla1 = new DataTable();
                        adp1.Fill(tabla1);
                        dgvGen.DataSource = tabla1;
                        conn.Close();
                        clear();
                        MessageBox.Show("Datos Eliminados");
                        break;

                    case "tb_autores":

                        try
                        {
                            string upd2 =
                                "delete from tb_autores where id_aut=@aut;";
                            MySqlCommand cmd2 = new MySqlCommand(upd2, conn);
                            cmd2.Parameters.AddWithValue("@aut", txt1.Text);
                            cmd2.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        string load2 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld2 = new MySqlCommand(load2, conexion.conex());
                        MySqlDataAdapter adp2 = new MySqlDataAdapter();
                        adp2.SelectCommand = cmdld2;
                        DataTable tabla2 = new DataTable();
                        adp2.Fill(tabla2);
                        dgvGen.DataSource = tabla2;
                        conn.Close();
                        clear();
                        MessageBox.Show("Datos Eliminados");

                        break;

                    case "tb_editoriales":
                        try
                        {
                            string upd4 =
                                "delete from tb_editoriales where id_edito=@idedito;";
                            MySqlCommand cmd3 = new MySqlCommand(upd4, conn);
                            cmd3.Parameters.AddWithValue("@idedito", txt1.Text);
                            cmd3.ExecuteNonQuery();
                            conn.Close();

                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        string load4 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld4 = new MySqlCommand(load4, conexion.conex());
                        MySqlDataAdapter adp4 = new MySqlDataAdapter();
                        adp4.SelectCommand = cmdld4;
                        DataTable tabla4 = new DataTable();
                        adp4.Fill(tabla4);
                        dgvGen.DataSource = tabla4;
                        conn.Close();
                        MessageBox.Show("Datos eliminados");
                        clear();

                        break;

                    case "tb_temas":
                        try
                        {
                            string upd3 = "delete from tb_temas where id_tema = @idtema ;";
                            MySqlCommand cmd3 = new MySqlCommand(upd3, conn);
                            cmd3.Parameters.AddWithValue("@idtema", txt1.Text);
                            cmd3.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        string load3 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld3 = new MySqlCommand(load3, conexion.conex());
                        MySqlDataAdapter adp3 = new MySqlDataAdapter();
                        adp3.SelectCommand = cmdld3;
                        DataTable tabla3 = new DataTable();
                        adp3.Fill(tabla3);
                        dgvGen.DataSource = tabla3;
                        conn.Close();
                        clear();
                        MessageBox.Show("Datos eliminados");

                        break;

                    case "tb_libros":
                        try
                        {
                            string upd4 =
                                "delete from tb_libros where id_libro=@libro;";
                            MySqlCommand cmd4 = new MySqlCommand(upd4, conn);
                            cmd4.Parameters.AddWithValue("@libro", txt1.Text);
                            cmd4.ExecuteNonQuery();
                            conn.Close();

                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        MessageBox.Show("Datos Ingresados");
                        clear();
                        string load5 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld5 = new MySqlCommand(load5, conexion.conex());
                        MySqlDataAdapter adp5 = new MySqlDataAdapter();
                        adp5.SelectCommand = cmdld5;
                        DataTable tabla5 = new DataTable();
                        adp5.Fill(tabla5);
                        dgvGen.DataSource = tabla5;
                        conn.Close();

                        break;

                    case "tb_nacionalidad":
                        try
                        {
                            string upd6 = "delete from tb_nacionalidad where id_nac=@idnac;";
                            MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                            cmd6.Parameters.AddWithValue("@idnac", txt1.Text);
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        clear();
                        string load7 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld7 = new MySqlCommand(load7, conexion.conex());
                        MySqlDataAdapter adp7 = new MySqlDataAdapter();
                        adp7.SelectCommand = cmdld7;
                        DataTable tabla7 = new DataTable();
                        adp7.Fill(tabla7);
                        dgvGen.DataSource = tabla7;
                        conn.Close();
                        MessageBox.Show("Datos Eliminados");


                        break;

                    case "tb_auditoria":
                        try
                        {
                            string upd6 = "delete from tb_auditoria where id=@id;";
                            MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                            cmd6.Parameters.AddWithValue("@id", txt1.Text);
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        clear();
                        string load8 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld8 = new MySqlCommand(load8, conexion.conex());
                        MySqlDataAdapter adp8 = new MySqlDataAdapter();
                        adp8.SelectCommand = cmdld8;
                        DataTable tabla8 = new DataTable();
                        adp8.Fill(tabla8);
                        dgvGen.DataSource = tabla8;
                        conn.Close();
                        MessageBox.Show("Datos Eliminados");

                        break;

                    case "tb_eliminados":
                        try
                        {
                            string upd6 = "delete from tb_eliminados where id_=@id;";
                            MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                            cmd6.Parameters.AddWithValue("@id", txt1.Text);
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }

                        clear();
                        string load9 = "select * from " + tablas + " ;";
                        MySqlCommand cmdld9 = new MySqlCommand(load9, conexion.conex());
                        MySqlDataAdapter adp9 = new MySqlDataAdapter();
                        adp9.SelectCommand = cmdld9;
                        DataTable tabla9 = new DataTable();
                        adp9.Fill(tabla9);
                        dgvGen.DataSource = tabla9;
                        conn.Close();
                        MessageBox.Show("Datos Eliminados");

                        break;

                }

                txt1.ReadOnly = false;
            }
            else
                MessageBox.Show("Nada que eliminar");
            }
        }
    }
}