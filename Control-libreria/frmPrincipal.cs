using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
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
            txt1.Visible = true;
            
            lbl1.Visible = true;
            
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

       // private void btnUpdate_Click(object sender, EventArgs e)
       // {
       //     MySqlConnection conn = conexion.conex();
       //     conn.Open();
       //     DialogResult seg = MessageBox.Show("¿Seguro que desea actualizar estos datos?", "Actualizar datos",
       //         MessageBoxButtons.YesNo);
       //     if (seg == DialogResult.Yes)
       //     { switch (tablas)
       //         {
       //             case "usuarios":
//
       //                 if (txt3.Text == "")
       //                 {
       //                     MessageBox.Show("No puede quedar vacia la contraseña");
       //                 }
       //                 else
       //                 {
       //                     control ctrl1 = new control();
       //                     string upd1 =
       //                         "update usuarios set usuario=@usuario,password=@password,nombre=@nombre,id_tipo=@tipo where id=@id;";
       //                     MySqlCommand cmd = new MySqlCommand(upd1, conn);
       //                     cmd.Parameters.AddWithValue("@usuario", txt2.Text);
       //                     cmd.Parameters.AddWithValue("@password", ctrl1.generarSHA1(txt3.Text));
       //                     cmd.Parameters.AddWithValue("@nombre", txt4.Text);
       //                     cmd.Parameters.AddWithValue("@tipo", cboType.SelectedIndex + 1);
       //                     cmd.Parameters.AddWithValue("@id", int.Parse(txt1.Text));
       //                     cmd.ExecuteNonQuery();
       //                     string load1 = "select * from " + tablas + " ;";
       //                     MySqlCommand cmdld = new MySqlCommand(load1, conexion.conex());
       //                     MySqlDataAdapter adp = new MySqlDataAdapter();
       //                     adp.SelectCommand = cmdld;
       //                     DataTable tabla1 = new DataTable();
       //                     adp.Fill(tabla1);
       //                     dgvGen.DataSource = tabla1;
       //                     clear();
       //                     conn.Close();
       //                 }
//
       //                 MessageBox.Show("Datos actualizados");
//
       //                 break;
//
       //             case "tb_autores":
       //                 string strRgx1 = "^[A][0-9]{3}";
       //                 Regex rg1 = new Regex(strRgx1);
       //                 Match c1 = rg1.Match(txt1.Text);
//
       //                 string strRgx2 = "^[N][0-9]{3}";
       //                 Regex rg2 = new Regex(strRgx2);
       //                 Match c2 = rg2.Match(txt4.Text);
       //                 if (c1.Success && c2.Success)
       //                 {
       //                     try
       //                     {
       //                         string upd2 =
       //                             "update tb_autores set nombre=@nombre,ap=@ap,id_nac=@naci where id_aut=@aut;";
       //                         MySqlCommand cmd2 = new MySqlCommand(upd2, conn);
       //                         cmd2.Parameters.AddWithValue("@aut", txt1.Text);
       //                         cmd2.Parameters.AddWithValue("@nombre", txt2.Text);
       //                         cmd2.Parameters.AddWithValue("@ap", txt3.Text);
       //                         cmd2.Parameters.AddWithValue("@naci", txt4.Text);
       //                         cmd2.ExecuteNonQuery();
       //                         conn.Close();
       //                     }
       //                     catch (Exception exception)
       //                     {
       //                         Console.WriteLine(exception);
       //                         throw;
       //                     }
//
       //                     string load2 = "select * from " + tablas + " ;";
       //                     MySqlCommand cmdld2 = new MySqlCommand(load2, conexion.conex());
       //                     MySqlDataAdapter adp2 = new MySqlDataAdapter();
       //                     adp2.SelectCommand = cmdld2;
       //                     DataTable tabla2 = new DataTable();
       //                     adp2.Fill(tabla2);
       //                     dgvGen.DataSource = tabla2;
       //                     conn.Close();
       //                     clear();
       //                     MessageBox.Show("Datos actualizados");
       //                 }
       //                 else
       //                 {
       //                     MessageBox.Show("Valores no cumplen con el Formato");
       //                 }
//
       //                 break;
