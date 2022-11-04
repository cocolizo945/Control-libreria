using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Control_libreria
{
    class control
    {
         public string ctrlRegistro(usuarios usuario)
        {
            modelo model = new modelo();
            string respuesta = "";

            if(string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConPassword) || string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "Debe llenar todos los campos";
            } else
            {
                if(usuario.Password == usuario.ConPassword)
                {
                    if (model.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    } else
                    {
                        usuario.Password = generarSHA1(usuario.Password);
                        usuario.Id_tipo = usuario.Cbo_tipo+1;
                        model.registro(usuario);
                    }
                } else
                {
                    respuesta = "Las contraseña no coinciden";
                }
            }
            return respuesta;

        }

        public string ctrlLogin(string usuario, string password)
        {
            modelo model = new modelo();
            string respuesta = "";
            usuarios datosUsuario = null;

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            } else
            {
                datosUsuario = model.porUsuario(usuario);

                if(datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                } else
                {
                    if(datosUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    } else
                    {
                        sesion.id = datosUsuario.Id;
                        sesion.usuario = usuario;
                        sesion.nombre = datosUsuario.Nombre;
                        sesion.id_tipo = datosUsuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }

    }
    }
