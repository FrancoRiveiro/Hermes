using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MPP.Mapers
{
    public static class UsuarioMPP
    {

        public static BE_Usuario FromSqlReader(SqlDataReader reader)
        {
            bool rol = Convert.ToBoolean(reader["Rol"]);

            if (rol)
            {
                return new BE_Administrador(
                   reader["Nombre"].ToString(),
                   reader["Apellido"].ToString(),
                   Convert.ToInt32(reader["DNI"]),
                   reader["Contraseña"].ToString(),
                   reader["Email"].ToString(),
                   rol,
                   Convert.ToInt32(reader["Telefono"])
               );

            }
            else 
            {
                return new BE_Cliente(
                    reader["Nombre"].ToString(),
                    reader["Apellido"].ToString(),
                    Convert.ToInt32(reader["DNI"]),
                    reader["Contraseña"].ToString(),
                    reader["Email"].ToString(),
                    rol,
                   Convert.ToInt32( reader["Telefono"])
                    ); 
            
            }
        }

        public static void ToSqlParameters(SqlCommand command, BE_Usuario usuario)
        {
           
            command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                command.Parameters.AddWithValue("@DNI", usuario.DNI);
                command.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Rol", usuario.Rol);
            command.Parameters.AddWithValue("@Telefono", usuario.Telefono);
        }
    }
}
