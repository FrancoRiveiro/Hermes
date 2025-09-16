using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DAL.Implemenaciones;
using Seguridad;
namespace BLL
{
    public class BLL_Usuario
    {
        private UsuarioBD dal;
        public BLL_Usuario()
        {
             dal = new UsuarioBD();
        }
        

        public BE_Usuario Login(string email, string contraseña)
        {
            //validaciones
           if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contraseña))
            {
                throw new ArgumentException("No se aceptan campos vacíos.");
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                throw new ArgumentException("El Email ingresado no es válido. Asegúrese de que contenga '@' y un dominio válido.");
            }


            BE_Usuario usuario = dal.ObtenerUsuarioPorEmail(email);
            if (usuario == null)
            {
                throw new Exception("Usuario no encontrado.");
            }


            string hashContraseña = Seguridad.ContraseñaHasher.GenerarHash(contraseña);
            if (usuario.Contraseña != hashContraseña)
            {
                throw new Exception("Contraseña incorrecta.");
            }

            SesionManagger.IniciarSesion(usuario);
            return usuario;
        }   

        public IEnumerable<BE_Usuario> ObtenerTodos()
        {
            return dal.listar();
        }



        public bool SesionActiva()
        {
            return Seguridad.SesionManagger.SesionActiva;
        }

        public BE_Usuario UsuarioActual()
        {
            return Seguridad.SesionManagger.Instancia.Usuario;
        }

        public void Registrar(BE_Usuario usuario)
        {

            if (usuario == null)
            {
                throw new ArgumentNullException("El usuario no puede tener campos vacios ");

            }
            else 
            {
            
            usuario.Contraseña = Seguridad.ContraseñaHasher.GenerarHash(usuario.Contraseña);

            dal.Agrear(usuario);
            }

        }

    }
}
