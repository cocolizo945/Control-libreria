using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Control_libreria
{
    public partial class frmCreate : Form
    {
        MySqlConnection conn = conexion.conex();
        string tables = principal.Tablas;
        
        public frmCreate()
        {
            InitializeComponent();
            mostrar();
        }

        public void mostrar()
        {
            ocultar();
            switch (principal.Tablas)
            {
                case "tb_autores":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl3.Visible = true;
                    lbl4.Visible = true;
                    // cambio de texto
                    lbl1.Text = "Id Autor";
                    lbl2.Text = "Nombre";
                    lbl3.Text = "Apellidos";
                    lbl4.Text = "Id nacionalidad";
                    break;
                case "tb_libros":
                    //visible labels y textbox
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl3.Visible = true;
                    lbl4.Visible = true;
                    lbl5.Visible = true;
                    lbl6.Visible = true;
                    lbl7.Visible = true;
                    lbl8.Visible = true;
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;
                    txt6.Visible = true;
                    txt7.Visible = true;
                    txt8.Visible = true;
                    //cambio de texto
                    lbl1.Text = "Id libro";
                    lbl2.Text = "titulo";
                    lbl3.Text = "Edicion";
                    lbl4.Text = "Num paginas";
                    lbl5.Text = "Autor";
                    lbl6.Text = "Precio";
                    lbl7.Text = "Editorial";
                    lbl8.Text = "Tema";
                    break;
                case "tb_temas":
                    //visible label y textbox
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    //cambio de texto
                    lbl1.Text = "Tema";
                    lbl2.Text = "Nombre tema";
                    break;
                case "tb_nacionalidad":
                    //text box and combo box visible 
                    txt1.Visible = true;
                    txt2.Visible = true;
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    //labels visible
                    lbl1.Text = "Id nacionalidad";
                    lbl2.Text = "Descripcion";
                    break;
                case "tb_editoriales":
                    //visible textbox y labels
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    txt5.Visible = true;
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl3.Visible = true;
                    lbl4.Visible = true;
                    lbl5.Visible = true;
                    //cambio de label
                    lbl1.Text = "Editorial";
                    lbl2.Text = "Nombre";
                    lbl3.Text = "Direccion";
                    lbl4.Text = "Email";
                    lbl5.Text = "Telefono";
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult seg = MessageBox.Show("¿Seguro que desea ingresar estos datos?", "Ingresar datos",
                MessageBoxButtons.YesNo);
            if (seg == DialogResult.Yes)
            { 
                switch (tables)
                {

                    case "tb_autores":
                        
                        string strRgx1 = "^[A][0-9]{3}";
                        Regex rg1 = new Regex(strRgx1);
                        Match c1 = rg1.Match(txt1.Text);

                        string strRgx2 = "^[N][0-9]{3}";
                        Regex rg2 = new Regex(strRgx2);
                        Match c2 = rg2.Match(txt4.Text);
                        if (c1.Success && c2.Success)
                        {
                            try
                            {
                                string upd2 =
                                    "insert into tb_autores (id_aut,nombre,ap,id_nac) values (@aut,@nombre,@ap,@naci);";
                                MySqlCommand cmd2 = new MySqlCommand(upd2, conn);
                                cmd2.Parameters.AddWithValue("@aut", txt1.Text);
                                cmd2.Parameters.AddWithValue("@nombre", txt2.Text.ToUpper());
                                cmd2.Parameters.AddWithValue("@ap", txt3.Text.ToUpper());
                                cmd2.Parameters.AddWithValue("@naci", txt4.Text);
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Los valores no cumplen con el Formato");
                        }

                        break;

                    case "tb_editoriales":
                        string strRgx3 = "^[E][0-9]{3}";
                        Regex rg3 = new Regex(strRgx3);
                        Match c3 = rg3.Match(txt1.Text);
                        if (c3.Success)
                        {
                            try
                            {
                                string upd4 =
                                    "insert into tb_editoriales(id_edito,nom_edito,direcc,email,tel) values (@idedito,@nomedito,@direcc,@email,@tel);";
                                MySqlCommand cmd3 = new MySqlCommand(upd4, conn);
                                cmd3.Parameters.AddWithValue("@nomedito", txt2.Text.ToUpper());
                                cmd3.Parameters.AddWithValue("@direcc", txt3.Text.ToUpper());
                                cmd3.Parameters.AddWithValue("@email", txt4.Text);
                                cmd3.Parameters.AddWithValue("@tel", Int64.Parse(txt5.Text));
                                cmd3.Parameters.AddWithValue("@idedito", txt1.Text);
                                cmd3.ExecuteNonQuery();
                                conn.Close();

                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Los valores no cumplen con el Formato");
                        }

                        break;

                    case "tb_temas":
                        string strRgx4 = "^[T][0-9]+";
                        Regex rg4 = new Regex(strRgx4);
                        Match c4 = rg4.Match(txt1.Text);

                        if (c4.Success)
                        {
                            try
                            {
                                string upd3 = "insert into tb_temas(id_tema,nom_tema) values(@idtema,@nomtema) ;";
                                MySqlCommand cmd3 = new MySqlCommand(upd3, conn);
                                cmd3.Parameters.AddWithValue("@nomtema", txt2.Text.ToUpper());
                                cmd3.Parameters.AddWithValue("@idtema", txt1.Text);
                                cmd3.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Los valores no cumplen con el Formato");
                        }

                        break;

                    case "tb_libros":
                        string strRgx11 = "^[A][0-9]{3}";
                        Regex rg11 = new Regex(strRgx11);
                        Match c11 = rg11.Match(txt5.Text);

                        string strRgx31 = "^[E][0-9]{3}";
                        Regex rg31 = new Regex(strRgx31);
                        Match c31 = rg31.Match(txt7.Text);

                        string strRgx41 = "^[T][0-9]+";
                        Regex rg41 = new Regex(strRgx41);
                        Match c41 = rg41.Match(txt8.Text);

                        string strRgx5 = "^[L][0-9]{3}";
                        Regex rg5 = new Regex(strRgx5);
                        Match c5 = rg5.Match(txt1.Text);
                        if (c5.Success && c11.Success && c31.Success && c41.Success)
                        {
                            try
                            {
                                string upd4 =
                                    "insert into tb_libros(id_libro,titulo,anio_edic,n_pag,id_aut,precio,id_edito,id_tema) values (@libro,@titulo,@anio,@pag,@aut,@precio,@edito,@tema);";
                                MySqlCommand cmd4 = new MySqlCommand(upd4, conn);
                                cmd4.Parameters.AddWithValue("@titulo", txt2.Text);
                                cmd4.Parameters.AddWithValue("@anio", int.Parse(txt3.Text));
                                cmd4.Parameters.AddWithValue("@pag", int.Parse(txt4.Text));
                                cmd4.Parameters.AddWithValue("@aut", txt5.Text);
                                cmd4.Parameters.AddWithValue("@precio", decimal.Parse(txt6.Text));
                                cmd4.Parameters.AddWithValue("@edito", txt7.Text);
                                cmd4.Parameters.AddWithValue("@tema", txt8.Text);
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

                        }
                        else
                        {
                            MessageBox.Show("Los valores no cumplen con el Formato");
                        }

                        break;
                    
                    case "tb_nacionalidad":
                        string strRgx6 = "^[N][0-9]{3}";
                        Regex rg6 = new Regex(strRgx6);
                        Match c6 = rg6.Match(txt1.Text);
                        if (c6.Success)
                        {

                            try
                            {
                                string upd6 = "insert into tb_nacionalidad(id_nac,descri) values (@idnac,@nomnaci);";
                                MySqlCommand cmd6 = new MySqlCommand(upd6, conn);
                                cmd6.Parameters.AddWithValue("@nomnaci", txt2.Text.ToUpper());
                                cmd6.Parameters.AddWithValue("@idnac", txt1.Text);
                                cmd6.ExecuteNonQuery();
                                conn.Close();
                            }
                            catch (Exception exception)
                            {
                                Console.WriteLine(exception);
                                throw;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Los valores no cumplen con el Formato");
                        }

                        break;
                  
                    }
                }
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            ocultar();
            this.Close();
        }
        private void ocultar()
        {
            txt1.ReadOnly = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            txt1.Visible = false;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            txt7.Visible = false;
            txt8.Visible = false;
            cboType.Visible = false;
        }
        private void clear()
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            cboType.Text = "";
        }
    }
    }