//
       //             case "tb_editoriales":
       //                 string strRgx3 = "^[E][0-9]{3}";
       //                 Regex rg3 = new Regex(strRgx3);
       //                 Match c3 = rg3.Match(txt1.Text);
       //                 if (c3.Success)
       //                 {
       //                     try
       //                     {
       //                         string upd4 =
       //                             "update tb_editoriales set nom_edito=@nomedito,direcc=@direcc,email=@email,tel=@tel where id_edito=@idedito;";
       //                         MySqlCommand cmd3 = new MySqlCommand(upd4, conn);
       //                         cmd3.Parameters.AddWithValue("@nomedito", txt2.Text.ToUpper());
       //                         cmd3.Parameters.AddWithValue("@direcc", txt3.Text.ToUpper());
       //                         cmd3.Parameters.AddWithValue("@email", txt4.Text);
       //                         cmd3.Parameters.AddWithValue("@tel", Int64.Parse(txt5.Text));
       //                         cmd3.Parameters.AddWithValue("@idedito", txt1.Text);
       //                         cmd3.ExecuteNonQuery();
       //                         conn.Close();
//
       //                     }
       //                     catch (Exception exception)
       //                     {
       //                         Console.WriteLine(exception);
       //                         throw;
       //                     }
//
       //                     string load4 = "select * from " + tablas + " ;";
       //                     MySqlCommand cmdld4 = new MySqlCommand(load4, conexion.conex());
       //                     MySqlDataAdapter adp4 = new MySqlDataAdapter();
       //                     adp4.SelectCommand = cmdld4;
       //                     DataTable tabla4 = new DataTable();
       //                     adp4.Fill(tabla4);
       //                     dgvGen.DataSource = tabla4;
       //                     conn.Close();
       //                     MessageBox.Show("Datos actualizados");
       //                     clear();
       //                 }
       //                 else
       //                 {
       //                     MessageBox.Show("Valores no cumplen con el Formato");
       //                 }
//
       //                 break;
//
       //             case "tb_temas":
//
       //                 string strRgx4 = "^[T][0-9]+";
       //                 Regex rg4 = new Regex(strRgx4);
       //                 Match c4 = rg4.Match(txt1.Text);
//
       //                 if (c4.Success)
       //                 {
       //                     try
       //                     {
       //                         string upd3 = "update tb_temas set nom_tema=@nomtema where id_tema=@idtema;";
       //                         MySqlCommand cmd3 = new MySqlCommand(upd3, conn);
       //                         cmd3.Parameters.AddWithValue("@nomtema", txt4.Text.ToUpper());
       //                         cmd3.Parameters.AddWithValue("@idtema", txt1.Text);
       //                         cmd3.ExecuteNonQuery();
       //                         conn.Close();
       //                     }
       //                     catch (Exception exception)
       //                     {
       //                         Console.WriteLine(exception);
       //                         throw;
       //                     }
//
       //                     string load3 = "select * from " + tablas + " ;";
       //                     MySqlCommand cmdld3 = new MySqlCommand(load3, conexion.conex());
       //                     MySqlDataAdapter adp3 = new MySqlDataAdapter();
       //                     adp3.SelectCommand = cmdld3;
       //                     DataTable tabla3 = new DataTable();
       //                     adp3.Fill(tabla3);
       //                     dgvGen.DataSource = tabla3;
       //                     conn.Close();
       //                     clear();
       //                     MessageBox.Show("Datos actualizados");
       //                 }
       //                 else
       //                 {
       //                     MessageBox.Show("Valores no cumplen con el Formato");
       //                 }
//
       //                 break;
//
       //             case "tb_libros":
       //                 string strRgx11 = "^[A][0-9]{3}";
       //                 Regex rg11 = new Regex(strRgx11);
       //                 Match c11 = rg11.Match(txt5.Text);
//
       //                 string strRgx31 = "^[E][0-9]{3}";
       //                 Regex rg31 = new Regex(strRgx31);
       //                 Match c31 = rg31.Match(txt7.Text);
//
       //                 string strRgx41 = "^[T][0-9]+";
       //                 Regex rg41 = new Regex(strRgx41);
       //                 Match c41 = rg41.Match(txt8.Text);
//
       //                 string strRgx5 = "^[L][0-9]{3}";
       //                 Regex rg5 = new Regex(strRgx5);
       //                 Match c5 = rg5.Match(txt1.Text);
       //                 if (c5.Success && c11.Success && c31.Success && c41.Success)
       //                 {
       //                     try
       //                     {
       //                         string upd4 =
       //                             "update tb_libros set titulo=@titulo,anio_edic=@anio,n_pag=@pag,id_aut=@aut,precio=@precio,id_edito=@edito,id_tema=@tema where id_libro=@libro;";
       //                         MySqlCommand cmd4 = new MySqlCommand(upd4, conn);
       //                         cmd4.Parameters.AddWithValue("@titulo", txt2.Text);
       //                         cmd4.Parameters.AddWithValue("@anio", int.Parse(txt3.Text));
       //                         cmd4.Parameters.AddWithValue("@pag", int.Parse(txt4.Text));
       //                         cmd4.Parameters.AddWithValue("@aut", txt5.Text);
       //                         cmd4.Parameters.AddWithValue("@precio", decimal.Parse(txt6.Text));
       //                         cmd4.Parameters.AddWithValue("@edito", txt7.Text);
       //                         cmd4.Parameters.AddWithValue("@tema", txt8.Text);
       //                         cmd4.Parameters.AddWithValue("@libro", txt1.Text);
       //                         cmd4.ExecuteNonQuery();
       //                         conn.Close();
