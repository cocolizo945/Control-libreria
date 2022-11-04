using System;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Control_libreria
{
    
    public class conexion
    {

        public static MySqlConnection conex()
        {
            
            string server = "localhost";
            string usr = "root";
            string pws = "123456789";
            string db = "libreria";

            string chain = "server =" + server + "; user =" + usr + "; pwd=" + pws + "; database=" + db + " ;";

            MySqlConnection conexion = new MySqlConnection(chain);

            return conexion;
        }
    }
}