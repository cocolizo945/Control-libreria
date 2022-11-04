using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Control_libreria
{
    public class modelo
    {
        private MySqlConnection conn = conexion.conex();
        public int registro(usuarios user)
        {
            MySqlConnection conexion = conn;
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, password, nombre, id_tipo) VALUES(@usuario, @password, @nombre, @id_tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", user.Usuario);
            comando.Parameters.AddWithValue("@password", user.Password);
            comando.Parameters.AddWithValue("@nombre", user.Nombre);
            comando.Parameters.AddWithValue("@id_tipo", user.Id_tipo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Control_libreria.conexion.conex();
            conexion.Open();

            string sql = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public usuarios porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = conn;
            conexion.Open();

            string sql = "SELECT id, password, nombre, id_tipo FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            usuarios usr = null;

            while (reader.Read())
            {
                usr = new usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }
            return usr;
        }
    }
}