//
       //                     }
       //                     catch (Exception exception)
       //                     {
       //                         Console.WriteLine(exception);
       //                         throw;
       //                     }
//
       //                     MessageBox.Show("Datos actualizados");
       //                     clear();
       //                     string load5 = "select * from " + tablas + " ;";
       //                     MySqlCommand cmdld5 = new MySqlCommand(load5, conexion.conex());
       //                     MySqlDataAdapter adp5 = new MySqlDataAdapter();
       //                     adp5.SelectCommand = cmdld5;
       //                     DataTable tabla5 = new DataTable();
       //                     adp5.Fill(tabla5);
       //                     dgvGen.DataSource = tabla5;
       //                     conn.Close();
//
       //                 }
       //                 else
       //                 {
       //                     MessageBox.Show("Valores no cumplen con el Formato");
       //                 }
//
       //                 break;
       //             case "tb_nacionalidad":
       //                 string strRgx6 = "^[N][0-9]{3}";
       //                 Regex rg6 = new Regex(strRgx6);
       //                 Match c6 = rg6.Match(txt1.Text);
       //                 if (c6.Success)
       //                 {
//
       //                     try
       //                     {
       //                         string upd6 = "update tb_nacionalidad set descri=@nomnaci where id_nac=@idnac;";
       //                         MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
       //                         cmd6.Parameters.AddWithValue("@nomnaci", txt2.Text.ToUpper());
       //                         cmd6.Parameters.AddWithValue("@idnac", txt1.Text);
       //                         cmd6.ExecuteNonQuery();
       //                         conn.Close();
       //                     }
       //                     catch (Exception exception)
       //                     {
       //                         Console.WriteLine(exception);
       //                         throw;
       //                     }
//
       //                     clear();
       //                     string load3 = "select * from " + tablas + " ;";
       //                     MySqlCommand cmdld3 = new MySqlCommand(load3, conexion.conex());
       //                     MySqlDataAdapter adp3 = new MySqlDataAdapter();
       //                     adp3.SelectCommand = cmdld3;
       //                     DataTable tabla3 = new DataTable();
       //                     adp3.Fill(tabla3);
       //                     dgvGen.DataSource = tabla3;
       //                     conn.Close();
       //                     MessageBox.Show("Datos actualizados");
       //                 }
       //                 else
       //                 {
       //                     MessageBox.Show("Valores no cumplen con el Formato");
       //                 }
//
       //                 break;
//
       //         }
       //     }
       //     else
       //     {
       //         clear();
       //         txt1.ReadOnly = false;
       //     }
       //     
       // }

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
        {bntCreate.Enabled = false;
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
            //visible labels y textboxs
            lbl1.Visible = true;
            txt1.Visible = true;

            //cambio de texto
            lbl1.Text = "Id";
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
            //visible labels y textboxs
            lbl1.Visible = true;
            txt1.Visible = true;
            
            //cambio de texto
            lbl1.Text = "Id";
            btnUpdate.Enabled = false;
            clear();
        }

        private void dgvGen_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt1.ReadOnly = true;
            btnBorrar.Enabled = true;
            bntCreate.Enabled = false;
            switch (tablas)
            {
                case "usuarios":
                    
                    
                    txt1.Text=dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "tb_autores":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "tb_editoriales":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                   break;
                case "tb_temas":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    break;
                case "tb_libros":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                   break;
                case "tb_nacionalidad":
                    txt1.Text = dgvGen.Rows[e.RowIndex].Cells[0].Value.ToString();
                    
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
            frmCreate frmCreate = new frmCreate();
            frmCreate.Visible = true;
        }
        public DataGridView dvgGem { get; set; }

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
            DialogResult seg = MessageBox.Show("¿Seguro que desea eliminar estos datos?", "Eliminar datos",
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
            if (tablas=="usuarios" || tablas=="tb_auditoria" || tablas=="tb_eliminados")
            {
                clear();
                bntCreate.Enabled = false;
                txt1.ReadOnly = false;
            }
            else
            {
                clear();
                bntCreate.Enabled = true;
                txt1.ReadOnly = false;
            }
            
        }
    }
}