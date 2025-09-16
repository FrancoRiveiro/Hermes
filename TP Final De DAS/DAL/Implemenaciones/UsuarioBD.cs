using BE;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPP.Mapers; 

namespace DAL.Implemenaciones
{
    public class UsuarioBD : IABM<BE_Usuario>, IListar<BE_Usuario>
    {
        private readonly string connectionString;
        public UsuarioBD()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HermesBD"].ConnectionString;
        }
        public void Agrear(BE_Usuario entidad)
        {
            string query = "INSERT INTO Usuario (Nombre, Apellido, DNI, Contraseña, Email, Rol, Telefono) VALUES (@Nombre,@Apellido,@DNI,@Contraseña,@Email,@Rol,@Telefono)";

            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                using (SqlCommand comm = new SqlCommand(query, con))
                {

                    UsuarioMPP.ToSqlParameters(comm, entidad);              
                    con.Open();
                    comm.ExecuteNonQuery();

                }
               
             }   
        }

        public void Eliminar(BE_Usuario id)
        {
            string query = "DELETE FROM Usuario WHERE IdUsuario = @IDUser";

            using ( SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(query, con))
                {
                    comm.Parameters.AddWithValue("@IDUser", id.IdUsuario);
                    con.Open();
                    comm.ExecuteNonQuery();
                }
            }
        }

      
        public IEnumerable<BE_Usuario> listar()
        {
            List<BE_Usuario> usuarios = new List<BE_Usuario>();

            string query = "SELECT * FROM Usuario";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(query, con))
                {
                    con.Open();


                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(UsuarioMPP.FromSqlReader(reader));
                        }
                    }
                }
            }
            return usuarios;
        }

        public void Modificar(BE_Usuario entidad, params object[] datos)
        {
            string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Contraseña = @Contraseña, Email = @Email, Rol = @Rol, Telefono = @Telefono WHERE IdUsuario = @IDUser";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(query, con))
                {
                    UsuarioMPP.ToSqlParameters(comm, entidad);
                    //comm.Parameters.AddWithValue("@IDUser", datos[0]);
                    con.Open();
                    comm.ExecuteNonQuery();
                }
            }

        }

        public BE_Usuario ObtenerUsuarioPorEmail(string email)
        {
            BE_Usuario usuario = null;

            string query = "SELECT * FROM Usuario WHERE Email = @Email";
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand comm = new SqlCommand(query, con))
                {
                    comm.Parameters.AddWithValue("@Email", email);

                    con.Open();

                    using (SqlDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = UsuarioMPP.FromSqlReader(reader);
                        }
                    }
                }
            }
            return usuario;
        }

    }
}
