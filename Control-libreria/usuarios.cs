using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_libreria
{
    public class usuarios
    {
        int id, id_tipo, cbo_tipo;
        string usuario, password, conPassword, nombre;

        public string Usuario
        {
            get => usuario;
            set => usuario = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string ConPassword
        {
            get => conPassword;
            set => conPassword = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Id_tipo
        {
            get => id_tipo;
            set => id_tipo = value;
        }

        public int Cbo_tipo
        {
            get => cbo_tipo;
            set => cbo_tipo = value;
        }
    }
}